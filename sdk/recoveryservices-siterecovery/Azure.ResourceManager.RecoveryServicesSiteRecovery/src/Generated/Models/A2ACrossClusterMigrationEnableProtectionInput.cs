// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Cross-Cluster Migration enable protection input. </summary>
    public partial class A2ACrossClusterMigrationEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary> Initializes a new instance of A2ACrossClusterMigrationEnableProtectionInput. </summary>
        public A2ACrossClusterMigrationEnableProtectionInput()
        {
            InstanceType = "A2ACrossClusterMigration";
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public string FabricObjectId { get; set; }
        /// <summary> The recovery container Id. </summary>
        public string RecoveryContainerId { get; set; }
    }
}
