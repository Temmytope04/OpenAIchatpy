// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMage Azure V2 input to update replication protected item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AUpdateReplicationProtectedItemInput : UpdateReplicationProtectedItemProviderInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// A2AUpdateReplicationProtectedItemInput class.
        /// </summary>
        public A2AUpdateReplicationProtectedItemInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// A2AUpdateReplicationProtectedItemInput class.
        /// </summary>
        /// <param name="recoveryCloudServiceId">The target cloud service ARM
        /// Id (for V1).</param>
        /// <param name="recoveryResourceGroupId">The target resource group ARM
        /// Id (for V2).</param>
        /// <param name="managedDiskUpdateDetails">Managed disk update
        /// details.</param>
        /// <param name="recoveryBootDiagStorageAccountId">The boot diagnostic
        /// storage account.</param>
        /// <param name="diskEncryptionInfo">The recovery os disk encryption
        /// information.</param>
        /// <param name="tfoAzureVMName">The user given name for Test Failover
        /// VM.</param>
        /// <param name="recoveryProximityPlacementGroupId">The recovery
        /// proximity placement group Id.</param>
        /// <param name="recoveryVirtualMachineScaleSetId">The recovery virtual
        /// machine scale set Id.</param>
        /// <param name="recoveryCapacityReservationGroupId">The recovery
        /// capacity reservation group Id.</param>
        public A2AUpdateReplicationProtectedItemInput(string recoveryCloudServiceId = default(string), string recoveryResourceGroupId = default(string), IList<A2AVmManagedDiskUpdateDetails> managedDiskUpdateDetails = default(IList<A2AVmManagedDiskUpdateDetails>), string recoveryBootDiagStorageAccountId = default(string), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo), string tfoAzureVMName = default(string), string recoveryProximityPlacementGroupId = default(string), string recoveryVirtualMachineScaleSetId = default(string), string recoveryCapacityReservationGroupId = default(string))
        {
            RecoveryCloudServiceId = recoveryCloudServiceId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            ManagedDiskUpdateDetails = managedDiskUpdateDetails;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            DiskEncryptionInfo = diskEncryptionInfo;
            TfoAzureVMName = tfoAzureVMName;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target cloud service ARM Id (for V1).
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCloudServiceId")]
        public string RecoveryCloudServiceId { get; set; }

        /// <summary>
        /// Gets or sets the target resource group ARM Id (for V2).
        /// </summary>
        [JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets managed disk update details.
        /// </summary>
        [JsonProperty(PropertyName = "managedDiskUpdateDetails")]
        public IList<A2AVmManagedDiskUpdateDetails> ManagedDiskUpdateDetails { get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostic storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryBootDiagStorageAccountId")]
        public string RecoveryBootDiagStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the recovery os disk encryption information.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo { get; set; }

        /// <summary>
        /// Gets or sets the user given name for Test Failover VM.
        /// </summary>
        [JsonProperty(PropertyName = "tfoAzureVMName")]
        public string TfoAzureVMName { get; set; }

        /// <summary>
        /// Gets or sets the recovery proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProximityPlacementGroupId")]
        public string RecoveryProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery virtual machine scale set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVirtualMachineScaleSetId")]
        public string RecoveryVirtualMachineScaleSetId { get; set; }

        /// <summary>
        /// Gets or sets the recovery capacity reservation group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCapacityReservationGroupId")]
        public string RecoveryCapacityReservationGroupId { get; set; }

    }
}
