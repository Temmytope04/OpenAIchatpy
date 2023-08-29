// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Query parameters for listing runs. </summary>
    public partial class RunFilterParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RunFilterParameters"/>. </summary>
        /// <param name="lastUpdatedAfter"> The time at or after which the run event was updated in 'ISO 8601' format. </param>
        /// <param name="lastUpdatedBefore"> The time at or before which the run event was updated in 'ISO 8601' format. </param>
        public RunFilterParameters(DateTimeOffset lastUpdatedAfter, DateTimeOffset lastUpdatedBefore)
        {
            LastUpdatedAfter = lastUpdatedAfter;
            LastUpdatedBefore = lastUpdatedBefore;
            Filters = new ChangeTrackingList<RunQueryFilter>();
            OrderBy = new ChangeTrackingList<RunQueryOrderBy>();
        }

        /// <summary> Initializes a new instance of <see cref="RunFilterParameters"/>. </summary>
        /// <param name="continuationToken"> The continuation token for getting the next page of results. Null for first page. </param>
        /// <param name="lastUpdatedAfter"> The time at or after which the run event was updated in 'ISO 8601' format. </param>
        /// <param name="lastUpdatedBefore"> The time at or before which the run event was updated in 'ISO 8601' format. </param>
        /// <param name="filters"> List of filters. </param>
        /// <param name="orderBy"> List of OrderBy option. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RunFilterParameters(string continuationToken, DateTimeOffset lastUpdatedAfter, DateTimeOffset lastUpdatedBefore, IList<RunQueryFilter> filters, IList<RunQueryOrderBy> orderBy, Dictionary<string, BinaryData> rawData)
        {
            ContinuationToken = continuationToken;
            LastUpdatedAfter = lastUpdatedAfter;
            LastUpdatedBefore = lastUpdatedBefore;
            Filters = filters;
            OrderBy = orderBy;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunFilterParameters"/> for deserialization. </summary>
        internal RunFilterParameters()
        {
        }

        /// <summary> The continuation token for getting the next page of results. Null for first page. </summary>
        public string ContinuationToken { get; set; }
        /// <summary> The time at or after which the run event was updated in 'ISO 8601' format. </summary>
        public DateTimeOffset LastUpdatedAfter { get; }
        /// <summary> The time at or before which the run event was updated in 'ISO 8601' format. </summary>
        public DateTimeOffset LastUpdatedBefore { get; }
        /// <summary> List of filters. </summary>
        public IList<RunQueryFilter> Filters { get; }
        /// <summary> List of OrderBy option. </summary>
        public IList<RunQueryOrderBy> OrderBy { get; }
    }
}
