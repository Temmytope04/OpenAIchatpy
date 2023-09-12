// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperV Replica Blue policy input. </summary>
    public partial class HyperVReplicaBluePolicyContent : HyperVReplicaPolicyContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaBluePolicyContent. </summary>
        public HyperVReplicaBluePolicyContent()
        {
            InstanceType = "HyperVReplica2012R2";
        }

        /// <summary> A value indicating the replication interval. </summary>
        public int? ReplicationFrequencyInSeconds { get; set; }
    }
}
