// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Parameters for Reimaging Virtual Machine. NOTE: Virtual Machine OS disk will always be reimaged. </summary>
    public partial class VirtualMachineReimageParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineReimageParameters. </summary>
        public VirtualMachineReimageParameters()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineReimageParameters. </summary>
        /// <param name="tempDisk"> Specifies whether to reimage temp disk. Default value: false. Note: This temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS disk. </param>
        internal VirtualMachineReimageParameters(bool? tempDisk)
        {
            TempDisk = tempDisk;
        }

        /// <summary> Specifies whether to reimage temp disk. Default value: false. Note: This temp disk reimage parameter is only supported for VM/VMSS with Ephemeral OS disk. </summary>
        public bool? TempDisk { get; set; }
    }
}
