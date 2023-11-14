// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DetectionIncidentResultQuery. </summary>
    internal partial class DetectionIncidentResultQuery
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DetectionIncidentResultQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        public DetectionIncidentResultQuery(DateTimeOffset startTime, DateTimeOffset endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Initializes a new instance of <see cref="DetectionIncidentResultQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="filter"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectionIncidentResultQuery(DateTimeOffset startTime, DateTimeOffset endTime, DetectionIncidentFilterCondition filter, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartTime = startTime;
            EndTime = endTime;
            Filter = filter;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectionIncidentResultQuery"/> for deserialization. </summary>
        internal DetectionIncidentResultQuery()
        {
        }

        /// <summary> start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> Gets or sets the filter. </summary>
        public DetectionIncidentFilterCondition Filter { get; set; }
    }
}
