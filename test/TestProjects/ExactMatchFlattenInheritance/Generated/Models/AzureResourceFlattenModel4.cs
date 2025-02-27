// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ExactMatchFlattenInheritance.Models
{
    /// <summary> This model is x-ms-azure-resource, has flatten properties, and WITHOUT enough reference type properties. </summary>
    public partial class AzureResourceFlattenModel4
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel4. </summary>
        public AzureResourceFlattenModel4()
        {
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel4. </summary>
        /// <param name="foo"> New property. </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        internal AzureResourceFlattenModel4(int? foo, string id, string name, string type)
        {
            Foo = foo;
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> New property. </summary>
        public int? Foo { get; set; }
        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
    }
}
