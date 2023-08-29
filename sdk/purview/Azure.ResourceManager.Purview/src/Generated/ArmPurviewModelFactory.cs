// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPurviewModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PurviewAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Gets or sets the Sku. </param>
        /// <param name="cloudConnectorsAwsExternalId">
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <param name="identity"> Identity Info on the tracked resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <returns> A new <see cref="Purview.PurviewAccountData"/> instance for mocking. </returns>
        public static PurviewAccountData PurviewAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PurviewAccountSku sku = null, string cloudConnectorsAwsExternalId = null, DateTimeOffset? createdOn = null, string createdBy = null, string createdByObjectId = null, PurviewAccountEndpoint endpoints = null, string friendlyName = null, string managedResourceGroupName = null, PurviewManagedResource managedResources = null, IEnumerable<PurviewPrivateEndpointConnectionData> privateEndpointConnections = null, PurviewProvisioningState? provisioningState = null, PurviewPublicNetworkAccess? publicNetworkAccess = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<PurviewPrivateEndpointConnectionData>();

            return new PurviewAccountData(id, name, resourceType, systemData, tags, location, sku, cloudConnectorsAwsExternalId != null ? new CloudConnectors(cloudConnectorsAwsExternalId, new Dictionary<string, BinaryData>()) : null, createdOn, createdBy, createdByObjectId, endpoints, friendlyName, managedResourceGroupName, managedResources, privateEndpointConnections?.ToList(), provisioningState, publicNetworkAccess, identity, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountProperties"/>. </summary>
        /// <param name="cloudConnectorsAwsExternalId">
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <returns> A new <see cref="Models.PurviewAccountProperties"/> instance for mocking. </returns>
        public static PurviewAccountProperties PurviewAccountProperties(string cloudConnectorsAwsExternalId = null, DateTimeOffset? createdOn = null, string createdBy = null, string createdByObjectId = null, PurviewAccountEndpoint endpoints = null, string friendlyName = null, string managedResourceGroupName = null, PurviewManagedResource managedResources = null, IEnumerable<PurviewPrivateEndpointConnectionData> privateEndpointConnections = null, PurviewProvisioningState? provisioningState = null, PurviewPublicNetworkAccess? publicNetworkAccess = null)
        {
            privateEndpointConnections ??= new List<PurviewPrivateEndpointConnectionData>();

            return new PurviewAccountProperties(cloudConnectorsAwsExternalId != null ? new CloudConnectors(cloudConnectorsAwsExternalId, new Dictionary<string, BinaryData>()) : null, createdOn, createdBy, createdByObjectId, endpoints, friendlyName, managedResourceGroupName, managedResources, privateEndpointConnections?.ToList(), provisioningState, publicNetworkAccess, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountEndpoint"/>. </summary>
        /// <param name="catalog"> Gets the catalog endpoint. </param>
        /// <param name="guardian"> Gets the guardian endpoint. </param>
        /// <param name="scan"> Gets the scan endpoint. </param>
        /// <returns> A new <see cref="Models.PurviewAccountEndpoint"/> instance for mocking. </returns>
        public static PurviewAccountEndpoint PurviewAccountEndpoint(string catalog = null, string guardian = null, string scan = null)
        {
            return new PurviewAccountEndpoint(catalog, guardian, scan, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewManagedResource"/>. </summary>
        /// <param name="eventHubNamespace"> Gets the managed event hub namespace resource identifier. </param>
        /// <param name="resourceGroup"> Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account. </param>
        /// <param name="storageAccount"> Gets the managed storage account resource identifier. </param>
        /// <returns> A new <see cref="Models.PurviewManagedResource"/> instance for mocking. </returns>
        public static PurviewManagedResource PurviewManagedResource(ResourceIdentifier eventHubNamespace = null, ResourceIdentifier resourceGroup = null, ResourceIdentifier storageAccount = null)
        {
            return new PurviewManagedResource(eventHubNamespace, resourceGroup, storageAccount, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The private endpoint information. </param>
        /// <param name="connectionState"> The private link service connection state. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <returns> A new <see cref="Purview.PurviewPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static PurviewPrivateEndpointConnectionData PurviewPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, PurviewPrivateLinkServiceConnectionState connectionState = null, string provisioningState = null)
        {
            return new PurviewPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountSku"/>. </summary>
        /// <param name="capacity"> Gets or sets the sku capacity. </param>
        /// <param name="name"> Gets or sets the sku name. </param>
        /// <returns> A new <see cref="Models.PurviewAccountSku"/> instance for mocking. </returns>
        public static PurviewAccountSku PurviewAccountSku(int? capacity = null, PurviewAccountSkuName? name = null)
        {
            return new PurviewAccountSku(capacity, name, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountAccessKey"/>. </summary>
        /// <param name="atlasKafkaPrimaryEndpoint"> Gets or sets the primary connection string. </param>
        /// <param name="atlasKafkaSecondaryEndpoint"> Gets or sets the secondary connection string. </param>
        /// <returns> A new <see cref="Models.PurviewAccountAccessKey"/> instance for mocking. </returns>
        public static PurviewAccountAccessKey PurviewAccountAccessKey(string atlasKafkaPrimaryEndpoint = null, string atlasKafkaSecondaryEndpoint = null)
        {
            return new PurviewAccountAccessKey(atlasKafkaPrimaryEndpoint, atlasKafkaSecondaryEndpoint, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource properties. </param>
        /// <returns> A new <see cref="Purview.PurviewPrivateLinkResourceData"/> instance for mocking. </returns>
        public static PurviewPrivateLinkResourceData PurviewPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PurviewPrivateLinkResourceProperties properties = null)
        {
            return new PurviewPrivateLinkResourceData(id, name, resourceType, systemData, properties, default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group identifier. </param>
        /// <param name="requiredMembers"> This translates to how many Private IPs should be created for each privately linkable resource. </param>
        /// <param name="requiredZoneNames"> The required zone names for private link resource. </param>
        /// <returns> A new <see cref="Models.PurviewPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static PurviewPrivateLinkResourceProperties PurviewPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new PurviewPrivateLinkResourceProperties(groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), default);
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountNameAvailabilityResult"/>. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="isNameAvailable"> Indicates if name is valid and available. </param>
        /// <param name="reason"> The reason the name is not available. </param>
        /// <returns> A new <see cref="Models.PurviewAccountNameAvailabilityResult"/> instance for mocking. </returns>
        public static PurviewAccountNameAvailabilityResult PurviewAccountNameAvailabilityResult(string message = null, bool? isNameAvailable = null, PurviewAccountNameUnavailableReason? reason = null)
        {
            return new PurviewAccountNameAvailabilityResult(message, isNameAvailable, reason, default);
        }
    }
}
