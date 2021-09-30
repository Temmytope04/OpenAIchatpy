// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class SearchModelFactory
    {

        /// <summary> Initializes a new instance of AnswerResult. </summary>
        /// <param name="score"> The score value represents how relevant the answer is to the the query relative to other answers returned for the query. </param>
        /// <param name="key"> The key of the document the answer was extracted from. </param>
        /// <param name="text"> The text passage extracted from the document contents as the answer. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted text phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.AnswerResult"/> instance for mocking. </returns>
        public static AnswerResult AnswerResult(double? score = null, string key = null, string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new AnswerResult(score, key, text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of CaptionResult. </summary>
        /// <param name="text"> A representative text passage extracted from the document most relevant to the search query. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.CaptionResult"/> instance for mocking. </returns>
        public static CaptionResult CaptionResult(string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new CaptionResult(text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of AutocompleteResults. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <returns> A new <see cref="Models.AutocompleteResults"/> instance for mocking. </returns>
        public static AutocompleteResults AutocompleteResults(double? coverage = null, IEnumerable<AutocompleteItem> results = null)
        {
            results ??= new List<AutocompleteItem>();

            return new AutocompleteResults(coverage, results?.ToList());
        }

        /// <summary> Initializes a new instance of SearchIndexerStatus. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="lastResult"> The result of the most recent or an in-progress indexer execution. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchIndexerStatus"/> instance for mocking. </returns>
        public static SearchIndexerStatus SearchIndexerStatus(IndexerStatus status = default, IndexerExecutionResult lastResult = null, IEnumerable<IndexerExecutionResult> executionHistory = null, SearchIndexerLimits limits = null)
        {
            executionHistory ??= new List<IndexerExecutionResult>();

            return new SearchIndexerStatus(status, lastResult, executionHistory?.ToList(), limits);
        }

        /// <summary> Initializes a new instance of IndexerExecutionResult. </summary>
        /// <param name="status"> The outcome of this indexer execution. </param>
        /// <param name="statusDetail"> The outcome of this indexer execution. </param>
        /// <param name="currentState"> All of the state that defines and dictates the indexer&apos;s current execution. </param>
        /// <param name="errorMessage"> The error message indicating the top-level error, if any. </param>
        /// <param name="startTime"> The start time of this indexer execution. </param>
        /// <param name="endTime"> The end time of this indexer execution, if the execution has already completed. </param>
        /// <param name="errors"> The item-level indexing errors. </param>
        /// <param name="warnings"> The item-level indexing warnings. </param>
        /// <param name="itemCount"> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </param>
        /// <param name="failedItemCount"> The number of items that failed to be indexed during this indexer execution. </param>
        /// <param name="initialTrackingState"> Change tracking state with which an indexer execution started. </param>
        /// <param name="finalTrackingState"> Change tracking state with which an indexer execution finished. </param>
        /// <returns> A new <see cref="Indexes.Models.IndexerExecutionResult"/> instance for mocking. </returns>
        public static IndexerExecutionResult IndexerExecutionResult(IndexerExecutionStatus status = default, IndexerExecutionStatusDetail? statusDetail = null, IndexerCurrentState currentState = null, string errorMessage = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, IEnumerable<SearchIndexerError> errors = null, IEnumerable<SearchIndexerWarning> warnings = null, int itemCount = default, int failedItemCount = default, string initialTrackingState = null, string finalTrackingState = null)
        {
            errors ??= new List<SearchIndexerError>();
            warnings ??= new List<SearchIndexerWarning>();

            return new IndexerExecutionResult(status, statusDetail, currentState, errorMessage, startTime, endTime, errors?.ToList(), warnings?.ToList(), itemCount, failedItemCount, initialTrackingState, finalTrackingState);
        }

        /// <summary> Initializes a new instance of IndexerCurrentState. </summary>
        /// <param name="mode"> The mode the indexer is running in. </param>
        /// <param name="allDocsInitialChangeTrackingState"> Change tracking state used when indexing starts on all documents in the datasource. </param>
        /// <param name="allDocsFinalChangeTrackingState"> Change tracking state value when indexing finishes on all documents in the datasource. </param>
        /// <param name="resetDocsInitialChangeTrackingState"> Change tracking state used when indexing starts on select, reset documents in the datasource. </param>
        /// <param name="resetDocsFinalChangeTrackingState"> Change tracking state value when indexing finishes on select, reset documents in the datasource. </param>
        /// <param name="resetDocumentKeys"> The list of document keys that have been reset. The document key is the document&apos;s unique identifier for the data in the search index. The indexer will prioritize selectively re-ingesting these keys. </param>
        /// <param name="resetDatasourceDocumentIds"> The list of datasource document ids that have been reset. The datasource document id is the unique identifier for the data in the datasource. The indexer will prioritize selectively re-ingesting these ids. </param>
        /// <returns> A new <see cref="Indexes.Models.IndexerCurrentState"/> instance for mocking. </returns>
        public static IndexerCurrentState IndexerCurrentState(IndexingMode? mode = null, string allDocsInitialChangeTrackingState = null, string allDocsFinalChangeTrackingState = null, string resetDocsInitialChangeTrackingState = null, string resetDocsFinalChangeTrackingState = null, IEnumerable<string> resetDocumentKeys = null, IEnumerable<string> resetDatasourceDocumentIds = null)
        {
            resetDocumentKeys ??= new List<string>();
            resetDatasourceDocumentIds ??= new List<string>();

            return new IndexerCurrentState(mode, allDocsInitialChangeTrackingState, allDocsFinalChangeTrackingState, resetDocsInitialChangeTrackingState, resetDocsFinalChangeTrackingState, resetDocumentKeys?.ToList(), resetDatasourceDocumentIds?.ToList());
        }
    }
}
