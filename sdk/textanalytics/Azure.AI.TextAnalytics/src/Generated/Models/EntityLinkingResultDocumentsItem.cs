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
    /// <summary> The EntityLinkingResultDocumentsItem. </summary>
    internal partial class EntityLinkingResultDocumentsItem : LinkedEntitiesDocumentResult
    {
        /// <summary> Initializes a new instance of EntityLinkingResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Recognized well known entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="entities"/> is null. </exception>
        public EntityLinkingResultDocumentsItem(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<LinkedEntity> entities) : base(id, warnings, entities)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(warnings, nameof(warnings));
            Argument.AssertNotNull(entities, nameof(entities));
        }

        /// <summary> Initializes a new instance of EntityLinkingResultDocumentsItem. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Recognized well known entities in the document. </param>
        internal EntityLinkingResultDocumentsItem(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<LinkedEntity> entities) : base(id, warnings, statistics, entities)
        {
        }
    }
}
