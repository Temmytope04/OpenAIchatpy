// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the MigrateMySqlStatus data model. </summary>
    public partial class MigrateMySqlStatusData : ResourceData
    {
        /// <summary> Initializes a new instance of MigrateMySqlStatusData. </summary>
        public MigrateMySqlStatusData()
        {
        }

        /// <summary> Initializes a new instance of MigrateMySqlStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="migrationOperationStatus"> Status of the migration task. </param>
        /// <param name="operationId"> Operation ID for the migration task. </param>
        /// <param name="isLocalMySqlEnabled"> True if the web app has in app MySql enabled. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal MigrateMySqlStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppServiceOperationStatus? migrationOperationStatus, string operationId, bool? isLocalMySqlEnabled, string kind) : base(id, name, resourceType, systemData)
        {
            MigrationOperationStatus = migrationOperationStatus;
            OperationId = operationId;
            IsLocalMySqlEnabled = isLocalMySqlEnabled;
            Kind = kind;
        }

        /// <summary> Status of the migration task. </summary>
        public AppServiceOperationStatus? MigrationOperationStatus { get; }
        /// <summary> Operation ID for the migration task. </summary>
        public string OperationId { get; }
        /// <summary> True if the web app has in app MySql enabled. </summary>
        public bool? IsLocalMySqlEnabled { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
