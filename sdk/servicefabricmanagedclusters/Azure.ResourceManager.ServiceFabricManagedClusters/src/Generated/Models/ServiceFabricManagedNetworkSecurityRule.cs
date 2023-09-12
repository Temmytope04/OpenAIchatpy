// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a network security rule. </summary>
    public partial class ServiceFabricManagedNetworkSecurityRule
    {
        /// <summary> Initializes a new instance of ServiceFabricManagedNetworkSecurityRule. </summary>
        /// <param name="name"> Network security rule name. </param>
        /// <param name="protocol"> Network protocol this rule applies to. </param>
        /// <param name="access"> The network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </param>
        /// <param name="direction"> Network security rule direction. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ServiceFabricManagedNetworkSecurityRule(string name, ServiceFabricManagedNsgProtocol protocol, ServiceFabricManagedNetworkTrafficAccess access, int priority, ServiceFabricManagedNetworkSecurityRuleDirection direction)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Protocol = protocol;
            SourceAddressPrefixes = new ChangeTrackingList<string>();
            DestinationAddressPrefixes = new ChangeTrackingList<string>();
            SourcePortRanges = new ChangeTrackingList<string>();
            DestinationPortRanges = new ChangeTrackingList<string>();
            Access = access;
            Priority = priority;
            Direction = direction;
        }

        /// <summary> Initializes a new instance of ServiceFabricManagedNetworkSecurityRule. </summary>
        /// <param name="name"> Network security rule name. </param>
        /// <param name="description"> Network security rule description. </param>
        /// <param name="protocol"> Network protocol this rule applies to. </param>
        /// <param name="sourceAddressPrefixes"> The CIDR or source IP ranges. </param>
        /// <param name="destinationAddressPrefixes"> The destination address prefixes. CIDR or destination IP ranges. </param>
        /// <param name="sourcePortRanges"> The source port ranges. </param>
        /// <param name="destinationPortRanges"> The destination port ranges. </param>
        /// <param name="sourceAddressPrefix"> The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from. </param>
        /// <param name="destinationAddressPrefix"> The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. </param>
        /// <param name="sourcePortRange"> The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports. </param>
        /// <param name="destinationPortRange"> he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports. </param>
        /// <param name="access"> The network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </param>
        /// <param name="direction"> Network security rule direction. </param>
        internal ServiceFabricManagedNetworkSecurityRule(string name, string description, ServiceFabricManagedNsgProtocol protocol, IList<string> sourceAddressPrefixes, IList<string> destinationAddressPrefixes, IList<string> sourcePortRanges, IList<string> destinationPortRanges, string sourceAddressPrefix, string destinationAddressPrefix, string sourcePortRange, string destinationPortRange, ServiceFabricManagedNetworkTrafficAccess access, int priority, ServiceFabricManagedNetworkSecurityRuleDirection direction)
        {
            Name = name;
            Description = description;
            Protocol = protocol;
            SourceAddressPrefixes = sourceAddressPrefixes;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            Access = access;
            Priority = priority;
            Direction = direction;
        }

        /// <summary> Network security rule name. </summary>
        public string Name { get; set; }
        /// <summary> Network security rule description. </summary>
        public string Description { get; set; }
        /// <summary> Network protocol this rule applies to. </summary>
        public ServiceFabricManagedNsgProtocol Protocol { get; set; }
        /// <summary> The CIDR or source IP ranges. </summary>
        public IList<string> SourceAddressPrefixes { get; }
        /// <summary> The destination address prefixes. CIDR or destination IP ranges. </summary>
        public IList<string> DestinationAddressPrefixes { get; }
        /// <summary> The source port ranges. </summary>
        public IList<string> SourcePortRanges { get; }
        /// <summary> The destination port ranges. </summary>
        public IList<string> DestinationPortRanges { get; }
        /// <summary> The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from. </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary> The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. </summary>
        public string DestinationAddressPrefix { get; set; }
        /// <summary> The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports. </summary>
        public string SourcePortRange { get; set; }
        /// <summary> he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports. </summary>
        public string DestinationPortRange { get; set; }
        /// <summary> The network traffic is allowed or denied. </summary>
        public ServiceFabricManagedNetworkTrafficAccess Access { get; set; }
        /// <summary> The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </summary>
        public int Priority { get; set; }
        /// <summary> Network security rule direction. </summary>
        public ServiceFabricManagedNetworkSecurityRuleDirection Direction { get; set; }
    }
}
