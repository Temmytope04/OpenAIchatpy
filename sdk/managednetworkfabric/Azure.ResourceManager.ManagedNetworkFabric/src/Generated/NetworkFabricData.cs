// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabric data model.
    /// The NetworkFabric resource definition.
    /// </summary>
    public partial class NetworkFabricData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFabricData(AzureLocation location) : base(location)
        {
            Racks = new ChangeTrackingList<string>();
            L2IsolationDomains = new ChangeTrackingList<string>();
            L3IsolationDomains = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkFabricData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="racks"> List of NetworkRack resource IDs under the Network Fabric. The number of racks allowed depends on the Network Fabric SKU. </param>
        /// <param name="l2IsolationDomains"> List of L2IsolationDomain resource IDs under the Network Fabric. </param>
        /// <param name="l3IsolationDomains"> List of L3IsolationDomain resource IDs under the Network Fabric. </param>
        /// <param name="networkFabricSku"> Supported Network Fabric SKU.Example: Compute / Aggregate racks. Once the user chooses a particular SKU, only supported racks can be added to the Network Fabric. The SKU determines whether it is a single / multi rack Network Fabric. </param>
        /// <param name="rackCount"> Number of racks associated to Network Fabric.Possible values are from 2-8. </param>
        /// <param name="serverCountPerRack"> Number of servers.Possible values are from 1-16. </param>
        /// <param name="ipv4Prefix"> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </param>
        /// <param name="ipv6Prefix"> IPv6Prefix for Management Network. Example: 3FFE:FFFF:0:CD40::/59. </param>
        /// <param name="routerId"> Router Id of CE to be used for MP-BGP between PE and CE. </param>
        /// <param name="fabricASN"> ASN of CE devices for CE/PE connectivity. </param>
        /// <param name="networkFabricControllerId"> Azure resource ID for the NetworkFabricController the NetworkFabric belongs. </param>
        /// <param name="terminalServerConfiguration"> Network and credentials configuration currently applied to terminal server. </param>
        /// <param name="managementNetworkConfiguration"> Configuration to be used to setup the management network. </param>
        /// <param name="operationalState"> Gets the operational state of the resource. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the resource. </param>
        internal NetworkFabricData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IReadOnlyList<string> racks, IReadOnlyList<string> l2IsolationDomains, IReadOnlyList<string> l3IsolationDomains, string networkFabricSku, int? rackCount, int? serverCountPerRack, string ipv4Prefix, string ipv6Prefix, string routerId, int? fabricASN, string networkFabricControllerId, TerminalServerConfiguration terminalServerConfiguration, ManagementNetworkConfiguration managementNetworkConfiguration, NetworkFabricOperationalState? operationalState, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            Racks = racks;
            L2IsolationDomains = l2IsolationDomains;
            L3IsolationDomains = l3IsolationDomains;
            NetworkFabricSku = networkFabricSku;
            RackCount = rackCount;
            ServerCountPerRack = serverCountPerRack;
            IPv4Prefix = ipv4Prefix;
            IPv6Prefix = ipv6Prefix;
            RouterId = routerId;
            FabricASN = fabricASN;
            NetworkFabricControllerId = networkFabricControllerId;
            TerminalServerConfiguration = terminalServerConfiguration;
            ManagementNetworkConfiguration = managementNetworkConfiguration;
            OperationalState = operationalState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> List of NetworkRack resource IDs under the Network Fabric. The number of racks allowed depends on the Network Fabric SKU. </summary>
        public IReadOnlyList<string> Racks { get; }
        /// <summary> List of L2IsolationDomain resource IDs under the Network Fabric. </summary>
        public IReadOnlyList<string> L2IsolationDomains { get; }
        /// <summary> List of L3IsolationDomain resource IDs under the Network Fabric. </summary>
        public IReadOnlyList<string> L3IsolationDomains { get; }
        /// <summary> Supported Network Fabric SKU.Example: Compute / Aggregate racks. Once the user chooses a particular SKU, only supported racks can be added to the Network Fabric. The SKU determines whether it is a single / multi rack Network Fabric. </summary>
        public string NetworkFabricSku { get; set; }
        /// <summary> Number of racks associated to Network Fabric.Possible values are from 2-8. </summary>
        public int? RackCount { get; set; }
        /// <summary> Number of servers.Possible values are from 1-16. </summary>
        public int? ServerCountPerRack { get; set; }
        /// <summary> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </summary>
        public string IPv4Prefix { get; set; }
        /// <summary> IPv6Prefix for Management Network. Example: 3FFE:FFFF:0:CD40::/59. </summary>
        public string IPv6Prefix { get; set; }
        /// <summary> Router Id of CE to be used for MP-BGP between PE and CE. </summary>
        public string RouterId { get; }
        /// <summary> ASN of CE devices for CE/PE connectivity. </summary>
        public int? FabricASN { get; set; }
        /// <summary> Azure resource ID for the NetworkFabricController the NetworkFabric belongs. </summary>
        public string NetworkFabricControllerId { get; set; }
        /// <summary> Network and credentials configuration currently applied to terminal server. </summary>
        public TerminalServerConfiguration TerminalServerConfiguration { get; set; }
        /// <summary> Configuration to be used to setup the management network. </summary>
        public ManagementNetworkConfiguration ManagementNetworkConfiguration { get; set; }
        /// <summary> Gets the operational state of the resource. </summary>
        public NetworkFabricOperationalState? OperationalState { get; }
        /// <summary> Gets the provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
