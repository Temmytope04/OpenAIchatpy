// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Class representing a Traffic Manager HeatMap query experience properties. </summary>
    public partial class TrafficManagerHeatMapQueryExperience
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerHeatMapQueryExperience"/>. </summary>
        /// <param name="endpointId"> The id of the endpoint from the 'endpoints' array which these queries were routed to. </param>
        /// <param name="queryCount"> The number of queries originating from this location. </param>
        public TrafficManagerHeatMapQueryExperience(int endpointId, int queryCount)
        {
            EndpointId = endpointId;
            QueryCount = queryCount;
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerHeatMapQueryExperience"/>. </summary>
        /// <param name="endpointId"> The id of the endpoint from the 'endpoints' array which these queries were routed to. </param>
        /// <param name="queryCount"> The number of queries originating from this location. </param>
        /// <param name="latency"> The latency experienced by queries originating from this location. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerHeatMapQueryExperience(int endpointId, int queryCount, double? latency, Dictionary<string, BinaryData> rawData)
        {
            EndpointId = endpointId;
            QueryCount = queryCount;
            Latency = latency;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerHeatMapQueryExperience"/> for deserialization. </summary>
        internal TrafficManagerHeatMapQueryExperience()
        {
        }

        /// <summary> The id of the endpoint from the 'endpoints' array which these queries were routed to. </summary>
        public int EndpointId { get; set; }
        /// <summary> The number of queries originating from this location. </summary>
        public int QueryCount { get; set; }
        /// <summary> The latency experienced by queries originating from this location. </summary>
        public double? Latency { get; set; }
    }
}
