// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeTextJobState. </summary>
    internal partial class AnalyzeTextJobState : JobState
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextJobState"/>. </summary>
        /// <param name="createdDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <param name="tasks"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="tasks"/> is null. </exception>
        internal AnalyzeTextJobState(DateTimeOffset createdDateTime, string jobId, DateTimeOffset lastUpdatedDateTime, TextAnalyticsOperationStatus status, AnalyzeTasks tasks) : base(createdDateTime, jobId, lastUpdatedDateTime, status)
        {
            Argument.AssertNotNull(jobId, nameof(jobId));
            Argument.AssertNotNull(tasks, nameof(tasks));

            Tasks = tasks;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextJobState"/>. </summary>
        /// <param name="displayName"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="expirationDateTime"></param>
        /// <param name="jobId"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="status"></param>
        /// <param name="errors"></param>
        /// <param name="nextLink"></param>
        /// <param name="tasks"></param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeTextJobState(string displayName, DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, string jobId, DateTimeOffset lastUpdatedDateTime, TextAnalyticsOperationStatus status, IReadOnlyList<Error> errors, string nextLink, AnalyzeTasks tasks, TextDocumentBatchStatistics statistics, Dictionary<string, BinaryData> rawData) : base(displayName, createdDateTime, expirationDateTime, jobId, lastUpdatedDateTime, status, errors, nextLink, rawData)
        {
            Tasks = tasks;
            Statistics = statistics;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextJobState"/> for deserialization. </summary>
        internal AnalyzeTextJobState()
        {
        }

        /// <summary> Gets the tasks. </summary>
        public AnalyzeTasks Tasks { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public TextDocumentBatchStatistics Statistics { get; }
    }
}
