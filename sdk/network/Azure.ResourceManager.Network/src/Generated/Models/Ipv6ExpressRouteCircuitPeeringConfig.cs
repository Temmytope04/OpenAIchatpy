// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains IPv6 peering config. </summary>
    public partial class Ipv6ExpressRouteCircuitPeeringConfig
    {
        /// <summary> Initializes a new instance of Ipv6ExpressRouteCircuitPeeringConfig. </summary>
        public Ipv6ExpressRouteCircuitPeeringConfig()
        {
        }

        /// <summary> Initializes a new instance of Ipv6ExpressRouteCircuitPeeringConfig. </summary>
        /// <param name="primaryPeerAddressPrefix"> The primary address prefix. </param>
        /// <param name="secondaryPeerAddressPrefix"> The secondary address prefix. </param>
        /// <param name="microsoftPeeringConfig"> The Microsoft peering configuration. </param>
        /// <param name="routeFilter"> The reference to the RouteFilter resource. </param>
        /// <param name="state"> The state of peering. </param>
        internal Ipv6ExpressRouteCircuitPeeringConfig(string primaryPeerAddressPrefix, string secondaryPeerAddressPrefix, ExpressRouteCircuitPeeringConfig microsoftPeeringConfig, WritableSubResource routeFilter, ExpressRouteCircuitPeeringState? state)
        {
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            RouteFilter = routeFilter;
            State = state;
        }

        /// <summary> The primary address prefix. </summary>
        public string PrimaryPeerAddressPrefix { get; set; }
        /// <summary> The secondary address prefix. </summary>
        public string SecondaryPeerAddressPrefix { get; set; }
        /// <summary> The Microsoft peering configuration. </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }
        /// <summary> The reference to the RouteFilter resource. </summary>
        public WritableSubResource RouteFilter { get; set; }
        /// <summary> The state of peering. </summary>
        public ExpressRouteCircuitPeeringState? State { get; set; }
    }
}
