// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary> A class representing the PostgreSqlFlexibleServer data model. </summary>
    public partial class PostgreSqlFlexibleServerData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerData. </summary>
        /// <param name="location"> The location. </param>
        public PostgreSqlFlexibleServerData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="administratorLogin"> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The administrator login password (required for server creation). </param>
        /// <param name="version"> PostgreSQL Server version. </param>
        /// <param name="minorVersion"> The minor version of the server. </param>
        /// <param name="state"> A state of a server that is visible to user. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="storage"> Storage properties of a server. </param>
        /// <param name="backup"> Backup properties of a server. </param>
        /// <param name="network"> Network properties of a server. </param>
        /// <param name="highAvailability"> High availability properties of a server. </param>
        /// <param name="maintenanceWindow"> Maintenance window properties of a server. </param>
        /// <param name="sourceServerResourceId"> The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;. </param>
        /// <param name="pointInTimeUTC"> Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;. </param>
        /// <param name="availabilityZone"> availability zone information of the server. </param>
        /// <param name="createMode"> The mode to create a new PostgreSQL server. </param>
        internal PostgreSqlFlexibleServerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PostgreSqlFlexibleServerSku sku, string administratorLogin, string administratorLoginPassword, PostgreSqlFlexibleServerVersion? version, string minorVersion, PostgreSqlFlexibleServerState? state, string fullyQualifiedDomainName, PostgreSqlFlexibleServerStorage storage, PostgreSqlFlexibleServerBackupProperties backup, PostgreSqlFlexibleServerNetwork network, PostgreSqlFlexibleServerHighAvailability highAvailability, PostgreSqlFlexibleServerMaintenanceWindow maintenanceWindow, ResourceIdentifier sourceServerResourceId, DateTimeOffset? pointInTimeUTC, string availabilityZone, PostgreSqlFlexibleServerCreateMode? createMode) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            MinorVersion = minorVersion;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            Storage = storage;
            Backup = backup;
            Network = network;
            HighAvailability = highAvailability;
            MaintenanceWindow = maintenanceWindow;
            SourceServerResourceId = sourceServerResourceId;
            PointInTimeUTC = pointInTimeUTC;
            AvailabilityZone = availabilityZone;
            CreateMode = createMode;
        }

        /// <summary> The SKU (pricing tier) of the server. </summary>
        public PostgreSqlFlexibleServerSku Sku { get; set; }
        /// <summary> The administrator&apos;s login name of a server. Can only be specified when the server is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for server creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> PostgreSQL Server version. </summary>
        public PostgreSqlFlexibleServerVersion? Version { get; set; }
        /// <summary> The minor version of the server. </summary>
        public string MinorVersion { get; }
        /// <summary> A state of a server that is visible to user. </summary>
        public PostgreSqlFlexibleServerState? State { get; }
        /// <summary> The fully qualified domain name of a server. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> Storage properties of a server. </summary>
        internal PostgreSqlFlexibleServerStorage Storage { get; set; }
        /// <summary> Max storage allowed for a server. </summary>
        public int? StorageSizeInGB
        {
            get => Storage is null ? default : Storage.StorageSizeInGB;
            set
            {
                if (Storage is null)
                    Storage = new PostgreSqlFlexibleServerStorage();
                Storage.StorageSizeInGB = value;
            }
        }

        /// <summary> Backup properties of a server. </summary>
        public PostgreSqlFlexibleServerBackupProperties Backup { get; set; }
        /// <summary> Network properties of a server. </summary>
        public PostgreSqlFlexibleServerNetwork Network { get; set; }
        /// <summary> High availability properties of a server. </summary>
        public PostgreSqlFlexibleServerHighAvailability HighAvailability { get; set; }
        /// <summary> Maintenance window properties of a server. </summary>
        public PostgreSqlFlexibleServerMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> The source server resource ID to restore from. It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;. </summary>
        public ResourceIdentifier SourceServerResourceId { get; set; }
        /// <summary> Restore point creation time (ISO8601 format), specifying the time to restore from. It&apos;s required when &apos;createMode&apos; is &apos;PointInTimeRestore&apos;. </summary>
        public DateTimeOffset? PointInTimeUTC { get; set; }
        /// <summary> availability zone information of the server. </summary>
        public string AvailabilityZone { get; set; }
        /// <summary> The mode to create a new PostgreSQL server. </summary>
        public PostgreSqlFlexibleServerCreateMode? CreateMode { get; set; }
    }
}
