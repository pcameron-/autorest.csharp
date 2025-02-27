// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace SingletonResource
{
    /// <summary> A class representing the ParentResource data model. </summary>
    public partial class ParentResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ParentResourceData. </summary>
        /// <param name="location"> The location. </param>
        public ParentResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ParentResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"></param>
        internal ParentResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string @new) : base(id, name, type, systemData, tags, location)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
