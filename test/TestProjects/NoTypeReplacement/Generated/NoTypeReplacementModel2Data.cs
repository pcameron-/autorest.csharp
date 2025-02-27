// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using NoTypeReplacement.Models;

namespace NoTypeReplacement
{
    /// <summary> A class representing the NoTypeReplacementModel2 data model. </summary>
    public partial class NoTypeReplacementModel2Data : ResourceData
    {
        /// <summary> Initializes a new instance of NoTypeReplacementModel2Data. </summary>
        public NoTypeReplacementModel2Data()
        {
        }

        /// <summary> Initializes a new instance of NoTypeReplacementModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"></param>
        internal NoTypeReplacementModel2Data(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, NoSubResourceModel foo) : base(id, name, type, systemData)
        {
            Foo = foo;
        }

        /// <summary> Gets or sets the foo. </summary>
        public NoSubResourceModel Foo { get; set; }
    }
}
