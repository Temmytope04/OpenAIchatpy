// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlPrivateEndpointConnection data model.
    /// A private endpoint connection
    /// </summary>
    public partial class MySqlPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MySqlPrivateEndpointConnectionData"/>. </summary>
        public MySqlPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        internal MySqlPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, MySqlPrivateLinkServiceConnectionStateProperty connectionState, string provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> Connection state of the private endpoint connection. </summary>
        public MySqlPrivateLinkServiceConnectionStateProperty ConnectionState { get; set; }
        /// <summary> State of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}
