// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuitPeering data model. </summary>
    public partial class ExpressRouteCircuitPeeringData : Models.SubResource
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringData. </summary>
        public ExpressRouteCircuitPeeringData()
        {
            Connections = new ChangeTrackingList<ExpressRouteCircuitConnectionData>();
            PeeredConnections = new ChangeTrackingList<PeerExpressRouteCircuitConnectionData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Type of the resource. </param>
        /// <param name="peeringType"> The peering type. </param>
        /// <param name="state"> The peering state. </param>
        /// <param name="azureASN"> The Azure ASN. </param>
        /// <param name="peerASN"> The peer ASN. </param>
        /// <param name="primaryPeerAddressPrefix"> The primary address prefix. </param>
        /// <param name="secondaryPeerAddressPrefix"> The secondary address prefix. </param>
        /// <param name="primaryAzurePort"> The primary port. </param>
        /// <param name="secondaryAzurePort"> The secondary port. </param>
        /// <param name="sharedKey"> The shared key. </param>
        /// <param name="vlanId"> The VLAN ID. </param>
        /// <param name="microsoftPeeringConfig"> The Microsoft peering configuration. </param>
        /// <param name="stats"> The peering stats of express route circuit. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit peering resource. </param>
        /// <param name="gatewayManagerEtag"> The GatewayManager Etag. </param>
        /// <param name="lastModifiedBy"> Who was the last to modify the peering. </param>
        /// <param name="routeFilter"> The reference to the RouteFilter resource. </param>
        /// <param name="iPv6PeeringConfig"> The IPv6 peering configuration. </param>
        /// <param name="expressRouteConnection"> The ExpressRoute connection. </param>
        /// <param name="connections"> The list of circuit connections associated with Azure Private Peering for this circuit. </param>
        /// <param name="peeredConnections"> The list of peered circuit connections associated with Azure Private Peering for this circuit. </param>
        internal ExpressRouteCircuitPeeringData(string id, string name, string etag, string resourceType, ExpressRoutePeeringType? peeringType, ExpressRoutePeeringState? state, int? azureASN, long? peerASN, string primaryPeerAddressPrefix, string secondaryPeerAddressPrefix, string primaryAzurePort, string secondaryAzurePort, string sharedKey, int? vlanId, ExpressRouteCircuitPeeringConfig microsoftPeeringConfig, ExpressRouteCircuitStats stats, ProvisioningState? provisioningState, string gatewayManagerEtag, string lastModifiedBy, WritableSubResource routeFilter, IPv6ExpressRouteCircuitPeeringConfig iPv6PeeringConfig, Resources.Models.SubResource expressRouteConnection, IList<ExpressRouteCircuitConnectionData> connections, IReadOnlyList<PeerExpressRouteCircuitConnectionData> peeredConnections) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Stats = stats;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            LastModifiedBy = lastModifiedBy;
            RouteFilter = routeFilter;
            IPv6PeeringConfig = iPv6PeeringConfig;
            ExpressRouteConnection = expressRouteConnection;
            Connections = connections;
            PeeredConnections = peeredConnections;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> The peering type. </summary>
        public ExpressRoutePeeringType? PeeringType { get; set; }
        /// <summary> The peering state. </summary>
        public ExpressRoutePeeringState? State { get; set; }
        /// <summary> The Azure ASN. </summary>
        public int? AzureASN { get; set; }
        /// <summary> The peer ASN. </summary>
        public long? PeerASN { get; set; }
        /// <summary> The primary address prefix. </summary>
        public string PrimaryPeerAddressPrefix { get; set; }
        /// <summary> The secondary address prefix. </summary>
        public string SecondaryPeerAddressPrefix { get; set; }
        /// <summary> The primary port. </summary>
        public string PrimaryAzurePort { get; set; }
        /// <summary> The secondary port. </summary>
        public string SecondaryAzurePort { get; set; }
        /// <summary> The shared key. </summary>
        public string SharedKey { get; set; }
        /// <summary> The VLAN ID. </summary>
        public int? VlanId { get; set; }
        /// <summary> The Microsoft peering configuration. </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }
        /// <summary> The peering stats of express route circuit. </summary>
        public ExpressRouteCircuitStats Stats { get; set; }
        /// <summary> The provisioning state of the express route circuit peering resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The GatewayManager Etag. </summary>
        public string GatewayManagerEtag { get; set; }
        /// <summary> Who was the last to modify the peering. </summary>
        public string LastModifiedBy { get; }
        /// <summary> The reference to the RouteFilter resource. </summary>
        internal WritableSubResource RouteFilter { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RouteFilterId
        {
            get => RouteFilter is null ? default : RouteFilter.Id;
            set
            {
                if (RouteFilter is null)
                    RouteFilter = new WritableSubResource();
                RouteFilter.Id = value;
            }
        }

        /// <summary> The IPv6 peering configuration. </summary>
        public IPv6ExpressRouteCircuitPeeringConfig IPv6PeeringConfig { get; set; }
        /// <summary> The ExpressRoute connection. </summary>
        internal Resources.Models.SubResource ExpressRouteConnection { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier ExpressRouteConnectionId
        {
            get => ExpressRouteConnection is null ? default : ExpressRouteConnection.Id;
        }

        /// <summary> The list of circuit connections associated with Azure Private Peering for this circuit. </summary>
        public IList<ExpressRouteCircuitConnectionData> Connections { get; }
        /// <summary> The list of peered circuit connections associated with Azure Private Peering for this circuit. </summary>
        public IReadOnlyList<PeerExpressRouteCircuitConnectionData> PeeredConnections { get; }
    }
}
