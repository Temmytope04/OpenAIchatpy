// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan InMageRcmFailback failover input. </summary>
    public partial class RecoveryPlanInMageRcmFailbackFailoverInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary> Initializes a new instance of RecoveryPlanInMageRcmFailbackFailoverInput. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public RecoveryPlanInMageRcmFailbackFailoverInput(InMageRcmFailbackRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> The recovery point type. </summary>
        public InMageRcmFailbackRecoveryPointType RecoveryPointType { get; }
        /// <summary> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </summary>
        public string UseMultiVmSyncPoint { get; set; }
    }
}
