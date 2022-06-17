// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing the DeviceUpdateAccount data model. </summary>
    public partial class DeviceUpdateAccountData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DeviceUpdateAccountData. </summary>
        /// <param name="location"> The location. </param>
        public DeviceUpdateAccountData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<DeviceUpdatePrivateEndpointConnectionData>();
            Locations = new ChangeTrackingList<DeviceUpdateAccountLocationDetail>();
        }

        /// <summary> Initializes a new instance of DeviceUpdateAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The type of identity used for the resource. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="hostName"> API host name. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for the account. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the account. </param>
        /// <param name="sku"> Device Update Sku. </param>
        /// <param name="locations"> Device Update account primary and failover location details. </param>
        internal DeviceUpdateAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ProvisioningState? provisioningState, string hostName, PublicNetworkAccess? publicNetworkAccess, IList<DeviceUpdatePrivateEndpointConnectionData> privateEndpointConnections, DeviceUpdateSku? sku, IReadOnlyList<DeviceUpdateAccountLocationDetail> locations) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            HostName = hostName;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            Sku = sku;
            Locations = locations;
        }

        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> API host name. </summary>
        public string HostName { get; }
        /// <summary> Whether or not public network access is allowed for the account. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> List of private endpoint connections associated with the account. </summary>
        public IList<DeviceUpdatePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Device Update Sku. </summary>
        public DeviceUpdateSku? Sku { get; set; }
        /// <summary> Device Update account primary and failover location details. </summary>
        public IReadOnlyList<DeviceUpdateAccountLocationDetail> Locations { get; }
    }
}
