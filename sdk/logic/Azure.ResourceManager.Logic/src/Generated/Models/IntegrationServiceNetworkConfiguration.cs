// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The network configuration. </summary>
    public partial class IntegrationServiceNetworkConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceNetworkConfiguration"/>. </summary>
        public IntegrationServiceNetworkConfiguration()
        {
            Subnets = new ChangeTrackingList<LogicResourceReference>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceNetworkConfiguration"/>. </summary>
        /// <param name="virtualNetworkAddressSpace"> Gets the virtual network address space. </param>
        /// <param name="accessEndpoint"> The access endpoint. </param>
        /// <param name="subnets"> The subnets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceNetworkConfiguration(string virtualNetworkAddressSpace, IntegrationServiceEnvironmentAccessEndpoint accessEndpoint, IList<LogicResourceReference> subnets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualNetworkAddressSpace = virtualNetworkAddressSpace;
            AccessEndpoint = accessEndpoint;
            Subnets = subnets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the virtual network address space. </summary>
        public string VirtualNetworkAddressSpace { get; set; }
        /// <summary> The access endpoint. </summary>
        internal IntegrationServiceEnvironmentAccessEndpoint AccessEndpoint { get; set; }
        /// <summary> The access endpoint type. </summary>
        public IntegrationServiceEnvironmentAccessEndpointType? EndpointType
        {
            get => AccessEndpoint is null ? default : AccessEndpoint.EndpointType;
            set
            {
                if (AccessEndpoint is null)
                    AccessEndpoint = new IntegrationServiceEnvironmentAccessEndpoint();
                AccessEndpoint.EndpointType = value;
            }
        }

        /// <summary> The subnets. </summary>
        public IList<LogicResourceReference> Subnets { get; }
    }
}
