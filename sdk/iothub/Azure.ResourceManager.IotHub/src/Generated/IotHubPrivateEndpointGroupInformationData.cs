// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing the IotHubPrivateEndpointGroupInformation data model.
    /// The group information for creating a private endpoint on an IotHub
    /// </summary>
    public partial class IotHubPrivateEndpointGroupInformationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointGroupInformationData"/>. </summary>
        /// <param name="properties"> The properties for a group information object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal IotHubPrivateEndpointGroupInformationData(IotHubPrivateEndpointGroupInformationProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointGroupInformationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties for a group information object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubPrivateEndpointGroupInformationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IotHubPrivateEndpointGroupInformationProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointGroupInformationData"/> for deserialization. </summary>
        internal IotHubPrivateEndpointGroupInformationData()
        {
        }

        /// <summary> The properties for a group information object. </summary>
        public IotHubPrivateEndpointGroupInformationProperties Properties { get; }
    }
}
