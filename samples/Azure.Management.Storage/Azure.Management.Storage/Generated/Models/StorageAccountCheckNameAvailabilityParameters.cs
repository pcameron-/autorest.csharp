// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> The parameters used to check the availability of the storage account name. </summary>
    public partial class StorageAccountCheckNameAvailabilityParameters
    {
        /// <summary> Initializes a new instance of StorageAccountCheckNameAvailabilityParameters. </summary>
        /// <param name="name"> The storage account name. </param>
        public StorageAccountCheckNameAvailabilityParameters(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Type = "Microsoft.Storage/storageAccounts";
        }

        /// <summary> Initializes a new instance of StorageAccountCheckNameAvailabilityParameters. </summary>
        /// <param name="name"> The storage account name. </param>
        /// <param name="type"> The type of resource, Microsoft.Storage/storageAccounts. </param>
        internal StorageAccountCheckNameAvailabilityParameters(string name, string type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> The storage account name. </summary>
        public string Name { get; set; }
        /// <summary> The type of resource, Microsoft.Storage/storageAccounts. </summary>
        public string Type { get; set; }
    }
}
