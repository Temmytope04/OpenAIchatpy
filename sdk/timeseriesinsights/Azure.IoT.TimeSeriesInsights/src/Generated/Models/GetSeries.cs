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
    /// <summary> Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span. </summary>
    internal partial class GetSeries
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetSeries"/>. </summary>
        /// <param name="timeSeriesIdInternal"> A single Time Series ID value that uniquely identifies a single time series instance (e.g. a device). Note that a single Time Series ID can be composite if multiple properties are specified as Time Series ID at environment creation time. The position and type of values must match Time Series ID properties specified on the environment and returned by Get Model Setting API. Cannot be null. </param>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <param name="filter"> Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND'ed with filter in each variable. Example: "$event.Status.String='Good'". Optional. </param>
        /// <param name="projectedVariables"> Selected variables that needs to be projected in the query result. When it is null or not set, all the variables from inlineVariables and time series type in the model are returned. Can be null. </param>
        /// <param name="inlineVariables">
        /// Optional inline variables apart from the ones already defined in the time series type in the model. When the inline variable name is the same name as in the model, the inline variable definition takes precedence. Can be null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </param>
        /// <param name="take"> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetSeries(IList<object> timeSeriesIdInternal, DateTimeRange searchSpan, TimeSeriesExpression filter, IList<string> projectedVariables, IDictionary<string, TimeSeriesVariable> inlineVariables, int? take, Dictionary<string, BinaryData> rawData)
        {
            TimeSeriesIdInternal = timeSeriesIdInternal;
            SearchSpan = searchSpan;
            Filter = filter;
            ProjectedVariables = projectedVariables;
            InlineVariables = inlineVariables;
            Take = take;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetSeries"/> for deserialization. </summary>
        internal GetSeries()
        {
        }
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND'ed with filter in each variable. Example: "$event.Status.String='Good'". Optional. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Selected variables that needs to be projected in the query result. When it is null or not set, all the variables from inlineVariables and time series type in the model are returned. Can be null. </summary>
        public IList<string> ProjectedVariables { get; }
        /// <summary>
        /// Optional inline variables apart from the ones already defined in the time series type in the model. When the inline variable name is the same name as in the model, the inline variable definition takes precedence. Can be null.
        /// Please note <see cref="TimeSeriesVariable"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AggregateVariable"/>, <see cref="CategoricalVariable"/> and <see cref="NumericVariable"/>.
        /// </summary>
        public IDictionary<string, TimeSeriesVariable> InlineVariables { get; }
        /// <summary> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </summary>
        public int? Take { get; set; }
    }
}
