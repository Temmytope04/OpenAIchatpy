// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseRecoverableSqlPool data model.
    /// A recoverable sql pool
    /// </summary>
    public partial class SynapseRecoverableSqlPoolData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynapseRecoverableSqlPoolData"/>. </summary>
        public SynapseRecoverableSqlPoolData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseRecoverableSqlPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="edition"> The edition of the database. </param>
        /// <param name="serviceLevelObjective"> The service level objective name of the database. </param>
        /// <param name="elasticPoolName"> The elastic pool name of the database. </param>
        /// <param name="lastAvailableBackupOn"> The last available backup date of the database (ISO8601 format). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseRecoverableSqlPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string edition, string serviceLevelObjective, string elasticPoolName, DateTimeOffset? lastAvailableBackupOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Edition = edition;
            ServiceLevelObjective = serviceLevelObjective;
            ElasticPoolName = elasticPoolName;
            LastAvailableBackupOn = lastAvailableBackupOn;
            _rawData = rawData;
        }

        /// <summary> The edition of the database. </summary>
        public string Edition { get; }
        /// <summary> The service level objective name of the database. </summary>
        public string ServiceLevelObjective { get; }
        /// <summary> The elastic pool name of the database. </summary>
        public string ElasticPoolName { get; }
        /// <summary> The last available backup date of the database (ISO8601 format). </summary>
        public DateTimeOffset? LastAvailableBackupOn { get; }
    }
}
