// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM (Mercury) workload-specific backup policy. </summary>
    public partial class VmWorkloadProtectionPolicy : BackupGenericProtectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="VmWorkloadProtectionPolicy"/>. </summary>
        public VmWorkloadProtectionPolicy()
        {
            SubProtectionPolicy = new ChangeTrackingList<SubProtectionPolicy>();
            BackupManagementType = "AzureWorkload";
        }

        /// <summary> Initializes a new instance of <see cref="VmWorkloadProtectionPolicy"/>. </summary>
        /// <param name="protectedItemsCount"> Number of items associated with this policy. </param>
        /// <param name="backupManagementType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="workLoadType"> Type of workload for the backup management. </param>
        /// <param name="settings"> Common settings for the backup management. </param>
        /// <param name="subProtectionPolicy"> List of sub-protection policies which includes schedule and retention. </param>
        /// <param name="doesMakePolicyConsistent"> Fix the policy inconsistency. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VmWorkloadProtectionPolicy(int? protectedItemsCount, string backupManagementType, IList<string> resourceGuardOperationRequests, BackupWorkloadType? workLoadType, BackupCommonSettings settings, IList<SubProtectionPolicy> subProtectionPolicy, bool? doesMakePolicyConsistent, Dictionary<string, BinaryData> rawData) : base(protectedItemsCount, backupManagementType, resourceGuardOperationRequests, rawData)
        {
            WorkLoadType = workLoadType;
            Settings = settings;
            SubProtectionPolicy = subProtectionPolicy;
            DoesMakePolicyConsistent = doesMakePolicyConsistent;
            BackupManagementType = backupManagementType ?? "AzureWorkload";
        }

        /// <summary> Type of workload for the backup management. </summary>
        public BackupWorkloadType? WorkLoadType { get; set; }
        /// <summary> Common settings for the backup management. </summary>
        public BackupCommonSettings Settings { get; set; }
        /// <summary> List of sub-protection policies which includes schedule and retention. </summary>
        public IList<SubProtectionPolicy> SubProtectionPolicy { get; }
        /// <summary> Fix the policy inconsistency. </summary>
        public bool? DoesMakePolicyConsistent { get; set; }
    }
}
