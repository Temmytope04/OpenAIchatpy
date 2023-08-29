// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Network rule set. </summary>
    public partial class StorageAccountNetworkRuleSet
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountNetworkRuleSet"/>. </summary>
        /// <param name="defaultAction"> Specifies the default action of allow or deny when no other rules match. </param>
        public StorageAccountNetworkRuleSet(StorageNetworkDefaultAction defaultAction)
        {
            ResourceAccessRules = new ChangeTrackingList<StorageAccountResourceAccessRule>();
            VirtualNetworkRules = new ChangeTrackingList<StorageAccountVirtualNetworkRule>();
            IPRules = new ChangeTrackingList<StorageAccountIPRule>();
            DefaultAction = defaultAction;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountNetworkRuleSet"/>. </summary>
        /// <param name="bypass"> Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics. </param>
        /// <param name="resourceAccessRules"> Sets the resource access rules. </param>
        /// <param name="virtualNetworkRules"> Sets the virtual network rules. </param>
        /// <param name="ipRules"> Sets the IP ACL rules. </param>
        /// <param name="defaultAction"> Specifies the default action of allow or deny when no other rules match. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountNetworkRuleSet(StorageNetworkBypass? bypass, IList<StorageAccountResourceAccessRule> resourceAccessRules, IList<StorageAccountVirtualNetworkRule> virtualNetworkRules, IList<StorageAccountIPRule> ipRules, StorageNetworkDefaultAction defaultAction, Dictionary<string, BinaryData> rawData)
        {
            Bypass = bypass;
            ResourceAccessRules = resourceAccessRules;
            VirtualNetworkRules = virtualNetworkRules;
            IPRules = ipRules;
            DefaultAction = defaultAction;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountNetworkRuleSet"/> for deserialization. </summary>
        internal StorageAccountNetworkRuleSet()
        {
        }

        /// <summary> Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics. </summary>
        public StorageNetworkBypass? Bypass { get; set; }
        /// <summary> Sets the resource access rules. </summary>
        public IList<StorageAccountResourceAccessRule> ResourceAccessRules { get; }
        /// <summary> Sets the virtual network rules. </summary>
        public IList<StorageAccountVirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> Sets the IP ACL rules. </summary>
        public IList<StorageAccountIPRule> IPRules { get; }
        /// <summary> Specifies the default action of allow or deny when no other rules match. </summary>
        public StorageNetworkDefaultAction DefaultAction { get; set; }
    }
}
