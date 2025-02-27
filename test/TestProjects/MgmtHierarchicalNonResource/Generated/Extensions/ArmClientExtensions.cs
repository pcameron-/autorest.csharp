// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtHierarchicalNonResource
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region SharedGallery
        /// <summary> Gets an object representing a SharedGallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGallery" /> object. </returns>
        public static SharedGallery GetSharedGallery(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SharedGallery.ValidateResourceId(id);
                return new SharedGallery(client, id);
            }
            );
        }
        #endregion
    }
}
