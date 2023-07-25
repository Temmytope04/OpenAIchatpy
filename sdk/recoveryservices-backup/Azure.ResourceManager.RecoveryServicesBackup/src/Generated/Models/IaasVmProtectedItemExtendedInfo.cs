// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on Azure IaaS VM specific backup item. </summary>
    public partial class IaasVmProtectedItemExtendedInfo
    {
        /// <summary> Initializes a new instance of IaasVmProtectedItemExtendedInfo. </summary>
        public IaasVmProtectedItemExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of IaasVmProtectedItemExtendedInfo. </summary>
        /// <param name="oldestRecoverOn"> The oldest backup copy available for this backup item across all tiers. </param>
        /// <param name="oldestRecoveryPointInVault"> The oldest backup copy available for this backup item in vault tier. </param>
        /// <param name="oldestRecoveryPointInArchive"> The oldest backup copy available for this backup item in archive tier. </param>
        /// <param name="newestRecoveryPointInArchive"> The latest backup copy available for this backup item in archive tier. </param>
        /// <param name="recoveryPointCount"> Number of backup copies available for this backup item. </param>
        /// <param name="isPolicyInconsistent"> Specifies if backup policy associated with the backup item is inconsistent. </param>
        internal IaasVmProtectedItemExtendedInfo(DateTimeOffset? oldestRecoverOn, DateTimeOffset? oldestRecoveryPointInVault, DateTimeOffset? oldestRecoveryPointInArchive, DateTimeOffset? newestRecoveryPointInArchive, int? recoveryPointCount, bool? isPolicyInconsistent)
        {
            OldestRecoverOn = oldestRecoverOn;
            OldestRecoveryPointInVault = oldestRecoveryPointInVault;
            OldestRecoveryPointInArchive = oldestRecoveryPointInArchive;
            NewestRecoveryPointInArchive = newestRecoveryPointInArchive;
            RecoveryPointCount = recoveryPointCount;
            IsPolicyInconsistent = isPolicyInconsistent;
        }

        /// <summary> The oldest backup copy available for this backup item across all tiers. </summary>
        public DateTimeOffset? OldestRecoverOn { get; set; }
        /// <summary> The oldest backup copy available for this backup item in vault tier. </summary>
        public DateTimeOffset? OldestRecoveryPointInVault { get; set; }
        /// <summary> The oldest backup copy available for this backup item in archive tier. </summary>
        public DateTimeOffset? OldestRecoveryPointInArchive { get; set; }
        /// <summary> The latest backup copy available for this backup item in archive tier. </summary>
        public DateTimeOffset? NewestRecoveryPointInArchive { get; set; }
        /// <summary> Number of backup copies available for this backup item. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> Specifies if backup policy associated with the backup item is inconsistent. </summary>
        public bool? IsPolicyInconsistent { get; set; }
    }
}
