// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Private endpoint connection item. </summary>
    public partial class PrivateEndpointConnectionItemData
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionItemData. </summary>
        internal PrivateEndpointConnectionItemData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionItemData. </summary>
        /// <param name="id"> Id of private endpoint connection. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpoint"> Properties of the private endpoint object. </param>
        /// <param name="connectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        internal PrivateEndpointConnectionItemData(string id, ETag? etag, SubResource privateEndpoint, KeyVaultPrivateLinkServiceConnectionState connectionState, KeyVaultPrivateEndpointConnectionProvisioningState? provisioningState)
        {
            Id = id;
            Etag = etag;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Id of private endpoint connection. </summary>
        public string Id { get; }
        /// <summary> Modified whenever there is a change in the state of private endpoint connection. </summary>
        public ETag? Etag { get; }
        /// <summary> Properties of the private endpoint object. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> Approval state of the private link connection. </summary>
        public KeyVaultPrivateLinkServiceConnectionState ConnectionState { get; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public KeyVaultPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
