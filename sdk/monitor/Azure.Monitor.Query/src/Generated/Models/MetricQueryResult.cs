// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The response to a metrics query. </summary>
    public partial class MetricQueryResult
    {
        /// <summary> Initializes a new instance of MetricQueryResult. </summary>
        /// <param name="Timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="metrics"> the value of the collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="Timespan"/> or <paramref name="metrics"/> is null. </exception>
        internal MetricQueryResult(string Timespan, IEnumerable<Metric> metrics)
        {
            if (Timespan == null)
            {
                throw new ArgumentNullException(nameof(Timespan));
            }
            if (metrics == null)
            {
                throw new ArgumentNullException(nameof(metrics));
            }

            _timespan = Timespan;
            Metrics = metrics.ToList();
        }

        /// <summary> Initializes a new instance of MetricQueryResult. </summary>
        /// <param name="cost"> The integer value representing the cost of the query, for data case. </param>
        /// <param name="Timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="resourceRegion"> The region of the resource been queried for metrics. </param>
        /// <param name="metrics"> the value of the collection. </param>
        internal MetricQueryResult(int? cost, string Timespan, TimeSpan? interval, string @namespace, string resourceRegion, IReadOnlyList<Metric> metrics)
        {
            Cost = cost;
            _timespan = Timespan;
            Interval = interval;
            Namespace = @namespace;
            ResourceRegion = resourceRegion;
            Metrics = metrics;
        }

        /// <summary> The integer value representing the cost of the query, for data case. </summary>
        public int? Cost { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The namespace of the metrics been queried. </summary>
        public string Namespace { get; }
    }
}
