// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Monitor.Query.Models;

namespace Azure.Monitor.Query
{
    public class MetricQueryOptions
    {
        /// <summary>
        /// Gets ot sets the start of the time range for the query.
        /// This value has to be used in combination with the <see cref="EndTime"/> or <see cref="Duration"/>.
        /// </summary>
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Gets ot sets the end of the time range for the query.
        /// This value has to be used in combination with the <see cref="StartTime"/> or <see cref="Duration"/>.
        /// </summary>
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Gets ot sets the duration that of the time range for the query.
        /// This value can be set on it's own or in combination with the <see cref="StartTime"/> or <see cref="EndTime"/>
        /// but not both.
        /// </summary>
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets ot sets the interval to sample metrics at.
        /// </summary>
        public TimeSpan? Interval { get; set; }

        /// <summary>
        /// Gets the list of metric aggregations to retrieve.
        /// </summary>
        public IList<MetricAggregationType> Aggregations { get; } = new List<MetricAggregationType>();

        /// <summary>
        /// Gets or sets the maximum number of records to retrieve. Valid only when <see cref="Filter"/> is specified. Defaults to <c>null</c>.
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the filter that is used to refine the set of metric data returned.
        /// Example:
        ///     Metric contains metadata A, B and C.
        ///
        ///     - Return all time series of C where A = a1 and B = b1 or b2:
        ///         <c>A eq 'a1' and B eq 'b1' or B eq 'b2' and C eq '*'</c>
        ///     - Invalid variant:
        ///         <c>A eq 'a1' and B eq 'b1' and C eq '*' or B = 'b2'</c>
        ///         This is invalid because the logical or operator cannot separate two different metadata names.
        ///     - Return all time series where A = a1, B = b1 and C = c1:
        ///         <c>A eq 'a1' and B eq 'b1' and C eq 'c1'</c>
        ///     - Return all time series where A = a1
        ///         <c>A eq 'a1' and B eq '*' and C eq '*'.</c>
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets ot sets the aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the metric namespace to query.
        /// </summary>
        public string MetricNamespace { get; set; }
    }
}
