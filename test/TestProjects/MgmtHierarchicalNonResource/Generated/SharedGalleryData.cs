// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using MgmtHierarchicalNonResource.Models;

namespace MgmtHierarchicalNonResource
{
    /// <summary> A class representing the SharedGallery data model. </summary>
    public partial class SharedGalleryData : PirSharedGalleryResource
    {
        /// <summary> Initializes a new instance of SharedGalleryData. </summary>
        internal SharedGalleryData()
        {
        }

        /// <summary> Initializes a new instance of SharedGalleryData. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        internal SharedGalleryData(string name, string location, string uniqueId) : base(name, location, uniqueId)
        {
        }

        /// <summary> The resource identifier. </summary>
        public ResourceIdentifier Id { get; internal set; }
    }
}
