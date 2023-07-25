// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Information to be stored in Vault properties as an element of privateEndpointConnections List. </summary>
    public partial class RecoveryServicesPrivateEndpointConnectionVaultProperties : ResourceData
    {
        /// <summary> Initializes a new instance of RecoveryServicesPrivateEndpointConnectionVaultProperties. </summary>
        internal RecoveryServicesPrivateEndpointConnectionVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of RecoveryServicesPrivateEndpointConnectionVaultProperties. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Private Endpoint Connection Response Properties. </param>
        /// <param name="location"> The location of the private Endpoint connection. </param>
        internal RecoveryServicesPrivateEndpointConnectionVaultProperties(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RecoveryServicesPrivateEndpointConnection properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Private Endpoint Connection Response Properties. </summary>
        public RecoveryServicesPrivateEndpointConnection Properties { get; }
        /// <summary> The location of the private Endpoint connection. </summary>
        public AzureLocation? Location { get; }
    }
}
