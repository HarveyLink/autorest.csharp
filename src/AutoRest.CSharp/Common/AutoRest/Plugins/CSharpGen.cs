﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AutoRest.CSharp.AutoRest.Communication;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Responses;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.Simplification;
using Microsoft.CodeAnalysis.Text;
using Diagnostic = Microsoft.CodeAnalysis.Diagnostic;

namespace AutoRest.CSharp.AutoRest.Plugins
{
    [PluginName("csharpgen")]
    internal class CSharpGen : IPlugin
    {
        public async Task<GeneratedCodeWorkspace> ExecuteAsync(Task<CodeModel> codeModelTask, Configuration configuration)
        {
            ValidateConfiguration (configuration);

            Directory.CreateDirectory(configuration.OutputFolder);
            var projectDirectory = Path.Combine(configuration.OutputFolder, configuration.ProjectFolder);
            var project = await GeneratedCodeWorkspace.Create(projectDirectory, configuration.OutputFolder, configuration.SharedSourceFolders);
            var sourceInputModel = new SourceInputModel(await project.GetCompilationAsync());

            var codeModel = await codeModelTask;

            if (configuration.DataPlane)
            {
                LowLevelTarget.Execute(project, codeModel, sourceInputModel, configuration);
            }
            else if (configuration.AzureArm)
            {
                if (configuration.MgmtConfiguration.TestModeler is not null)
                {
                    MgmtTestTarget.Execute(project, codeModel, sourceInputModel, configuration);
                }
                else
                {
                    MgmtTarget.Execute(project, codeModel, sourceInputModel, configuration);
                }
            }
            else
            {
                DataPlaneTarget.Execute(project, codeModel, sourceInputModel, configuration);
            }
            return project;
        }

        private static void ValidateConfiguration (Configuration configuration)
        {
            if (configuration.DataPlane && configuration.AzureArm)
            {
                throw new Exception("Enabling both 'data-plane' and 'azure-arm' at the same time is not supported.");
            }
        }

        public async Task<bool> Execute(IPluginCommunication autoRest)
        {
            string codeModelFileName = (await autoRest.ListInputs()).FirstOrDefault();
            if (string.IsNullOrEmpty(codeModelFileName))
                throw new Exception("Generator did not receive the code model file.");

            var configuration = Configuration.GetConfiguration(autoRest);

            string codeModelYaml = string.Empty;

            Task<CodeModel> codeModelTask = Task.Run(async () =>
            {
                codeModelYaml = await autoRest.ReadFile(codeModelFileName);
                return CodeModelSerialization.DeserializeCodeModel(codeModelYaml);
            });

            if (!Path.IsPathRooted(configuration.OutputFolder))
            {
                await autoRest.Warning("output-folder path should be an absolute path");
            }
            if (configuration.SaveInputs)
            {
                await codeModelTask;
                await autoRest.WriteFile("Configuration.json", StandaloneGeneratorRunner.SaveConfiguration(configuration), "source-file-csharp");
                await autoRest.WriteFile("CodeModel.yaml", codeModelYaml, "source-file-csharp");
            }

            try
            {
                var project = await ExecuteAsync(codeModelTask, configuration);
                await foreach (var file in project.GetGeneratedFilesAsync())
                {
                    await autoRest.WriteFile(file.Name, file.Text, "source-file-csharp");
                }
            }
            catch (ErrorHelpers.ErrorException e)
            {
                await autoRest.Fatal(e.ErrorText);
                return false;
            }
            catch (Exception e)
            {
                try
                {
                    if (configuration.SaveInputs)
                    {
                        // We are unsuspectingly crashing, so output anything that might help us reproduce the issue
                        File.WriteAllText(Path.Combine(configuration.OutputFolder, "Configuration.json"), StandaloneGeneratorRunner.SaveConfiguration(configuration));
                        await codeModelTask;
                        File.WriteAllText(Path.Combine(configuration.OutputFolder, "CodeModel.yaml"), codeModelYaml);
                    }
                }
                catch
                {
                    // Ignore any errors while trying to output crash information
                }
                await autoRest.Fatal($"Internal error in AutoRest.CSharp{ErrorHelpers.FileIssueText}\nException: {e.Message}\n{e.StackTrace}");
                return false;
            }

            return true;
        }
    }
}
