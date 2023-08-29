// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntitiesTaskResult. </summary>
    internal partial class EntitiesTaskResult : AnalyzeTextTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="EntitiesTaskResult"/>. </summary>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal EntitiesTaskResult(EntitiesResult results)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results;
            Kind = AnalyzeTextTaskResultsKind.EntityRecognitionResults;
        }

        /// <summary> Initializes a new instance of <see cref="EntitiesTaskResult"/>. </summary>
        /// <param name="kind"> Enumeration of supported Text Analysis task results. </param>
        /// <param name="results"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EntitiesTaskResult(AnalyzeTextTaskResultsKind kind, EntitiesResult results, Dictionary<string, BinaryData> rawData) : base(kind, rawData)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="EntitiesTaskResult"/> for deserialization. </summary>
        internal EntitiesTaskResult()
        {
        }

        /// <summary> Gets the results. </summary>
        public EntitiesResult Results { get; }
    }
}
