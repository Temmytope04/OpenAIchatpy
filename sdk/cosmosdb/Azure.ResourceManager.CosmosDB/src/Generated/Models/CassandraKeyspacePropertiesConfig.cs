// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraKeyspacePropertiesConfig. </summary>
    public partial class CassandraKeyspacePropertiesConfig : CosmosDBBaseConfig
    {
        /// <summary> Initializes a new instance of CassandraKeyspacePropertiesConfig. </summary>
        public CassandraKeyspacePropertiesConfig()
        {
        }

        /// <summary> Initializes a new instance of CassandraKeyspacePropertiesConfig. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        internal CassandraKeyspacePropertiesConfig(int? throughput, AutoscaleSettings autoscaleSettings) : base(throughput, autoscaleSettings)
        {
        }
    }
}
