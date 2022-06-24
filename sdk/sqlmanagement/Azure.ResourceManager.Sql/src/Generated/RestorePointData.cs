// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the RestorePoint data model. </summary>
    public partial class RestorePointData : ResourceData
    {
        /// <summary> Initializes a new instance of RestorePointData. </summary>
        public RestorePointData()
        {
        }

        /// <summary> Initializes a new instance of RestorePointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="restorePointType"> The type of restore point. </param>
        /// <param name="earliestRestoreOn"> The earliest time to which this database can be restored. </param>
        /// <param name="restorePointCreateOn"> The time the backup was taken. </param>
        /// <param name="restorePointLabel"> The label of restore point for backup request by user. </param>
        internal RestorePointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, RestorePointType? restorePointType, DateTimeOffset? earliestRestoreOn, DateTimeOffset? restorePointCreateOn, string restorePointLabel) : base(id, name, resourceType, systemData)
        {
            Location = location;
            RestorePointType = restorePointType;
            EarliestRestoreOn = earliestRestoreOn;
            RestorePointCreateOn = restorePointCreateOn;
            RestorePointLabel = restorePointLabel;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The type of restore point. </summary>
        public RestorePointType? RestorePointType { get; }
        /// <summary> The earliest time to which this database can be restored. </summary>
        public DateTimeOffset? EarliestRestoreOn { get; }
        /// <summary> The time the backup was taken. </summary>
        public DateTimeOffset? RestorePointCreateOn { get; }
        /// <summary> The label of restore point for backup request by user. </summary>
        public string RestorePointLabel { get; }
    }
}
