// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure Storage-specific protectable containers. </summary>
    public partial class StorageProtectableContainer : ProtectableContainer
    {
        /// <summary> Initializes a new instance of StorageProtectableContainer. </summary>
        public StorageProtectableContainer()
        {
            ProtectableContainerType = ProtectableContainerType.StorageContainer;
        }

        /// <summary> Initializes a new instance of StorageProtectableContainer. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="protectableContainerType">
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerId"> Fabric Id of the container such as ARM Id. </param>
        internal StorageProtectableContainer(string friendlyName, BackupManagementType? backupManagementType, ProtectableContainerType protectableContainerType, string healthStatus, string containerId) : base(friendlyName, backupManagementType, protectableContainerType, healthStatus, containerId)
        {
            ProtectableContainerType = protectableContainerType;
        }
    }
}
