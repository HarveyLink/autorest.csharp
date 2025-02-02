// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System.Linq;
using System.Threading.Tasks;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.OutputLibrary
{
    internal class MgmtScopeResourceTests : OutputLibraryTestBase
    {
        public MgmtScopeResourceTests() : base("MgmtScopeResource") { }

        [TestCase("PolicyAssignment", "ArmResourceExtensions")]
        [TestCase("DeploymentExtended", "SubscriptionExtensions")]
        [TestCase("DeploymentExtended", "ResourceGroupExtensions")]
        [TestCase("DeploymentExtended", "ManagementGroupExtensions")]
        [TestCase("DeploymentExtended", "TenantExtensions")]
        [TestCase("ResourceLink", "TenantExtensions")]
        public void TestScopeResource(string resourceName, string parentName)
        {
            var resource = MgmtContext.Library.ArmResources.FirstOrDefault(r => r.Type.Name == resourceName);
            Assert.NotNull(resource);
            var parents = resource.Parent();
            Assert.IsTrue(parents.Any(p => p.Type.Name == parentName));
        }
    }
}
