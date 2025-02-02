// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtExtensionCommonRestOperation
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region TypeOne
        /// <summary> Gets an object representing a TypeOne along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TypeOne" /> object. </returns>
        public static TypeOne GetTypeOne(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                TypeOne.ValidateResourceId(id);
                return new TypeOne(client, id);
            }
            );
        }
        #endregion

        #region TypeTwo
        /// <summary> Gets an object representing a TypeTwo along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TypeTwo" /> object. </returns>
        public static TypeTwo GetTypeTwo(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                TypeTwo.ValidateResourceId(id);
                return new TypeTwo(client, id);
            }
            );
        }
        #endregion
    }
}
