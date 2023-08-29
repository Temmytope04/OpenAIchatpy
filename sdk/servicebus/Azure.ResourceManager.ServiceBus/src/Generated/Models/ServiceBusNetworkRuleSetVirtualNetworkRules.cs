// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Description of VirtualNetworkRules - NetworkRules resource. </summary>
    public partial class ServiceBusNetworkRuleSetVirtualNetworkRules
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceBusNetworkRuleSetVirtualNetworkRules"/>. </summary>
        public ServiceBusNetworkRuleSetVirtualNetworkRules()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusNetworkRuleSetVirtualNetworkRules"/>. </summary>
        /// <param name="subnet"> Subnet properties. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Value that indicates whether to ignore missing VNet Service Endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusNetworkRuleSetVirtualNetworkRules(WritableSubResource subnet, bool? ignoreMissingVnetServiceEndpoint, Dictionary<string, BinaryData> rawData)
        {
            Subnet = subnet;
            IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            _rawData = rawData;
        }

        /// <summary> Subnet properties. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Value that indicates whether to ignore missing VNet Service Endpoint. </summary>
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }
}
