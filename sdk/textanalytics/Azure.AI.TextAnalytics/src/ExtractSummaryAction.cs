﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Configurations that allow callers to specify details about how to execute
    /// an Extract Summary action in a set of documents.
    /// For example, set the model version, specify the order in which extracted
    /// sentences are returned, and more.
    /// </summary>
    public class ExtractSummaryAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractSummaryAction"/>
        /// class which allows callers to specify details about how to execute
        /// an Extract Summary action in a set of documents.
        /// For example, set the model version, specify the order in which extracted
        /// sentences are returned, and more.
        /// </summary>
        public ExtractSummaryAction()
        {
        }

        /// <summary>
        /// Gets or sets a value that, if set, indicates the version of the text
        /// analytics model that will be used to generate the result.  For supported
        /// model versions, see operation-specific documentation, for example:
        /// <see href="https://docs.microsoft.com/azure/cognitive-services/text-analytics/concepts/model-versioning#available-versions"/>.
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// If set, specifies the maximum limit of sentences returned in the result. Defaults to 3.
        /// </summary>
        public int? MaxSentenceCount { get; set; }

        /// <summary>
        /// If set, specifies the order in which the extracted sentences will be returned in the result. Use
        /// <see cref="SummarySentencesOrder.Offset"/> to keep the original order in which the sentences appear
        /// in the input. Use <see cref="SummarySentencesOrder.Rank"/> to order them according to their relevance
        /// to the document input, as decided by the service. Defaults to <see cref="SummarySentencesOrder.Offset"/>.
        /// </summary>
        public SummarySentencesOrder? OrderBy { get; set; }
    }
}
