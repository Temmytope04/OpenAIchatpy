// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing a read only following database. </summary>
    public partial class ReadOnlyFollowingDatabase : DatabaseData
    {
        /// <summary> Initializes a new instance of ReadOnlyFollowingDatabase. </summary>
        public ReadOnlyFollowingDatabase()
        {
            Kind = KustoKind.ReadOnlyFollowing;
        }

        /// <summary> Initializes a new instance of ReadOnlyFollowingDatabase. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the database. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="softDeletePeriod"> The time the data should be kept before it stops being accessible to queries in TimeSpan. </param>
        /// <param name="hotCachePeriod"> The time the data should be kept in cache for fast queries in TimeSpan. </param>
        /// <param name="statistics"> The statistics of the database. </param>
        /// <param name="leaderClusterResourceId"> The name of the leader cluster. </param>
        /// <param name="attachedDatabaseConfigurationName"> The name of the attached database configuration cluster. </param>
        /// <param name="principalsModificationKind"> The principals modification kind of the database. </param>
        internal ReadOnlyFollowingDatabase(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, KustoKind kind, ProvisioningState? provisioningState, TimeSpan? softDeletePeriod, TimeSpan? hotCachePeriod, DatabaseStatistics statistics, string leaderClusterResourceId, string attachedDatabaseConfigurationName, PrincipalsModificationKind? principalsModificationKind) : base(id, name, resourceType, systemData, location, kind)
        {
            ProvisioningState = provisioningState;
            SoftDeletePeriod = softDeletePeriod;
            HotCachePeriod = hotCachePeriod;
            Statistics = statistics;
            LeaderClusterResourceId = leaderClusterResourceId;
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
            PrincipalsModificationKind = principalsModificationKind;
            Kind = kind;
        }

        /// <summary> The provisioned state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The time the data should be kept before it stops being accessible to queries in TimeSpan. </summary>
        public TimeSpan? SoftDeletePeriod { get; }
        /// <summary> The time the data should be kept in cache for fast queries in TimeSpan. </summary>
        public TimeSpan? HotCachePeriod { get; set; }
        /// <summary> The statistics of the database. </summary>
        internal DatabaseStatistics Statistics { get; }
        /// <summary> The database size - the total size of compressed data and index in bytes. </summary>
        public float? StatisticsSize
        {
            get => Statistics?.Size;
        }

        /// <summary> The name of the leader cluster. </summary>
        public string LeaderClusterResourceId { get; }
        /// <summary> The name of the attached database configuration cluster. </summary>
        public string AttachedDatabaseConfigurationName { get; }
        /// <summary> The principals modification kind of the database. </summary>
        public PrincipalsModificationKind? PrincipalsModificationKind { get; }
    }
}
