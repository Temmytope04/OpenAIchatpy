// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for backup item. Workload-specific backup items are derived from this class. </summary>
    public partial class WorkloadItemResource : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadItemResource"/>. </summary>
        /// <param name="location"> The location. </param>
        public WorkloadItemResource(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadItemResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// WorkloadItemResource properties
        /// Please note <see cref="WorkloadItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VmWorkloadItem"/>, <see cref="VmWorkloadSapAseDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapAseSystemWorkloadItem"/>, <see cref="VmWorkloadSapHanaDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapHanaSystemWorkloadItem"/>, <see cref="VmWorkloadSqlDatabaseWorkloadItem"/> and <see cref="VmWorkloadSqlInstanceWorkloadItem"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadItemResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WorkloadItem properties, ETag? eTag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadItemResource"/> for deserialization. </summary>
        internal WorkloadItemResource()
        {
        }

        /// <summary>
        /// WorkloadItemResource properties
        /// Please note <see cref="WorkloadItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VmWorkloadItem"/>, <see cref="VmWorkloadSapAseDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapAseSystemWorkloadItem"/>, <see cref="VmWorkloadSapHanaDatabaseWorkloadItem"/>, <see cref="VmWorkloadSapHanaSystemWorkloadItem"/>, <see cref="VmWorkloadSqlDatabaseWorkloadItem"/> and <see cref="VmWorkloadSqlInstanceWorkloadItem"/>.
        /// </summary>
        public WorkloadItem Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
