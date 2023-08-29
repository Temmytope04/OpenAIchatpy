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
    /// <summary> The PiiDocumentEntities. </summary>
    internal partial class PiiDocumentEntities
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PiiDocumentEntities"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="redactedText"/>, <paramref name="entities"/> or <paramref name="warnings"/> is null. </exception>
        internal PiiDocumentEntities(string id, string redactedText, IEnumerable<Entity> entities, IEnumerable<TextAnalyticsWarning> warnings)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(redactedText, nameof(redactedText));
            Argument.AssertNotNull(entities, nameof(entities));
            Argument.AssertNotNull(warnings, nameof(warnings));

            Id = id;
            RedactedText = redactedText;
            Entities = entities.ToList();
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PiiDocumentEntities"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiDocumentEntities(string id, string redactedText, IReadOnlyList<Entity> entities, IReadOnlyList<TextAnalyticsWarning> warnings, DocumentStatistics statistics, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            RedactedText = redactedText;
            Entities = entities;
            Warnings = warnings;
            Statistics = statistics;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PiiDocumentEntities"/> for deserialization. </summary>
        internal PiiDocumentEntities()
        {
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Returns redacted text. </summary>
        public string RedactedText { get; }
        /// <summary> Recognized entities in the document. </summary>
        public IReadOnlyList<Entity> Entities { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarning> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; }
    }
}
