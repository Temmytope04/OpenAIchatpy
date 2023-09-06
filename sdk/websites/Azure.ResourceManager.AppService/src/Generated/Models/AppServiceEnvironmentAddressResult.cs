// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Describes main public IP address and any extra virtual IPs. </summary>
    public partial class AppServiceEnvironmentAddressResult : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceEnvironmentAddressResult"/>. </summary>
        public AppServiceEnvironmentAddressResult()
        {
            OutboundIPAddresses = new ChangeTrackingList<IPAddress>();
            VirtualIPMappings = new ChangeTrackingList<VirtualIPMapping>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceEnvironmentAddressResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceIPAddress"> Main public virtual IP. </param>
        /// <param name="internalIPAddress"> Virtual Network internal IP address of the App Service Environment if it is in internal load-balancing mode. </param>
        /// <param name="outboundIPAddresses"> IP addresses appearing on outbound connections. </param>
        /// <param name="virtualIPMappings"> Additional virtual IPs. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceEnvironmentAddressResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress serviceIPAddress, IPAddress internalIPAddress, IList<IPAddress> outboundIPAddresses, IList<VirtualIPMapping> virtualIPMappings, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ServiceIPAddress = serviceIPAddress;
            InternalIPAddress = internalIPAddress;
            OutboundIPAddresses = outboundIPAddresses;
            VirtualIPMappings = virtualIPMappings;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Main public virtual IP. </summary>
        public IPAddress ServiceIPAddress { get; set; }
        /// <summary> Virtual Network internal IP address of the App Service Environment if it is in internal load-balancing mode. </summary>
        public IPAddress InternalIPAddress { get; set; }
        /// <summary> IP addresses appearing on outbound connections. </summary>
        public IList<IPAddress> OutboundIPAddresses { get; }
        /// <summary> Additional virtual IPs. </summary>
        public IList<VirtualIPMapping> VirtualIPMappings { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
