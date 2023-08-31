// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// IaaS VM workload-specific restore.
    /// Please note <see cref="IaasVmRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="IaasVmRestoreWithRehydrationContent"/>.
    /// </summary>
    public partial class IaasVmRestoreContent : RestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="IaasVmRestoreContent"/>. </summary>
        public IaasVmRestoreContent()
        {
            RestoreDiskLunList = new ChangeTrackingList<int>();
            Zones = new ChangeTrackingList<string>();
            ObjectType = "IaasVMRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="IaasVmRestoreContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryPointId"> ID of the backup copy to be recovered. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM which is being recovered. </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the VM that will be created.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        /// <param name="targetResourceGroupId">
        /// This is the ARM Id of the resource group that you want to create for this Virtual machine and other artifacts.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}
        /// </param>
        /// <param name="storageAccountId"> Fully qualified ARM ID of the storage account to which the VM has to be restored. </param>
        /// <param name="virtualNetworkId">
        /// This is the virtual network Id of the vnet that will be attached to the virtual machine.
        /// User will be validated for join action permissions in the linked access.
        /// </param>
        /// <param name="subnetId">
        /// Subnet ID, is the subnet ID associated with the to be restored VM. For Classic VMs it would be
        /// {VnetID}/Subnet/{SubnetName} and, for the Azure Resource Manager VMs it would be ARM resource ID used to represent
        /// the subnet.
        /// </param>
        /// <param name="targetDomainNameId">
        /// Fully qualified ARM ID of the domain name to be associated to the VM being restored. This applies only to Classic
        /// Virtual Machines.
        /// </param>
        /// <param name="region"> Region in which the virtual machine is restored. </param>
        /// <param name="affinityGroup"> Affinity group associated to VM to be restored. Used only for Classic Compute Virtual Machines. </param>
        /// <param name="doesCreateNewCloudService">
        /// Should a new cloud service be created while restoring the VM. If this is false, VM will be restored to the same
        /// cloud service as it was at the time of backup.
        /// </param>
        /// <param name="originalStorageAccountOption"> Original Storage Account Option. </param>
        /// <param name="encryptionDetails"> Details needed if the VM was encrypted at the time of backup. </param>
        /// <param name="restoreDiskLunList"> List of Disk LUNs for partial restore. </param>
        /// <param name="doesRestoreWithManagedDisks"> Flag to denote of an Unmanaged disk VM should be restored with Managed disks. </param>
        /// <param name="diskEncryptionSetId"> DiskEncryptionSet's ID - needed if the VM needs to be encrypted at rest during restore with customer managed key. </param>
        /// <param name="zones"> Target zone where the VM and its disks should be restored. </param>
        /// <param name="identityInfo"> Managed Identity information required to access customer storage account. </param>
        /// <param name="identityBasedRestoreDetails"> IaaS VM workload specific restore details for restores using managed identity. </param>
        /// <param name="extendedLocation">
        /// Target extended location where the VM should be restored,
        /// should be null if restore is to be done in public cloud
        /// </param>
        /// <param name="securedVmDetails"> Stores Secured VM Details. </param>
        /// <param name="targetDiskNetworkAccessSettings"> Specifies target network access settings for disks of VM to be restored,. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IaasVmRestoreContent(string objectType, string recoveryPointId, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, ResourceIdentifier targetVirtualMachineId, ResourceIdentifier targetResourceGroupId, ResourceIdentifier storageAccountId, ResourceIdentifier virtualNetworkId, ResourceIdentifier subnetId, ResourceIdentifier targetDomainNameId, AzureLocation? region, string affinityGroup, bool? doesCreateNewCloudService, bool? originalStorageAccountOption, VmEncryptionDetails encryptionDetails, IList<int> restoreDiskLunList, bool? doesRestoreWithManagedDisks, string diskEncryptionSetId, IList<string> zones, BackupIdentityInfo identityInfo, IdentityBasedRestoreDetails identityBasedRestoreDetails, ExtendedLocation extendedLocation, SecuredVmDetails securedVmDetails, BackupTargetDiskNetworkAccessSettings targetDiskNetworkAccessSettings, Dictionary<string, BinaryData> rawData) : base(objectType, rawData)
        {
            RecoveryPointId = recoveryPointId;
            RecoveryType = recoveryType;
            SourceResourceId = sourceResourceId;
            TargetVirtualMachineId = targetVirtualMachineId;
            TargetResourceGroupId = targetResourceGroupId;
            StorageAccountId = storageAccountId;
            VirtualNetworkId = virtualNetworkId;
            SubnetId = subnetId;
            TargetDomainNameId = targetDomainNameId;
            Region = region;
            AffinityGroup = affinityGroup;
            DoesCreateNewCloudService = doesCreateNewCloudService;
            OriginalStorageAccountOption = originalStorageAccountOption;
            EncryptionDetails = encryptionDetails;
            RestoreDiskLunList = restoreDiskLunList;
            DoesRestoreWithManagedDisks = doesRestoreWithManagedDisks;
            DiskEncryptionSetId = diskEncryptionSetId;
            Zones = zones;
            IdentityInfo = identityInfo;
            IdentityBasedRestoreDetails = identityBasedRestoreDetails;
            ExtendedLocation = extendedLocation;
            SecuredVmDetails = securedVmDetails;
            TargetDiskNetworkAccessSettings = targetDiskNetworkAccessSettings;
            ObjectType = objectType ?? "IaasVMRestoreRequest";
        }

        /// <summary> ID of the backup copy to be recovered. </summary>
        public string RecoveryPointId { get; set; }
        /// <summary> Type of this recovery. </summary>
        public FileShareRecoveryType? RecoveryType { get; set; }
        /// <summary> Fully qualified ARM ID of the VM which is being recovered. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary>
        /// This is the complete ARM Id of the VM that will be created.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        public ResourceIdentifier TargetVirtualMachineId { get; set; }
        /// <summary>
        /// This is the ARM Id of the resource group that you want to create for this Virtual machine and other artifacts.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}
        /// </summary>
        public ResourceIdentifier TargetResourceGroupId { get; set; }
        /// <summary> Fully qualified ARM ID of the storage account to which the VM has to be restored. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary>
        /// This is the virtual network Id of the vnet that will be attached to the virtual machine.
        /// User will be validated for join action permissions in the linked access.
        /// </summary>
        public ResourceIdentifier VirtualNetworkId { get; set; }
        /// <summary>
        /// Subnet ID, is the subnet ID associated with the to be restored VM. For Classic VMs it would be
        /// {VnetID}/Subnet/{SubnetName} and, for the Azure Resource Manager VMs it would be ARM resource ID used to represent
        /// the subnet.
        /// </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary>
        /// Fully qualified ARM ID of the domain name to be associated to the VM being restored. This applies only to Classic
        /// Virtual Machines.
        /// </summary>
        public ResourceIdentifier TargetDomainNameId { get; set; }
        /// <summary> Region in which the virtual machine is restored. </summary>
        public AzureLocation? Region { get; set; }
        /// <summary> Affinity group associated to VM to be restored. Used only for Classic Compute Virtual Machines. </summary>
        public string AffinityGroup { get; set; }
        /// <summary>
        /// Should a new cloud service be created while restoring the VM. If this is false, VM will be restored to the same
        /// cloud service as it was at the time of backup.
        /// </summary>
        public bool? DoesCreateNewCloudService { get; set; }
        /// <summary> Original Storage Account Option. </summary>
        public bool? OriginalStorageAccountOption { get; set; }
        /// <summary> Details needed if the VM was encrypted at the time of backup. </summary>
        public VmEncryptionDetails EncryptionDetails { get; set; }
        /// <summary> List of Disk LUNs for partial restore. </summary>
        public IList<int> RestoreDiskLunList { get; }
        /// <summary> Flag to denote of an Unmanaged disk VM should be restored with Managed disks. </summary>
        public bool? DoesRestoreWithManagedDisks { get; set; }
        /// <summary> DiskEncryptionSet's ID - needed if the VM needs to be encrypted at rest during restore with customer managed key. </summary>
        public string DiskEncryptionSetId { get; set; }
        /// <summary> Target zone where the VM and its disks should be restored. </summary>
        public IList<string> Zones { get; }
        /// <summary> Managed Identity information required to access customer storage account. </summary>
        public BackupIdentityInfo IdentityInfo { get; set; }
        /// <summary> IaaS VM workload specific restore details for restores using managed identity. </summary>
        public IdentityBasedRestoreDetails IdentityBasedRestoreDetails { get; set; }
        /// <summary>
        /// Target extended location where the VM should be restored,
        /// should be null if restore is to be done in public cloud
        /// </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Stores Secured VM Details. </summary>
        internal SecuredVmDetails SecuredVmDetails { get; set; }
        /// <summary> Gets or Sets Disk Encryption Set Id for Secured VM OS Disk. </summary>
        public ResourceIdentifier SecuredVmOSDiskEncryptionSetId
        {
            get => SecuredVmDetails is null ? default : SecuredVmDetails.SecuredVmOSDiskEncryptionSetId;
            set
            {
                if (SecuredVmDetails is null)
                    SecuredVmDetails = new SecuredVmDetails();
                SecuredVmDetails.SecuredVmOSDiskEncryptionSetId = value;
            }
        }

        /// <summary> Specifies target network access settings for disks of VM to be restored,. </summary>
        public BackupTargetDiskNetworkAccessSettings TargetDiskNetworkAccessSettings { get; set; }
    }
}
