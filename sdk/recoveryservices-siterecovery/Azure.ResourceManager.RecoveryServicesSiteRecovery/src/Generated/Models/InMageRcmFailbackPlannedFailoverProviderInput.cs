// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Provider specific input for InMageRcmFailback failover. </summary>
    public partial class InMageRcmFailbackPlannedFailoverProviderInput : PlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary> Initializes a new instance of InMageRcmFailbackPlannedFailoverProviderInput. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public InMageRcmFailbackPlannedFailoverProviderInput(InMageRcmFailbackRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> The recovery point type. </summary>
        public InMageRcmFailbackRecoveryPointType RecoveryPointType { get; }
    }
}
