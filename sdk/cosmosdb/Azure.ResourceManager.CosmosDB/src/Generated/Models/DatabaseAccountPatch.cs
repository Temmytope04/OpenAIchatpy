// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters for patching Azure Cosmos DB database account properties. </summary>
    public partial class DatabaseAccountPatch
    {
        /// <summary> Initializes a new instance of DatabaseAccountPatch. </summary>
        public DatabaseAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Locations = new ChangeTrackingList<DatabaseAccountLocation>();
            IPRules = new ChangeTrackingList<IPAddressOrRange>();
            Capabilities = new ChangeTrackingList<DatabaseAccountCapability>();
            VirtualNetworkRules = new ChangeTrackingList<VirtualNetworkRule>();
            Cors = new ChangeTrackingList<CorsPolicy>();
            NetworkAclBypassResourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with &quot;defaultExperience&quot;: &quot;Cassandra&quot;. Current &quot;defaultExperience&quot; values also include &quot;Table&quot;, &quot;Graph&quot;, &quot;DocumentDB&quot;, and &quot;MongoDB&quot;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The location of the resource group to which the resource belongs. </summary>
        public string Location { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The consistency policy for the Cosmos DB account. </summary>
        public ConsistencyPolicy ConsistencyPolicy { get; set; }
        /// <summary> An array that contains the georeplication locations enabled for the Cosmos DB account. </summary>
        public IList<DatabaseAccountLocation> Locations { get; }
        /// <summary> List of IpRules. </summary>
        public IList<IPAddressOrRange> IPRules { get; }
        /// <summary> Flag to indicate whether to enable/disable Virtual Network ACL rules. </summary>
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        /// <summary> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </summary>
        public bool? EnableAutomaticFailover { get; set; }
        /// <summary> List of Cosmos DB capabilities for the account. </summary>
        public IList<DatabaseAccountCapability> Capabilities { get; }
        /// <summary> List of Virtual Network ACL rules configured for the Cosmos DB account. </summary>
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> Enables the account to write in multiple locations. </summary>
        public bool? EnableMultipleWriteLocations { get; set; }
        /// <summary> Enables the cassandra connector on the Cosmos DB C* account. </summary>
        public bool? EnableCassandraConnector { get; set; }
        /// <summary> The cassandra connector offer type for the Cosmos DB database C* account. </summary>
        public ConnectorOffer? ConnectorOffer { get; set; }
        /// <summary> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </summary>
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        /// <summary> The URI of the key vault. </summary>
        public Uri KeyVaultKeyUri { get; set; }
        /// <summary> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be &quot;FirstPartyIdentity&quot;, &quot;SystemAssignedIdentity&quot; and more. </summary>
        public string DefaultIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Flag to indicate whether Free Tier is enabled. </summary>
        public bool? EnableFreeTier { get; set; }
        /// <summary> API specific properties. Currently, supported only for MongoDB API. </summary>
        internal ApiProperties ApiProperties { get; set; }
        /// <summary> Describes the ServerVersion of an a MongoDB account. </summary>
        public ServerVersion? ApiServerVersion
        {
            get => ApiProperties is null ? default : ApiProperties.ServerVersion;
            set
            {
                if (ApiProperties is null)
                    ApiProperties = new ApiProperties();
                ApiProperties.ServerVersion = value;
            }
        }

        /// <summary> Flag to indicate whether to enable storage analytics. </summary>
        public bool? EnableAnalyticalStorage { get; set; }
        /// <summary> Analytical storage specific properties. </summary>
        internal AnalyticalStorageConfiguration AnalyticalStorageConfiguration { get; set; }
        /// <summary> Describes the types of schema for analytical storage. </summary>
        public AnalyticalStorageSchemaType? AnalyticalStorageSchemaType
        {
            get => AnalyticalStorageConfiguration is null ? default : AnalyticalStorageConfiguration.SchemaType;
            set
            {
                if (AnalyticalStorageConfiguration is null)
                    AnalyticalStorageConfiguration = new AnalyticalStorageConfiguration();
                AnalyticalStorageConfiguration.SchemaType = value;
            }
        }

        /// <summary> The object representing the policy for taking backups on an account. </summary>
        public BackupPolicy BackupPolicy { get; set; }
        /// <summary> The CORS policy for the Cosmos DB database account. </summary>
        public IList<CorsPolicy> Cors { get; }
        /// <summary> Indicates what services are allowed to bypass firewall checks. </summary>
        public NetworkAclBypass? NetworkAclBypass { get; set; }
        /// <summary> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </summary>
        public IList<string> NetworkAclBypassResourceIds { get; }
        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> The object that represents all properties related to capacity enforcement on an account. </summary>
        internal Capacity Capacity { get; set; }
        /// <summary> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </summary>
        public int? CapacityTotalThroughputLimit
        {
            get => Capacity is null ? default : Capacity.TotalThroughputLimit;
            set
            {
                if (Capacity is null)
                    Capacity = new Capacity();
                Capacity.TotalThroughputLimit = value;
            }
        }
    }
}
