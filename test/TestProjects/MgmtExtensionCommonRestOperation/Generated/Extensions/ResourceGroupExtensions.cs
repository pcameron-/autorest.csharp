// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtExtensionCommonRestOperation
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region TypeOne
        /// <summary> Gets an object representing a TypeOneCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="TypeOneCollection" /> object. </returns>
        public static TypeOneCollection GetTypeOnes(this ResourceGroup resourceGroup)
        {
            return new TypeOneCollection(resourceGroup);
        }
        #endregion

        #region TypeTwo
        /// <summary> Gets an object representing a TypeTwoCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="TypeTwoCollection" /> object. </returns>
        public static TypeTwoCollection GetTypeTwos(this ResourceGroup resourceGroup)
        {
            return new TypeTwoCollection(resourceGroup);
        }
        #endregion

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((armClient) =>
            {
                return new ResourceGroupExtensionClient(armClient, resourceGroup.Id);
            }
            );
        }
    }
}
