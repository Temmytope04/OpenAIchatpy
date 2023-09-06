// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for an Abstractive Summarization task. </summary>
    internal partial class AbstractiveSummarizationTaskParametersBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParametersBase"/>. </summary>
        public AbstractiveSummarizationTaskParametersBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParametersBase"/>. </summary>
        /// <param name="sentenceCount"> It controls the approximate number of sentences in the output summaries. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AbstractiveSummarizationTaskParametersBase(int? sentenceCount, StringIndexType? stringIndexType, Dictionary<string, BinaryData> rawData)
        {
            SentenceCount = sentenceCount;
            StringIndexType = stringIndexType;
            _rawData = rawData;
        }

        /// <summary> It controls the approximate number of sentences in the output summaries. </summary>
        public int? SentenceCount { get; set; }
        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
