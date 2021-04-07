// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    /// <summary> Parameters for filtering, sorting, faceting, paging, and other search query behaviors. </summary>
    public partial class SearchOptions
    {
        /// <summary> Initializes a new instance of SearchOptions. </summary>
        public SearchOptions()
        {
            Facets = new ChangeTrackingList<string>();
            ScoringParameters = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SearchOptions. </summary>
        /// <param name="includeTotalCount"> A value that specifies whether to fetch the total count of results. Default is false. Setting this value to true may have a performance impact. Note that the count returned is an approximation. </param>
        /// <param name="facets"> The list of facet expressions to apply to the search query. Each facet expression contains a field name, optionally followed by a comma-separated list of name:value pairs. </param>
        /// <param name="filter"> The OData $filter expression to apply to the search query. </param>
        /// <param name="highlightFieldsRaw"> The comma-separated list of field names to use for hit highlights. Only searchable fields can be used for hit highlighting. </param>
        /// <param name="highlightPostTag"> A string tag that is appended to hit highlights. Must be set with highlightPreTag. Default is &amp;lt;/em&amp;gt;. </param>
        /// <param name="highlightPreTag"> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. Default is &amp;lt;em&amp;gt;. </param>
        /// <param name="minimumCoverage"> A number between 0 and 100 indicating the percentage of the index that must be covered by a search query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 100. </param>
        /// <param name="orderByRaw"> The comma-separated list of OData $orderby expressions by which to sort the results. Each expression can be either a field name or a call to either the geo.distance() or the search.score() functions. Each expression can be followed by asc to indicate ascending, or desc to indicate descending. The default is ascending order. Ties will be broken by the match scores of documents. If no $orderby is specified, the default sort order is descending by document match score. There can be at most 32 $orderby clauses. </param>
        /// <param name="queryType"> A value that specifies the syntax of the search query. The default is &apos;simple&apos;. Use &apos;full&apos; if your query uses the Lucene query syntax. </param>
        /// <param name="scoringStatistics"> A value that specifies whether we want to calculate scoring statistics (such as document frequency) globally for more consistent scoring, or locally, for lower latency. The default is &apos;local&apos;. Use &apos;global&apos; to aggregate scoring statistics globally before scoring. Using global scoring statistics can increase latency of search queries. </param>
        /// <param name="sessionId"> A value to be used to create a sticky session, which can help getting more consistent results. As long as the same sessionId is used, a best-effort attempt will be made to target the same replica set. Be wary that reusing the same sessionID values repeatedly can interfere with the load balancing of the requests across replicas and adversely affect the performance of the search service. The value used as sessionId cannot start with a &apos;_&apos; character. </param>
        /// <param name="scoringParameters"> The list of parameter values to be used in scoring functions (for example, referencePointParameter) using the format name-values. For example, if the scoring profile defines a function with a parameter called &apos;mylocation&apos; the parameter string would be &quot;mylocation--122.2,44.8&quot; (without the quotes). </param>
        /// <param name="scoringProfile"> The name of a scoring profile to evaluate match scores for matching documents in order to sort the results. </param>
        /// <param name="searchText"> A full-text search query expression; Use &quot;*&quot; or omit this parameter to match all documents. </param>
        /// <param name="searchFieldsRaw"> The comma-separated list of field names to which to scope the full-text search. When using fielded search (fieldName:searchExpression) in a full Lucene query, the field names of each fielded search expression take precedence over any field names listed in this parameter. </param>
        /// <param name="searchMode"> A value that specifies whether any or all of the search terms must be matched in order to count the document as a match. </param>
        /// <param name="queryLanguage"> A value that specifies the language of the search query. </param>
        /// <param name="querySpeller"> A value that specified the type of the speller to use to spell-correct individual search query terms. </param>
        /// <param name="queryAnswer"> A value that specifies whether answers should be returned as part of the search response. </param>
        /// <param name="selectRaw"> The comma-separated list of fields to retrieve. If unspecified, all fields marked as retrievable in the schema are included. </param>
        /// <param name="skip"> The number of search results to skip. This value cannot be greater than 100,000. If you need to scan documents in sequence, but cannot use skip due to this limitation, consider using orderby on a totally-ordered key and filter with a range query instead. </param>
        /// <param name="size"> The number of search results to retrieve. This can be used in conjunction with $skip to implement client-side paging of search results. If results are truncated due to server-side paging, the response will include a continuation token that can be used to issue another Search request for the next page of results. </param>
        internal SearchOptions(bool? includeTotalCount, IList<string> facets, string filter, string highlightFieldsRaw, string highlightPostTag, string highlightPreTag, double? minimumCoverage, string orderByRaw, SearchQueryType? queryType, ScoringStatistics? scoringStatistics, string sessionId, IList<string> scoringParameters, string scoringProfile, string searchText, string searchFieldsRaw, SearchMode? searchMode, QueryLanguage? queryLanguage, QuerySpeller? querySpeller, QueryAnswer? queryAnswer, string selectRaw, int? skip, int? size)
        {
            IncludeTotalCount = includeTotalCount;
            Facets = facets;
            Filter = filter;
            HighlightFieldsRaw = highlightFieldsRaw;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            OrderByRaw = orderByRaw;
            QueryType = queryType;
            ScoringStatistics = scoringStatistics;
            SessionId = sessionId;
            ScoringParameters = scoringParameters;
            ScoringProfile = scoringProfile;
            SearchText = searchText;
            SearchFieldsRaw = searchFieldsRaw;
            SearchMode = searchMode;
            QueryLanguage = queryLanguage;
            QuerySpeller = querySpeller;
            QueryAnswer = queryAnswer;
            SelectRaw = selectRaw;
            Skip = skip;
            Size = size;
        }
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. Default is &amp;lt;/em&amp;gt;. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. Default is &amp;lt;em&amp;gt;. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by a search query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 100. </summary>
        public double? MinimumCoverage { get; set; }
        /// <summary> A value that specifies the syntax of the search query. The default is &apos;simple&apos;. Use &apos;full&apos; if your query uses the Lucene query syntax. </summary>
        public SearchQueryType? QueryType { get; set; }
        /// <summary> A value that specifies whether we want to calculate scoring statistics (such as document frequency) globally for more consistent scoring, or locally, for lower latency. The default is &apos;local&apos;. Use &apos;global&apos; to aggregate scoring statistics globally before scoring. Using global scoring statistics can increase latency of search queries. </summary>
        public ScoringStatistics? ScoringStatistics { get; set; }
        /// <summary> A value to be used to create a sticky session, which can help getting more consistent results. As long as the same sessionId is used, a best-effort attempt will be made to target the same replica set. Be wary that reusing the same sessionID values repeatedly can interfere with the load balancing of the requests across replicas and adversely affect the performance of the search service. The value used as sessionId cannot start with a &apos;_&apos; character. </summary>
        public string SessionId { get; set; }
        /// <summary> The name of a scoring profile to evaluate match scores for matching documents in order to sort the results. </summary>
        public string ScoringProfile { get; set; }
        /// <summary> A value that specifies whether any or all of the search terms must be matched in order to count the document as a match. </summary>
        public SearchMode? SearchMode { get; set; }
        /// <summary> The number of search results to skip. This value cannot be greater than 100,000. If you need to scan documents in sequence, but cannot use skip due to this limitation, consider using orderby on a totally-ordered key and filter with a range query instead. </summary>
        public int? Skip { get; set; }
    }
}
