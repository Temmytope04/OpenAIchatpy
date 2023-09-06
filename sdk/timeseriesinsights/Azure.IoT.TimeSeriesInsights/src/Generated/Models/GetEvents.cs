// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Get Events query. Allows to retrieve raw events for a given Time Series ID and search span. </summary>
    internal partial class GetEvents
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetEvents"/>. </summary>
        /// <param name="timeSeriesIdInternal"> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </param>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <param name="filter"> Optional top-level filter for the query which will be applied to all the variables in the query. Example: "$event.Status.String='Good'".  Can be null. </param>
        /// <param name="projectedProperties"> Projected properties is an array of properties which you want to project. These properties must appear in the events; otherwise, they are not returned. </param>
        /// <param name="take"> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetEvents(IList<object> timeSeriesIdInternal, DateTimeRange searchSpan, TimeSeriesExpression filter, IList<TimeSeriesInsightsEventProperty> projectedProperties, int? take, Dictionary<string, BinaryData> rawData)
        {
            TimeSeriesIdInternal = timeSeriesIdInternal;
            SearchSpan = searchSpan;
            Filter = filter;
            ProjectedProperties = projectedProperties;
            Take = take;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetEvents"/> for deserialization. </summary>
        internal GetEvents()
        {
        }
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Optional top-level filter for the query which will be applied to all the variables in the query. Example: "$event.Status.String='Good'".  Can be null. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Projected properties is an array of properties which you want to project. These properties must appear in the events; otherwise, they are not returned. </summary>
        public IList<TimeSeriesInsightsEventProperty> ProjectedProperties { get; }
        /// <summary> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </summary>
        public int? Take { get; set; }
    }
}
