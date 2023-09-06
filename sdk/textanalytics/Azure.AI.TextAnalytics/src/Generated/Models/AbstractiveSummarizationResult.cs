// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the pre-build summarization results of each document. </summary>
    internal partial class AbstractiveSummarizationResult : AbstractiveSummarizationResultBase
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationResult"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/>, <paramref name="errors"/> or <paramref name="modelVersion"/> is null. </exception>
        public AbstractiveSummarizationResult(IEnumerable<AbstractiveSummaryDocumentResult> documents, IEnumerable<DocumentError> errors, string modelVersion) : base(documents)
        {
            Argument.AssertNotNull(documents, nameof(documents));
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            Errors = errors.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationResult"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AbstractiveSummarizationResult(IList<AbstractiveSummaryDocumentResult> documents, IList<DocumentError> errors, TextDocumentBatchStatistics statistics, string modelVersion, Dictionary<string, BinaryData> rawData) : base(documents, rawData)
        {
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationResult"/> for deserialization. </summary>
        internal AbstractiveSummarizationResult()
        {
        }

        /// <summary> Errors by document id. </summary>
        public IList<DocumentError> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public TextDocumentBatchStatistics Statistics { get; set; }
        /// <summary> This field indicates which model is used for scoring. </summary>
        public string ModelVersion { get; set; }
    }
}
