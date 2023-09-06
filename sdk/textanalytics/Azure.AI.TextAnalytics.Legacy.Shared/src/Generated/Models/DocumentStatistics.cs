// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
    internal partial class DocumentStatistics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/>. </summary>
        /// <param name="charactersCount"> Number of text elements recognized in the document. </param>
        /// <param name="transactionsCount"> Number of transactions for the document. </param>
        internal DocumentStatistics(int charactersCount, int transactionsCount)
        {
            CharactersCount = charactersCount;
            TransactionsCount = transactionsCount;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/>. </summary>
        /// <param name="charactersCount"> Number of text elements recognized in the document. </param>
        /// <param name="transactionsCount"> Number of transactions for the document. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentStatistics(int charactersCount, int transactionsCount, Dictionary<string, BinaryData> rawData)
        {
            CharactersCount = charactersCount;
            TransactionsCount = transactionsCount;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentStatistics"/> for deserialization. </summary>
        internal DocumentStatistics()
        {
        }

        /// <summary> Number of text elements recognized in the document. </summary>
        public int CharactersCount { get; }
        /// <summary> Number of transactions for the document. </summary>
        public int TransactionsCount { get; }
    }
}
