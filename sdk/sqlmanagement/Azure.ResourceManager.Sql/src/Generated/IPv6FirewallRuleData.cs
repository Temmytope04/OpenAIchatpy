// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the IPv6FirewallRule data model.
    /// An IPv6 server firewall rule.
    /// </summary>
    public partial class IPv6FirewallRuleData : ProxyResourceWithWritableName
    {
        /// <summary> Initializes a new instance of IPv6FirewallRuleData. </summary>
        public IPv6FirewallRuleData()
        {
        }

        /// <summary> Initializes a new instance of IPv6FirewallRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="startIPv6Address"> The start IP address of the firewall rule. Must be IPv6 format. </param>
        /// <param name="endIPv6Address"> The end IP address of the firewall rule. Must be IPv6 format. Must be greater than or equal to startIpv6Address. </param>
        internal IPv6FirewallRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, string startIPv6Address, string endIPv6Address) : base(id, name, resourceType)
        {
            StartIPv6Address = startIPv6Address;
            EndIPv6Address = endIPv6Address;
        }

        /// <summary> The start IP address of the firewall rule. Must be IPv6 format. </summary>
        public string StartIPv6Address { get; set; }
        /// <summary> The end IP address of the firewall rule. Must be IPv6 format. Must be greater than or equal to startIpv6Address. </summary>
        public string EndIPv6Address { get; set; }
    }
}
