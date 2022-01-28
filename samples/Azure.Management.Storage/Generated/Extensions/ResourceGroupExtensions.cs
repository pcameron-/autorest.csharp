// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region StorageAccount
        /// <summary> Gets an object representing a StorageAccountCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="StorageAccountCollection" /> object. </returns>
        public static StorageAccountCollection GetStorageAccounts(this ResourceGroup resourceGroup)
        {
            return new StorageAccountCollection(resourceGroup);
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
