// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A class representing follower database request. </summary>
    public partial class FollowerDatabaseDefinition
    {
        /// <summary> Initializes a new instance of FollowerDatabaseDefinition. </summary>
        /// <param name="clusterResourceId"> Resource id of the cluster that follows a database owned by this cluster. </param>
        /// <param name="attachedDatabaseConfigurationName"> Resource name of the attached database configuration in the follower cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterResourceId"/> or <paramref name="attachedDatabaseConfigurationName"/> is null. </exception>
        public FollowerDatabaseDefinition(string clusterResourceId, string attachedDatabaseConfigurationName)
        {
            if (clusterResourceId == null)
            {
                throw new ArgumentNullException(nameof(clusterResourceId));
            }
            if (attachedDatabaseConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(attachedDatabaseConfigurationName));
            }

            ClusterResourceId = clusterResourceId;
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
        }

        /// <summary> Initializes a new instance of FollowerDatabaseDefinition. </summary>
        /// <param name="clusterResourceId"> Resource id of the cluster that follows a database owned by this cluster. </param>
        /// <param name="attachedDatabaseConfigurationName"> Resource name of the attached database configuration in the follower cluster. </param>
        /// <param name="databaseName"> The database name owned by this cluster that was followed. * in case following all databases. </param>
        internal FollowerDatabaseDefinition(string clusterResourceId, string attachedDatabaseConfigurationName, string databaseName)
        {
            ClusterResourceId = clusterResourceId;
            AttachedDatabaseConfigurationName = attachedDatabaseConfigurationName;
            DatabaseName = databaseName;
        }

        /// <summary> Resource id of the cluster that follows a database owned by this cluster. </summary>
        public string ClusterResourceId { get; set; }
        /// <summary> Resource name of the attached database configuration in the follower cluster. </summary>
        public string AttachedDatabaseConfigurationName { get; set; }
        /// <summary> The database name owned by this cluster that was followed. * in case following all databases. </summary>
        public string DatabaseName { get; }
    }
}
