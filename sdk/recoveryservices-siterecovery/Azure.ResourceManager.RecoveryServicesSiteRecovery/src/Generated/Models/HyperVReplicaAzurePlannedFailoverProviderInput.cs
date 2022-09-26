// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVReplicaAzure specific planned failover input. </summary>
    public partial class HyperVReplicaAzurePlannedFailoverProviderInput : PlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzurePlannedFailoverProviderInput. </summary>
        public HyperVReplicaAzurePlannedFailoverProviderInput()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Primary kek certificate pfx. </summary>
        public string PrimaryKekCertificatePfx { get; set; }
        /// <summary> Secondary kek certificate pfx. </summary>
        public string SecondaryKekCertificatePfx { get; set; }
        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public string RecoveryPointId { get; set; }
    }
}
