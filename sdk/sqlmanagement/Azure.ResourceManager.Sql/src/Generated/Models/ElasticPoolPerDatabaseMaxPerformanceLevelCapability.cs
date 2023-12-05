// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The max per-database performance level capability. </summary>
    public partial class ElasticPoolPerDatabaseMaxPerformanceLevelCapability
    {
        /// <summary> Initializes a new instance of <see cref="ElasticPoolPerDatabaseMaxPerformanceLevelCapability"/>. </summary>
        internal ElasticPoolPerDatabaseMaxPerformanceLevelCapability()
        {
            SupportedPerDatabaseMinPerformanceLevels = new ChangeTrackingList<ElasticPoolPerDatabaseMinPerformanceLevelCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ElasticPoolPerDatabaseMaxPerformanceLevelCapability"/>. </summary>
        /// <param name="limit"> The maximum performance level per database. </param>
        /// <param name="unit"> Unit type used to measure performance level. </param>
        /// <param name="supportedPerDatabaseMinPerformanceLevels"> The list of supported min database performance levels. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal ElasticPoolPerDatabaseMaxPerformanceLevelCapability(double? limit, PerformanceLevelUnit? unit, IReadOnlyList<ElasticPoolPerDatabaseMinPerformanceLevelCapability> supportedPerDatabaseMinPerformanceLevels, SqlCapabilityStatus? status, string reason)
        {
            Limit = limit;
            Unit = unit;
            SupportedPerDatabaseMinPerformanceLevels = supportedPerDatabaseMinPerformanceLevels;
            Status = status;
            Reason = reason;
        }

        /// <summary> The maximum performance level per database. </summary>
        public double? Limit { get; }
        /// <summary> Unit type used to measure performance level. </summary>
        public PerformanceLevelUnit? Unit { get; }
        /// <summary> The list of supported min database performance levels. </summary>
        public IReadOnlyList<ElasticPoolPerDatabaseMinPerformanceLevelCapability> SupportedPerDatabaseMinPerformanceLevels { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
