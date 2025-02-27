// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtOperations
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySet" /> object. </returns>
        public static AvailabilitySet GetAvailabilitySet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AvailabilitySet.ValidateResourceId(id);
                return new AvailabilitySet(client, id);
            }
            );
        }
        #endregion

        #region AvailabilitySetChild
        /// <summary> Gets an object representing a AvailabilitySetChild along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetChild" /> object. </returns>
        public static AvailabilitySetChild GetAvailabilitySetChild(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AvailabilitySetChild.ValidateResourceId(id);
                return new AvailabilitySetChild(client, id);
            }
            );
        }
        #endregion

        #region AvailabilitySetGrandChild
        /// <summary> Gets an object representing a AvailabilitySetGrandChild along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetGrandChild" /> object. </returns>
        public static AvailabilitySetGrandChild GetAvailabilitySetGrandChild(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AvailabilitySetGrandChild.ValidateResourceId(id);
                return new AvailabilitySetGrandChild(client, id);
            }
            );
        }
        #endregion
    }
}
