// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Tables.Models
{
    /// <summary> The Metrics. </summary>
    public partial class TableMetrics
    {
        /// <summary> Initializes a new instance of TableMetrics. </summary>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Table service. </param>
        public TableMetrics(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of TableMetrics. </summary>
        /// <param name="version"> The version of Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Table service. </param>
        /// <param name="includeAPIs"> Indicates whether metrics should generate summary statistics for called API operations. </param>
        /// <param name="retentionPolicy"> The retention policy. </param>
        internal TableMetrics(string version, bool enabled, bool? includeAPIs, RetentionPolicy retentionPolicy)
        {
            Version = version;
            Enabled = enabled;
            IncludeAPIs = includeAPIs;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether metrics are enabled for the Table service. </summary>
        public bool Enabled { get; set; }
        /// <summary> Indicates whether metrics should generate summary statistics for called API operations. </summary>
        public bool? IncludeAPIs { get; set; }
        /// <summary> The retention policy. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
