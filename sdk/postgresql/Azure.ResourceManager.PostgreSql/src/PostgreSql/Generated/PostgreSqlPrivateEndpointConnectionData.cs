// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing the PostgreSqlPrivateEndpointConnection data model.
    /// A private endpoint connection
    /// </summary>
    public partial class PostgreSqlPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of PostgreSqlPrivateEndpointConnectionData. </summary>
        public PostgreSqlPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        internal PostgreSqlPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, PostgreSqlPrivateLinkServiceConnectionStateProperty connectionState, string provisioningState) : base(id, name, resourceType, systemData)
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
        public PostgreSqlPrivateLinkServiceConnectionStateProperty ConnectionState { get; set; }
        /// <summary> State of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}
