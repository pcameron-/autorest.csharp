// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeploymentExtendeds in the DeploymentExtended. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeploymentExtendeds and their operations over a DeploymentExtended. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDeploymentExtendeds();
        }
    }
}
