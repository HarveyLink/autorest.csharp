// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Credentials of a registered application created for your search service, used for authenticated access to the encryption keys stored in Azure Key Vault. </summary>
    public partial class AzureActiveDirectoryApplicationCredentials
    {
        /// <summary> Initializes a new instance of AzureActiveDirectoryApplicationCredentials. </summary>
        /// <param name="applicationId"> An AAD Application ID that was granted the required access permissions to the Azure Key Vault that is to be used when encrypting your data at rest. The Application ID should not be confused with the Object ID for your AAD Application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public AzureActiveDirectoryApplicationCredentials(string applicationId)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }

            ApplicationId = applicationId;
        }

        /// <summary> Initializes a new instance of AzureActiveDirectoryApplicationCredentials. </summary>
        /// <param name="applicationId"> An AAD Application ID that was granted the required access permissions to the Azure Key Vault that is to be used when encrypting your data at rest. The Application ID should not be confused with the Object ID for your AAD Application. </param>
        /// <param name="applicationSecret"> The authentication key of the specified AAD application. </param>
        internal AzureActiveDirectoryApplicationCredentials(string applicationId, string applicationSecret)
        {
            ApplicationId = applicationId;
            ApplicationSecret = applicationSecret;
        }

        /// <summary> An AAD Application ID that was granted the required access permissions to the Azure Key Vault that is to be used when encrypting your data at rest. The Application ID should not be confused with the Object ID for your AAD Application. </summary>
        public string ApplicationId { get; set; }
        /// <summary> The authentication key of the specified AAD application. </summary>
        public string ApplicationSecret { get; set; }
    }
}
