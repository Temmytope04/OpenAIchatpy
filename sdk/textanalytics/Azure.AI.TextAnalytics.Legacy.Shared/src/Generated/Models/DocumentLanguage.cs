// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The DocumentLanguage. </summary>
    internal partial class DocumentLanguage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DocumentLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="detectedLanguage"> Detected Language. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="detectedLanguage"/> or <paramref name="warnings"/> is null. </exception>
        internal DocumentLanguage(string id, DetectedLanguage detectedLanguage, IEnumerable<TextAnalyticsWarning> warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(detectedLanguage, nameof(detectedLanguage));
            Argument.AssertNotNull(warnings, nameof(warnings));

            Id = id;
            DetectedLanguage = detectedLanguage;
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentLanguage"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="detectedLanguage"> Detected Language. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentLanguage(string id, DetectedLanguage detectedLanguage, IReadOnlyList<TextAnalyticsWarning> warnings, DocumentStatistics statistics, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            DetectedLanguage = detectedLanguage;
            Warnings = warnings;
            Statistics = statistics;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentLanguage"/> for deserialization. </summary>
        internal DocumentLanguage()
        {
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Detected Language. </summary>
        public DetectedLanguage DetectedLanguage { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarning> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
    }
}
