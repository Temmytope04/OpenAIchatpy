// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing the ProvisionedCluster data model.
    /// The provisionedClusters resource definition.
    /// </summary>
    public partial class ProvisionedClusterData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ProvisionedClusterData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the Provisioned cluster. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="properties"></param>
        /// <param name="extendedLocation"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ProvisionedClustersResponseProperties properties, ProvisionedClustersResponseExtendedLocation extendedLocation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Properties = properties;
            ExtendedLocation = extendedLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterData"/> for deserialization. </summary>
        internal ProvisionedClusterData()
        {
        }

        /// <summary> Identity for the Provisioned cluster. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the properties. </summary>
        public ProvisionedClustersResponseProperties Properties { get; set; }
        /// <summary> Gets or sets the extended location. </summary>
        public ProvisionedClustersResponseExtendedLocation ExtendedLocation { get; set; }
    }
}
