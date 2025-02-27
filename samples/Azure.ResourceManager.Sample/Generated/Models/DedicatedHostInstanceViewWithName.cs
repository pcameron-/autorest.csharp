// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The instance view of a dedicated host that includes the name of the dedicated host. It is used for the response to the instance view of a dedicated host group. </summary>
    public partial class DedicatedHostInstanceViewWithName : DedicatedHostInstanceView
    {
        /// <summary> Initializes a new instance of DedicatedHostInstanceViewWithName. </summary>
        internal DedicatedHostInstanceViewWithName()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostInstanceViewWithName. </summary>
        /// <param name="assetId"> Specifies the unique id of the dedicated physical machine on which the dedicated host resides. </param>
        /// <param name="availableCapacity"> Unutilized capacity of the dedicated host. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="name"> The name of the dedicated host. </param>
        internal DedicatedHostInstanceViewWithName(string assetId, DedicatedHostAvailableCapacity availableCapacity, IReadOnlyList<InstanceViewStatus> statuses, string name) : base(assetId, availableCapacity, statuses)
        {
            Name = name;
        }

        /// <summary> The name of the dedicated host. </summary>
        public string Name { get; }
    }
}
