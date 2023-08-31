// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Metrics Response. </summary>
    public partial class MetricsResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricsResponse"/>. </summary>
        internal MetricsResponse()
        {
            Series = new ChangeTrackingList<MetricsResponseSeriesItem>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricsResponse"/>. </summary>
        /// <param name="dateTimeBegin"></param>
        /// <param name="dateTimeEnd"></param>
        /// <param name="granularity"></param>
        /// <param name="series"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricsResponse(DateTimeOffset? dateTimeBegin, DateTimeOffset? dateTimeEnd, MetricsResponseGranularity? granularity, IReadOnlyList<MetricsResponseSeriesItem> series, Dictionary<string, BinaryData> rawData)
        {
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            Granularity = granularity;
            Series = series;
            _rawData = rawData;
        }

        /// <summary> Gets the date time begin. </summary>
        public DateTimeOffset? DateTimeBegin { get; }
        /// <summary> Gets the date time end. </summary>
        public DateTimeOffset? DateTimeEnd { get; }
        /// <summary> Gets the granularity. </summary>
        public MetricsResponseGranularity? Granularity { get; }
        /// <summary> Gets the series. </summary>
        public IReadOnlyList<MetricsResponseSeriesItem> Series { get; }
    }
}
