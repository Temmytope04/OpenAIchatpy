// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A enable protection input. </summary>
    public partial class A2AEnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="A2AEnableProtectionContent"/>. </summary>
        /// <param name="fabricObjectId"> The fabric specific object Id of the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricObjectId"/> is null. </exception>
        public A2AEnableProtectionContent(ResourceIdentifier fabricObjectId)
        {
            Argument.AssertNotNull(fabricObjectId, nameof(fabricObjectId));

            FabricObjectId = fabricObjectId;
            VmDisks = new ChangeTrackingList<A2AVmDiskDetails>();
            VmManagedDisks = new ChangeTrackingList<A2AVmManagedDiskDetails>();
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2AEnableProtectionContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="fabricObjectId"> The fabric specific object Id of the virtual machine. </param>
        /// <param name="recoveryContainerId"> The recovery container Id. </param>
        /// <param name="recoveryResourceGroupId"> The recovery resource group Id. Valid for V2 scenarios. </param>
        /// <param name="recoveryCloudServiceId"> The recovery cloud service Id. Valid for V1 scenarios. </param>
        /// <param name="recoveryAvailabilitySetId"> The recovery availability set Id. </param>
        /// <param name="recoveryProximityPlacementGroupId"> The recovery proximity placement group Id. </param>
        /// <param name="vmDisks"> The list of vm disk details. </param>
        /// <param name="vmManagedDisks"> The list of vm managed disk details. </param>
        /// <param name="multiVmGroupName"> The multi vm group name. </param>
        /// <param name="multiVmGroupId"> The multi vm group id. </param>
        /// <param name="recoveryBootDiagStorageAccountId"> The boot diagnostic storage account. </param>
        /// <param name="diskEncryptionInfo"> The recovery disk encryption information (for two pass flows). </param>
        /// <param name="recoveryAvailabilityZone"> The recovery availability zone. </param>
        /// <param name="recoveryExtendedLocation"> The recovery extended location. </param>
        /// <param name="recoveryAzureNetworkId"> The recovery Azure virtual network ARM id. </param>
        /// <param name="recoverySubnetName"> The recovery subnet name. </param>
        /// <param name="recoveryVirtualMachineScaleSetId"> The virtual machine scale set Id. </param>
        /// <param name="recoveryCapacityReservationGroupId"> The recovery capacity reservation group Id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal A2AEnableProtectionContent(string instanceType, ResourceIdentifier fabricObjectId, ResourceIdentifier recoveryContainerId, ResourceIdentifier recoveryResourceGroupId, string recoveryCloudServiceId, ResourceIdentifier recoveryAvailabilitySetId, ResourceIdentifier recoveryProximityPlacementGroupId, IList<A2AVmDiskDetails> vmDisks, IList<A2AVmManagedDiskDetails> vmManagedDisks, string multiVmGroupName, string multiVmGroupId, ResourceIdentifier recoveryBootDiagStorageAccountId, SiteRecoveryDiskEncryptionInfo diskEncryptionInfo, string recoveryAvailabilityZone, SiteRecoveryExtendedLocation recoveryExtendedLocation, ResourceIdentifier recoveryAzureNetworkId, string recoverySubnetName, ResourceIdentifier recoveryVirtualMachineScaleSetId, ResourceIdentifier recoveryCapacityReservationGroupId, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            FabricObjectId = fabricObjectId;
            RecoveryContainerId = recoveryContainerId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            RecoveryCloudServiceId = recoveryCloudServiceId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            VmDisks = vmDisks;
            VmManagedDisks = vmManagedDisks;
            MultiVmGroupName = multiVmGroupName;
            MultiVmGroupId = multiVmGroupId;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            DiskEncryptionInfo = diskEncryptionInfo;
            RecoveryAvailabilityZone = recoveryAvailabilityZone;
            RecoveryExtendedLocation = recoveryExtendedLocation;
            RecoveryAzureNetworkId = recoveryAzureNetworkId;
            RecoverySubnetName = recoverySubnetName;
            RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2AEnableProtectionContent"/> for deserialization. </summary>
        internal A2AEnableProtectionContent()
        {
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> The recovery container Id. </summary>
        public ResourceIdentifier RecoveryContainerId { get; set; }
        /// <summary> The recovery resource group Id. Valid for V2 scenarios. </summary>
        public ResourceIdentifier RecoveryResourceGroupId { get; set; }
        /// <summary> The recovery cloud service Id. Valid for V1 scenarios. </summary>
        public string RecoveryCloudServiceId { get; set; }
        /// <summary> The recovery availability set Id. </summary>
        public ResourceIdentifier RecoveryAvailabilitySetId { get; set; }
        /// <summary> The recovery proximity placement group Id. </summary>
        public ResourceIdentifier RecoveryProximityPlacementGroupId { get; set; }
        /// <summary> The list of vm disk details. </summary>
        public IList<A2AVmDiskDetails> VmDisks { get; }
        /// <summary> The list of vm managed disk details. </summary>
        public IList<A2AVmManagedDiskDetails> VmManagedDisks { get; }
        /// <summary> The multi vm group name. </summary>
        public string MultiVmGroupName { get; set; }
        /// <summary> The multi vm group id. </summary>
        public string MultiVmGroupId { get; set; }
        /// <summary> The boot diagnostic storage account. </summary>
        public ResourceIdentifier RecoveryBootDiagStorageAccountId { get; set; }
        /// <summary> The recovery disk encryption information (for two pass flows). </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary> The recovery availability zone. </summary>
        public string RecoveryAvailabilityZone { get; set; }
        /// <summary> The recovery extended location. </summary>
        public SiteRecoveryExtendedLocation RecoveryExtendedLocation { get; set; }
        /// <summary> The recovery Azure virtual network ARM id. </summary>
        public ResourceIdentifier RecoveryAzureNetworkId { get; set; }
        /// <summary> The recovery subnet name. </summary>
        public string RecoverySubnetName { get; set; }
        /// <summary> The virtual machine scale set Id. </summary>
        public ResourceIdentifier RecoveryVirtualMachineScaleSetId { get; set; }
        /// <summary> The recovery capacity reservation group Id. </summary>
        public ResourceIdentifier RecoveryCapacityReservationGroupId { get; set; }
    }
}
