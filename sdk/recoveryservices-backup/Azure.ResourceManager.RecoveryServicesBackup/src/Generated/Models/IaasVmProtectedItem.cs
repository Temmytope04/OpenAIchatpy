// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// IaaS VM workload-specific backup item.
    /// Please note <see cref="IaasVmProtectedItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="IaasClassicComputeVmProtectedItem"/> and <see cref="IaasComputeVmProtectedItem"/>.
    /// </summary>
    public partial class IaasVmProtectedItem : BackupGenericProtectedItem
    {
        /// <summary> Initializes a new instance of <see cref="IaasVmProtectedItem"/>. </summary>
        public IaasVmProtectedItem()
        {
            HealthDetails = new ChangeTrackingList<IaasVmHealthDetails>();
            KpisHealths = new ChangeTrackingDictionary<string, KpiResourceHealthDetails>();
            ProtectedItemType = "AzureIaaSVMProtectedItem";
        }

        /// <summary> Initializes a new instance of <see cref="IaasVmProtectedItem"/>. </summary>
        /// <param name="protectedItemType"> backup item type. </param>
        /// <param name="backupManagementType"> Type of backup management for the backed up item. </param>
        /// <param name="workloadType"> Type of workload this item represents. </param>
        /// <param name="containerName"> Unique name of container. </param>
        /// <param name="sourceResourceId"> ARM ID of the resource to be backed up. </param>
        /// <param name="policyId"> ID of the backup policy with which this item is backed up. </param>
        /// <param name="lastRecoverOn"> Timestamp when the last (latest) backup copy was created for this backup item. </param>
        /// <param name="backupSetName"> Name of the backup set the backup item belongs to. </param>
        /// <param name="createMode"> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </param>
        /// <param name="deferredDeletedOn"> Time for deferred deletion in UTC. </param>
        /// <param name="isScheduledForDeferredDelete"> Flag to identify whether the DS is scheduled for deferred delete. </param>
        /// <param name="deferredDeleteTimeRemaining"> Time remaining before the DS marked for deferred delete is permanently deleted. </param>
        /// <param name="isDeferredDeleteScheduleUpcoming"> Flag to identify whether the deferred deleted DS is to be purged soon. </param>
        /// <param name="isRehydrate"> Flag to identify that deferred deleted DS is to be moved into Pause state. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="isArchiveEnabled"> Flag to identify whether datasource is protected in archive. </param>
        /// <param name="policyName"> Name of the policy used for protection. </param>
        /// <param name="softDeleteRetentionPeriod"> Soft delete retention period in days. </param>
        /// <param name="friendlyName"> Friendly name of the VM represented by this backup item. </param>
        /// <param name="virtualMachineId"> Fully qualified ARM ID of the virtual machine represented by this item. </param>
        /// <param name="protectionStatus"> Backup status of this backup item. </param>
        /// <param name="protectionState"> Backup state of this backup item. </param>
        /// <param name="healthStatus"> Health status of protected item. </param>
        /// <param name="healthDetails"> Health details on this backup item. </param>
        /// <param name="kpisHealths"> Health details of different KPIs. </param>
        /// <param name="lastBackupStatus"> Last backup operation status. </param>
        /// <param name="lastBackupOn"> Timestamp of the last backup operation on this backup item. </param>
        /// <param name="protectedItemDataId"> Data ID of the protected item. </param>
        /// <param name="extendedInfo"> Additional information for this backup item. </param>
        /// <param name="extendedProperties"> Extended Properties for Azure IaasVM Backup. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IaasVmProtectedItem(string protectedItemType, BackupManagementType? backupManagementType, BackupDataSourceType? workloadType, string containerName, ResourceIdentifier sourceResourceId, ResourceIdentifier policyId, DateTimeOffset? lastRecoverOn, string backupSetName, BackupCreateMode? createMode, DateTimeOffset? deferredDeletedOn, bool? isScheduledForDeferredDelete, string deferredDeleteTimeRemaining, bool? isDeferredDeleteScheduleUpcoming, bool? isRehydrate, IList<string> resourceGuardOperationRequests, bool? isArchiveEnabled, string policyName, int? softDeleteRetentionPeriod, string friendlyName, ResourceIdentifier virtualMachineId, string protectionStatus, BackupProtectionState? protectionState, IaasVmProtectedItemHealthStatus? healthStatus, IList<IaasVmHealthDetails> healthDetails, IDictionary<string, KpiResourceHealthDetails> kpisHealths, string lastBackupStatus, DateTimeOffset? lastBackupOn, string protectedItemDataId, IaasVmProtectedItemExtendedInfo extendedInfo, IaasVmBackupExtendedProperties extendedProperties, Dictionary<string, BinaryData> rawData) : base(protectedItemType, backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoverOn, backupSetName, createMode, deferredDeletedOn, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, resourceGuardOperationRequests, isArchiveEnabled, policyName, softDeleteRetentionPeriod, rawData)
        {
            FriendlyName = friendlyName;
            VirtualMachineId = virtualMachineId;
            ProtectionStatus = protectionStatus;
            ProtectionState = protectionState;
            HealthStatus = healthStatus;
            HealthDetails = healthDetails;
            KpisHealths = kpisHealths;
            LastBackupStatus = lastBackupStatus;
            LastBackupOn = lastBackupOn;
            ProtectedItemDataId = protectedItemDataId;
            ExtendedInfo = extendedInfo;
            ExtendedProperties = extendedProperties;
            ProtectedItemType = protectedItemType ?? "AzureIaaSVMProtectedItem";
        }

        /// <summary> Friendly name of the VM represented by this backup item. </summary>
        public string FriendlyName { get; }
        /// <summary> Fully qualified ARM ID of the virtual machine represented by this item. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Backup status of this backup item. </summary>
        public string ProtectionStatus { get; set; }
        /// <summary> Backup state of this backup item. </summary>
        public BackupProtectionState? ProtectionState { get; set; }
        /// <summary> Health status of protected item. </summary>
        public IaasVmProtectedItemHealthStatus? HealthStatus { get; }
        /// <summary> Health details on this backup item. </summary>
        public IList<IaasVmHealthDetails> HealthDetails { get; }
        /// <summary> Health details of different KPIs. </summary>
        public IDictionary<string, KpiResourceHealthDetails> KpisHealths { get; }
        /// <summary> Last backup operation status. </summary>
        public string LastBackupStatus { get; set; }
        /// <summary> Timestamp of the last backup operation on this backup item. </summary>
        public DateTimeOffset? LastBackupOn { get; }
        /// <summary> Data ID of the protected item. </summary>
        public string ProtectedItemDataId { get; }
        /// <summary> Additional information for this backup item. </summary>
        public IaasVmProtectedItemExtendedInfo ExtendedInfo { get; set; }
        /// <summary> Extended Properties for Azure IaasVM Backup. </summary>
        public IaasVmBackupExtendedProperties ExtendedProperties { get; set; }
    }
}
