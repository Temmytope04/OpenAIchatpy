// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Scale Set VM Reimage Parameters. </summary>
    public partial class VirtualMachineScaleSetReimageParameters : VirtualMachineReimageParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetReimageParameters. </summary>
        public VirtualMachineScaleSetReimageParameters()
        {
            InstanceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetReimageParameters. </summary>
        /// <param name="tempDisk"> Specifies whether to reimage temp disk. Default value: false. Note: This temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS disk. </param>
        /// <param name="instanceIds"> The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set. </param>
        internal VirtualMachineScaleSetReimageParameters(bool? tempDisk, IList<string> instanceIds) : base(tempDisk)
        {
            InstanceIds = instanceIds;
        }

        /// <summary> The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set. </summary>
        public IList<string> InstanceIds { get; }
    }
}
