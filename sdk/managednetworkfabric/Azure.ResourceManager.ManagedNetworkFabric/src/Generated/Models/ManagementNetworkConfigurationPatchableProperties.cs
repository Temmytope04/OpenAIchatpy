// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Configuration to be used to setup the management network. </summary>
    public partial class ManagementNetworkConfigurationPatchableProperties
    {
        /// <summary> Initializes a new instance of <see cref="ManagementNetworkConfigurationPatchableProperties"/>. </summary>
        public ManagementNetworkConfigurationPatchableProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementNetworkConfigurationPatchableProperties"/>. </summary>
        /// <param name="infrastructureVpnConfiguration"> VPN Configuration properties. </param>
        /// <param name="workloadVpnConfiguration"> VPN Configuration properties. </param>
        internal ManagementNetworkConfigurationPatchableProperties(VpnConfigurationPatchableProperties infrastructureVpnConfiguration, VpnConfigurationPatchableProperties workloadVpnConfiguration)
        {
            InfrastructureVpnConfiguration = infrastructureVpnConfiguration;
            WorkloadVpnConfiguration = workloadVpnConfiguration;
        }

        /// <summary> VPN Configuration properties. </summary>
        public VpnConfigurationPatchableProperties InfrastructureVpnConfiguration { get; set; }
        /// <summary> VPN Configuration properties. </summary>
        public VpnConfigurationPatchableProperties WorkloadVpnConfiguration { get; set; }
    }
}
