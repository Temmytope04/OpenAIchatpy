// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity SQL source. </summary>
    public partial class SqlSource : TabularSource
    {
        /// <summary> Initializes a new instance of SqlSource. </summary>
        public SqlSource()
        {
            StoredProcedureParameters = new ChangeTrackingDictionary<string, StoredProcedureParameter>();
            Type = "SqlSource";
        }

        /// <summary> Initializes a new instance of SqlSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </param>
        /// <param name="sqlReaderQuery"> SQL reader query. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlReaderStoredProcedureName"> Name of the stored procedure for a SQL Database source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </param>
        /// <param name="isolationLevel"> Specifies the transaction locking behavior for the SQL source. Allowed values: ReadCommitted/ReadUncommitted/RepeatableRead/Serializable/Snapshot. The default value is ReadCommitted. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for Sql read in parallel. Possible values include: &quot;None&quot;, &quot;PhysicalPartitionsOfTable&quot;, &quot;DynamicRange&quot;. </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for Sql source partitioning. </param>
        internal SqlSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, IList<AdditionalColumns> additionalColumns, object sqlReaderQuery, object sqlReaderStoredProcedureName, IDictionary<string, StoredProcedureParameter> storedProcedureParameters, object isolationLevel, object partitionOption, SqlPartitionSettings partitionSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            SqlReaderQuery = sqlReaderQuery;
            SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            IsolationLevel = isolationLevel;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            Type = type ?? "SqlSource";
        }

        /// <summary> SQL reader query. Type: string (or Expression with resultType string). </summary>
        public object SqlReaderQuery { get; set; }
        /// <summary> Name of the stored procedure for a SQL Database source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string). </summary>
        public object SqlReaderStoredProcedureName { get; set; }
        /// <summary> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </summary>
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters { get; }
        /// <summary> Specifies the transaction locking behavior for the SQL source. Allowed values: ReadCommitted/ReadUncommitted/RepeatableRead/Serializable/Snapshot. The default value is ReadCommitted. Type: string (or Expression with resultType string). </summary>
        public object IsolationLevel { get; set; }
        /// <summary> The partition mechanism that will be used for Sql read in parallel. Possible values include: &quot;None&quot;, &quot;PhysicalPartitionsOfTable&quot;, &quot;DynamicRange&quot;. </summary>
        public object PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for Sql source partitioning. </summary>
        public SqlPartitionSettings PartitionSettings { get; set; }
    }
}
