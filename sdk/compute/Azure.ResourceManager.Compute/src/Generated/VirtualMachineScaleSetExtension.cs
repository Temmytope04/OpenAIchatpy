// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a VirtualMachineScaleSetExtension along with the instance operations that can be performed on it. </summary>
    public class VirtualMachineScaleSetExtension : VirtualMachineScaleSetExtensionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineScaleSetExtension"/> class for mocking. </summary>
        protected VirtualMachineScaleSetExtension() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineScaleSetExtension"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualMachineScaleSetExtension(OperationsBase options, VirtualMachineScaleSetExtensionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VirtualMachineScaleSetExtensionData. </summary>
        public virtual VirtualMachineScaleSetExtensionData Data { get; private set; }
    }
}
