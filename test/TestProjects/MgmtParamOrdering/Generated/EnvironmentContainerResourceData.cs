// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A class representing the EnvironmentContainerResource data model. </summary>
    public partial class EnvironmentContainerResourceData : TrackedResource
    {
        /// <summary> Initializes a new instance of EnvironmentContainerResourceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public EnvironmentContainerResourceData(Location location, EnvironmentContainer properties) : base(location)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of EnvironmentContainerResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal EnvironmentContainerResourceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, EnvironmentContainer properties, SystemData systemData) : base(id, name, type, tags, location)
        {
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Additional attributes of the entity. </summary>
        public EnvironmentContainer Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}