// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to get the event schema of all events within a given search span. </summary>
    internal partial class GetEventSchemaRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetEventSchemaRequest"/>. </summary>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchSpan"/> is null. </exception>
        public GetEventSchemaRequest(DateTimeRange searchSpan)
        {
            Argument.AssertNotNull(searchSpan, nameof(searchSpan));

            SearchSpan = searchSpan;
        }

        /// <summary> Initializes a new instance of <see cref="GetEventSchemaRequest"/>. </summary>
        /// <param name="searchSpan"> The range of time on which the query is executed. Cannot be null. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetEventSchemaRequest(DateTimeRange searchSpan, Dictionary<string, BinaryData> rawData)
        {
            SearchSpan = searchSpan;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetEventSchemaRequest"/> for deserialization. </summary>
        internal GetEventSchemaRequest()
        {
        }

        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
    }
}
