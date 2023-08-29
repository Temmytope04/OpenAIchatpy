// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The result of testing an analyzer on text. </summary>
    internal partial class AnalyzeResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/>. </summary>
        /// <param name="tokens"> The list of tokens returned by the analyzer specified in the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tokens"/> is null. </exception>
        internal AnalyzeResult(IEnumerable<AnalyzedTokenInfo> tokens)
        {
            Argument.AssertNotNull(tokens, nameof(tokens));

            Tokens = tokens.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/>. </summary>
        /// <param name="tokens"> The list of tokens returned by the analyzer specified in the request. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeResult(IReadOnlyList<AnalyzedTokenInfo> tokens, Dictionary<string, BinaryData> rawData)
        {
            Tokens = tokens;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeResult"/> for deserialization. </summary>
        internal AnalyzeResult()
        {
        }

        /// <summary> The list of tokens returned by the analyzer specified in the request. </summary>
        public IReadOnlyList<AnalyzedTokenInfo> Tokens { get; }
    }
}
