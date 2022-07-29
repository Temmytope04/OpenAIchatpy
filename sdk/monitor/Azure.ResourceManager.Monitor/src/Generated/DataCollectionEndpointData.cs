// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the DataCollectionEndpoint data model. </summary>
    public partial class DataCollectionEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DataCollectionEndpointData. </summary>
        /// <param name="location"> The location. </param>
        public DataCollectionEndpointData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of DataCollectionEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Resource entity tag (ETag). </param>
        /// <param name="description"> Description of the data collection endpoint. </param>
        /// <param name="immutableId"> The immutable ID of this data collection endpoint resource. This property is READ-ONLY. </param>
        /// <param name="configurationAccess"> The endpoint used by agents to access their configuration. </param>
        /// <param name="logsIngestion"> The endpoint used by clients to ingest logs. </param>
        /// <param name="networkAcls"> Network access control rules for the endpoints. </param>
        /// <param name="provisioningState"> The resource provisioning state. This property is READ-ONLY. </param>
        internal DataCollectionEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, string description, string immutableId, DataCollectionEndpointConfigurationAccess configurationAccess, DataCollectionEndpointLogsIngestion logsIngestion, DataCollectionEndpointNetworkAcls networkAcls, DataCollectionEndpointProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Description = description;
            ImmutableId = immutableId;
            ConfigurationAccess = configurationAccess;
            LogsIngestion = logsIngestion;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
        }

        /// <summary> Resource entity tag (ETag). </summary>
        public ETag? ETag { get; }
        /// <summary> Description of the data collection endpoint. </summary>
        public string Description { get; set; }
        /// <summary> The immutable ID of this data collection endpoint resource. This property is READ-ONLY. </summary>
        public string ImmutableId { get; set; }
        /// <summary> The endpoint used by agents to access their configuration. </summary>
        internal DataCollectionEndpointConfigurationAccess ConfigurationAccess { get; set; }
        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string ConfigurationAccessEndpoint
        {
            get => ConfigurationAccess is null ? default : ConfigurationAccess.Endpoint;
        }

        /// <summary> The endpoint used by clients to ingest logs. </summary>
        internal DataCollectionEndpointLogsIngestion LogsIngestion { get; set; }
        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string LogsIngestionEndpoint
        {
            get => LogsIngestion is null ? default : LogsIngestion.Endpoint;
        }

        /// <summary> Network access control rules for the endpoints. </summary>
        internal DataCollectionEndpointNetworkAcls NetworkAcls { get; set; }
        /// <summary> The configuration to set whether network access from public internet to the endpoints are allowed. </summary>
        public MonitorPublicNetworkAccess? PublicNetworkAccess
        {
            get => NetworkAcls is null ? default : NetworkAcls.PublicNetworkAccess;
            set
            {
                if (NetworkAcls is null)
                    NetworkAcls = new DataCollectionEndpointNetworkAcls();
                NetworkAcls.PublicNetworkAccess = value;
            }
        }

        /// <summary> The resource provisioning state. This property is READ-ONLY. </summary>
        public DataCollectionEndpointProvisioningState? ProvisioningState { get; }
    }
}
