// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtLRO
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Fake
        /// <summary> Gets an object representing a FakeContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="FakeContainer" /> object. </returns>
        public static FakeContainer GetFakes(this ResourceGroupOperations resourceGroup)
        {
            return new FakeContainer(resourceGroup);
        }
        #endregion

        #region Bar
        /// <summary> Gets an object representing a BarContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="BarContainer" /> object. </returns>
        public static BarContainer GetBars(this ResourceGroupOperations resourceGroup)
        {
            return new BarContainer(resourceGroup);
        }
        #endregion
    }
}