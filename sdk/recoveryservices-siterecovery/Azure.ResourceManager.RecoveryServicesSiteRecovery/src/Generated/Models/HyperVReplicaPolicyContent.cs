// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Hyper-V Replica specific policy Input.
    /// Please note <see cref="HyperVReplicaPolicyContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HyperVReplicaBluePolicyContent"/>.
    /// </summary>
    public partial class HyperVReplicaPolicyContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaPolicyContent. </summary>
        public HyperVReplicaPolicyContent()
        {
            InstanceType = "HyperVReplica2012";
        }

        /// <summary> A value indicating the number of recovery points. </summary>
        public int? RecoveryPoints { get; set; }
        /// <summary> A value indicating the application consistent frequency. </summary>
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }
        /// <summary> A value indicating whether compression has to be enabled. </summary>
        public string Compression { get; set; }
        /// <summary> A value indicating whether IR is online. </summary>
        public string InitialReplicationMethod { get; set; }
        /// <summary> A value indicating the online IR start time. </summary>
        public string OnlineReplicationStartTime { get; set; }
        /// <summary> A value indicating the offline IR import path. </summary>
        public string OfflineReplicationImportPath { get; set; }
        /// <summary> A value indicating the offline IR export path. </summary>
        public string OfflineReplicationExportPath { get; set; }
        /// <summary> A value indicating the recovery HTTPS port. </summary>
        public int? ReplicationPort { get; set; }
        /// <summary> A value indicating the authentication type. </summary>
        public int? AllowedAuthenticationType { get; set; }
        /// <summary> A value indicating whether the VM has to be auto deleted. </summary>
        public string ReplicaDeletion { get; set; }
    }
}
