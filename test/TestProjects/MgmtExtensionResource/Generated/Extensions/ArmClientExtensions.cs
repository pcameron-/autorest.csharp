// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtExtensionResource
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region SubSingleton
        /// <summary> Gets an object representing a SubSingleton along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubSingleton" /> object. </returns>
        public static SubSingleton GetSubSingleton(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SubSingleton.ValidateResourceId(id);
                return new SubSingleton(client, id);
            }
            );
        }
        #endregion

        #region SubscriptionPolicyDefinition
        /// <summary> Gets an object representing a SubscriptionPolicyDefinition along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicyDefinition" /> object. </returns>
        public static SubscriptionPolicyDefinition GetSubscriptionPolicyDefinition(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SubscriptionPolicyDefinition.ValidateResourceId(id);
                return new SubscriptionPolicyDefinition(client, id);
            }
            );
        }
        #endregion

        #region BuiltInPolicyDefinition
        /// <summary> Gets an object representing a BuiltInPolicyDefinition along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BuiltInPolicyDefinition" /> object. </returns>
        public static BuiltInPolicyDefinition GetBuiltInPolicyDefinition(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                BuiltInPolicyDefinition.ValidateResourceId(id);
                return new BuiltInPolicyDefinition(client, id);
            }
            );
        }
        #endregion

        #region ManagementGroupPolicyDefinition
        /// <summary> Gets an object representing a ManagementGroupPolicyDefinition along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicyDefinition" /> object. </returns>
        public static ManagementGroupPolicyDefinition GetManagementGroupPolicyDefinition(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ManagementGroupPolicyDefinition.ValidateResourceId(id);
                return new ManagementGroupPolicyDefinition(client, id);
            }
            );
        }
        #endregion
    }
}
