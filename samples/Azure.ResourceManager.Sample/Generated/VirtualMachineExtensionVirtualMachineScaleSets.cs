// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A Class representing a VirtualMachineExtensionVirtualMachineScaleSets along with the instance operations that can be performed on it. </summary>
    public class VirtualMachineExtensionVirtualMachineScaleSets : VirtualMachineExtensionVirtualMachineScaleSetsOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineExtensionVirtualMachineScaleSets"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualMachineExtensionVirtualMachineScaleSets(ResourceOperationsBase options, VirtualMachineExtensionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VirtualMachineExtensionData. </summary>
        public VirtualMachineExtensionData Data { get; private set; }

        /// <inheritdoc />
        protected override VirtualMachineExtensionVirtualMachineScaleSets GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<VirtualMachineExtensionVirtualMachineScaleSets> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}