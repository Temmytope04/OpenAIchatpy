// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The available private link resources for an IotHub. </summary>
    internal partial class IotHubPrivateLinkResources
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkResources"/>. </summary>
        internal IotHubPrivateLinkResources()
        {
            Value = new ChangeTrackingList<IotHubPrivateEndpointGroupInformationData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateLinkResources"/>. </summary>
        /// <param name="value"> The list of available private link resources for an IotHub. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubPrivateLinkResources(IReadOnlyList<IotHubPrivateEndpointGroupInformationData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of available private link resources for an IotHub. </summary>
        public IReadOnlyList<IotHubPrivateEndpointGroupInformationData> Value { get; }
    }
}
