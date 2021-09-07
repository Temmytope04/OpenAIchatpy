// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the Cluster data model. </summary>
    public partial class ClusterData : TrackedResource
    {
        /// <summary> Initializes a new instance of ClusterData. </summary>
        /// <param name="location"> The location. </param>
        public ClusterData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of the cluster SKU. </param>
        /// <param name="createdAt"> The UTC time when the Event Hubs Cluster was created. </param>
        /// <param name="updatedAt"> The UTC time when the Event Hubs Cluster was last updated. </param>
        /// <param name="metricId"> The metric ID of the cluster resource. Provided by the service and not modifiable by the user. </param>
        /// <param name="status"> Status of the Cluster resource. </param>
        internal ClusterData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, ClusterSku sku, string createdAt, string updatedAt, string metricId, string status) : base(id, name, type, tags, location)
        {
            Sku = sku;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            MetricId = metricId;
            Status = status;
        }

        /// <summary> Properties of the cluster SKU. </summary>
        public ClusterSku Sku { get; set; }
        /// <summary> The UTC time when the Event Hubs Cluster was created. </summary>
        public string CreatedAt { get; }
        /// <summary> The UTC time when the Event Hubs Cluster was last updated. </summary>
        public string UpdatedAt { get; }
        /// <summary> The metric ID of the cluster resource. Provided by the service and not modifiable by the user. </summary>
        public string MetricId { get; }
        /// <summary> Status of the Cluster resource. </summary>
        public string Status { get; }
    }
}
