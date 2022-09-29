// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific resume replication input. </summary>
    public partial class VMwareCbtResumeReplicationInput : ResumeReplicationProviderSpecificInput
    {
        /// <summary> Initializes a new instance of VMwareCbtResumeReplicationInput. </summary>
        public VMwareCbtResumeReplicationInput()
        {
            InstanceType = "VMwareCbt";
        }

        /// <summary> A value indicating whether Migration resources to be deleted. </summary>
        public string DeleteMigrationResources { get; set; }
    }
}
