// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific input to update replication protected item. </summary>
    public partial class InMageRcmUpdateReplicationProtectedItemInput : UpdateReplicationProtectedItemProviderInput
    {
        /// <summary> Initializes a new instance of InMageRcmUpdateReplicationProtectedItemInput. </summary>
        public InMageRcmUpdateReplicationProtectedItemInput()
        {
            VmNics = new ChangeTrackingList<InMageRcmNicInput>();
            InstanceType = "InMageRcm";
        }

        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The target resource group ARM Id. </summary>
        public string TargetResourceGroupId { get; set; }
        /// <summary> The target availability set ARM Id. </summary>
        public string TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target proximity placement group Id. </summary>
        public string TargetProximityPlacementGroupId { get; set; }
        /// <summary> The target boot diagnostics storage account ARM Id. </summary>
        public string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary> The target network ARM Id. </summary>
        public string TargetNetworkId { get; set; }
        /// <summary> The test network ARM Id. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> The list of NIC details. </summary>
        public IList<InMageRcmNicInput> VmNics { get; }
        /// <summary> The license type. </summary>
        public LicenseType? LicenseType { get; set; }
    }
}
