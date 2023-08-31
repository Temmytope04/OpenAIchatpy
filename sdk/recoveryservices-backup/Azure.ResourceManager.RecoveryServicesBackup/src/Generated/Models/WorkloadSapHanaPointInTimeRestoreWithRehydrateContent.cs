// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureWorkload SAP Hana-specific restore with integrated rehydration of recovery point. </summary>
    public partial class WorkloadSapHanaPointInTimeRestoreWithRehydrateContent : WorkloadSapHanaPointInTimeRestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>. </summary>
        public WorkloadSapHanaPointInTimeRestoreWithRehydrateContent()
        {
            ObjectType = "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        /// <param name="pointInTime"> PointInTime value. </param>
        /// <param name="recoveryPointRehydrationInfo"> RP Rehydration Info. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadSapHanaPointInTimeRestoreWithRehydrateContent(string objectType, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, ResourceIdentifier targetVirtualMachineId, DateTimeOffset? pointInTime, RecoveryPointRehydrationInfo recoveryPointRehydrationInfo, Dictionary<string, BinaryData> rawData) : base(objectType, recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, targetVirtualMachineId, pointInTime, rawData)
        {
            RecoveryPointRehydrationInfo = recoveryPointRehydrationInfo;
            ObjectType = objectType ?? "AzureWorkloadSAPHanaPointInTimeRestoreWithRehydrateRequest";
        }

        /// <summary> RP Rehydration Info. </summary>
        public RecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get; set; }
    }
}
