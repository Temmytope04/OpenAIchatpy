// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A remote private endpoint connection. </summary>
    public partial class FactoryPrivateEndpointProperties
    {
        /// <summary> Initializes a new instance of FactoryPrivateEndpointProperties. </summary>
        public FactoryPrivateEndpointProperties()
        {
        }

        /// <summary> Initializes a new instance of FactoryPrivateEndpointProperties. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="privateEndpoint"> PrivateEndpoint of a remote private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The state of a private link connection. </param>
        internal FactoryPrivateEndpointProperties(string provisioningState, SubResource privateEndpoint, PrivateLinkConnectionState privateLinkServiceConnectionState)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> PrivateEndpoint of a remote private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> The state of a private link connection. </summary>
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
