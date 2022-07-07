// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PeerExpressRouteCircuitConnection data model. </summary>
    public partial class PeerExpressRouteCircuitConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionData. </summary>
        public PeerExpressRouteCircuitConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PeerExpressRouteCircuitConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit connection state. </param>
        /// <param name="connectionName"> The name of the express route circuit connection resource. </param>
        /// <param name="authResourceGuid"> The resource guid of the authorization used for the express route circuit connection. </param>
        /// <param name="provisioningState"> The provisioning state of the peer express route circuit connection resource. </param>
        internal PeerExpressRouteCircuitConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, WritableSubResource expressRouteCircuitPeering, WritableSubResource peerExpressRouteCircuitPeering, string addressPrefix, CircuitConnectionStatus? circuitConnectionStatus, string connectionName, Guid? authResourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = eTag;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            CircuitConnectionStatus = circuitConnectionStatus;
            ConnectionName = connectionName;
            AuthResourceGuid = authResourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit. </summary>
        internal WritableSubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ExpressRouteCircuitPeeringId
        {
            get => ExpressRouteCircuitPeering is null ? default : ExpressRouteCircuitPeering.Id;
            set
            {
                if (ExpressRouteCircuitPeering is null)
                    ExpressRouteCircuitPeering = new WritableSubResource();
                ExpressRouteCircuitPeering.Id = value;
            }
        }

        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        internal WritableSubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerExpressRouteCircuitPeeringId
        {
            get => PeerExpressRouteCircuitPeering is null ? default : PeerExpressRouteCircuitPeering.Id;
            set
            {
                if (PeerExpressRouteCircuitPeering is null)
                    PeerExpressRouteCircuitPeering = new WritableSubResource();
                PeerExpressRouteCircuitPeering.Id = value;
            }
        }

        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> Express Route Circuit connection state. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> The name of the express route circuit connection resource. </summary>
        public string ConnectionName { get; set; }
        /// <summary> The resource guid of the authorization used for the express route circuit connection. </summary>
        public Guid? AuthResourceGuid { get; set; }
        /// <summary> The provisioning state of the peer express route circuit connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
