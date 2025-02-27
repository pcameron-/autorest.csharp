// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace OmitOperationGroups
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Model2
        /// <summary> Gets an object representing a Model2 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Model2" /> object. </returns>
        public static Model2 GetModel2(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                Model2.ValidateResourceId(id);
                return new Model2(client, id);
            }
            );
        }
        #endregion
    }
}
