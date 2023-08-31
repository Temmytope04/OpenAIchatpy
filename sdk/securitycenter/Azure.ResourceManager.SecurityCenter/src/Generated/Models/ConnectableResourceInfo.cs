// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes the allowed inbound and outbound traffic of an Azure resource. </summary>
    public partial class ConnectableResourceInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectableResourceInfo"/>. </summary>
        internal ConnectableResourceInfo()
        {
            InboundConnectedResources = new ChangeTrackingList<ConnectedResourceInfo>();
            OutboundConnectedResources = new ChangeTrackingList<ConnectedResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectableResourceInfo"/>. </summary>
        /// <param name="id"> The Azure resource id. </param>
        /// <param name="inboundConnectedResources"> The list of Azure resources that the resource has inbound allowed connection from. </param>
        /// <param name="outboundConnectedResources"> The list of Azure resources that the resource has outbound allowed connection to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectableResourceInfo(ResourceIdentifier id, IReadOnlyList<ConnectedResourceInfo> inboundConnectedResources, IReadOnlyList<ConnectedResourceInfo> outboundConnectedResources, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            InboundConnectedResources = inboundConnectedResources;
            OutboundConnectedResources = outboundConnectedResources;
            _rawData = rawData;
        }

        /// <summary> The Azure resource id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The list of Azure resources that the resource has inbound allowed connection from. </summary>
        public IReadOnlyList<ConnectedResourceInfo> InboundConnectedResources { get; }
        /// <summary> The list of Azure resources that the resource has outbound allowed connection to. </summary>
        public IReadOnlyList<ConnectedResourceInfo> OutboundConnectedResources { get; }
    }
}
