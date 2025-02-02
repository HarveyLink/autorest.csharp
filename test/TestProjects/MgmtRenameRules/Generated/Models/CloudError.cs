// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> An error response from the Compute service. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"> Api error. </param>
        internal CloudError(ApiError error)
        {
            Error = error;
        }

        /// <summary> Api error. </summary>
        public ApiError Error { get; }
    }
}
