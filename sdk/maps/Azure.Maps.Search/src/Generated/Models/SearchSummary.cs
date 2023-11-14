// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Summary object for a Search API response. </summary>
    internal partial class SearchSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchSummary"/>. </summary>
        internal SearchSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchSummary"/>. </summary>
        /// <param name="query"> The query parameter that was used to produce these search results. </param>
        /// <param name="queryType"> The type of query being returned: NEARBY or NON_NEAR. </param>
        /// <param name="queryTime"> Time spent resolving the query, in milliseconds. </param>
        /// <param name="resultCount"> Number of results in the response. </param>
        /// <param name="top"> Maximum number of responses that will be returned. </param>
        /// <param name="skip"> The starting offset of the returned Results within the full Result set. </param>
        /// <param name="totalResults"> The total number of Results found. </param>
        /// <param name="fuzzyLevel"> The maximum fuzzy level required to provide Results. </param>
        /// <param name="geoBiasInternal"> Indication when the internal search engine has applied a geospatial bias to improve the ranking of results.  In  some methods, this can be affected by setting the lat and lon parameters where available.  In other cases it is  purely internal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchSummary(string query, MapsQueryType? queryType, int? queryTime, int resultCount, int? top, int? skip, int? totalResults, int? fuzzyLevel, LatLongPairAbbreviated geoBiasInternal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Query = query;
            QueryType = queryType;
            QueryTime = queryTime;
            ResultCount = resultCount;
            Top = top;
            Skip = skip;
            TotalResults = totalResults;
            FuzzyLevel = fuzzyLevel;
            GeoBiasInternal = geoBiasInternal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The query parameter that was used to produce these search results. </summary>
        public string Query { get; }
        /// <summary> The type of query being returned: NEARBY or NON_NEAR. </summary>
        public MapsQueryType? QueryType { get; }
        /// <summary> Time spent resolving the query, in milliseconds. </summary>
        public int? QueryTime { get; }
        /// <summary> Maximum number of responses that will be returned. </summary>
        public int? Top { get; }
        /// <summary> The starting offset of the returned Results within the full Result set. </summary>
        public int? Skip { get; }
        /// <summary> The total number of Results found. </summary>
        public int? TotalResults { get; }
        /// <summary> The maximum fuzzy level required to provide Results. </summary>
        public int? FuzzyLevel { get; }
    }
}
