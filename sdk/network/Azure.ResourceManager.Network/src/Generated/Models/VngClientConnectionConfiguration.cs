// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A vpn client connection configuration for client connection configuration. </summary>
    public partial class VngClientConnectionConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of VngClientConnectionConfiguration. </summary>
        public VngClientConnectionConfiguration()
        {
            VirtualNetworkGatewayPolicyGroups = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VngClientConnectionConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="vpnClientAddressPool"> The reference to the address space resource which represents Address space for P2S VpnClient. </param>
        /// <param name="virtualNetworkGatewayPolicyGroups"> List of references to virtualNetworkGatewayPolicyGroups. </param>
        /// <param name="provisioningState"> The provisioning state of the VngClientConnectionConfiguration resource. </param>
        internal VngClientConnectionConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, AddressSpace vpnClientAddressPool, IList<WritableSubResource> virtualNetworkGatewayPolicyGroups, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            VpnClientAddressPool = vpnClientAddressPool;
            VirtualNetworkGatewayPolicyGroups = virtualNetworkGatewayPolicyGroups;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the address space resource which represents Address space for P2S VpnClient. </summary>
        internal AddressSpace VpnClientAddressPool { get; set; }
        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> VpnClientAddressPrefixes
        {
            get
            {
                if (VpnClientAddressPool is null)
                    VpnClientAddressPool = new AddressSpace();
                return VpnClientAddressPool.AddressPrefixes;
            }
        }

        /// <summary> List of references to virtualNetworkGatewayPolicyGroups. </summary>
        public IList<WritableSubResource> VirtualNetworkGatewayPolicyGroups { get; }
        /// <summary> The provisioning state of the VngClientConnectionConfiguration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
