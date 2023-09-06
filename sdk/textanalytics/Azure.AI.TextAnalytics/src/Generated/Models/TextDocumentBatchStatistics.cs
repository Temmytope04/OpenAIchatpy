// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics
{
    /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
    public partial class TextDocumentBatchStatistics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TextDocumentBatchStatistics"/>. </summary>
        /// <param name="documentCount"> Number of documents submitted in the request. </param>
        /// <param name="validDocumentCount"> Number of valid documents. This excludes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="invalidDocumentCount"> Number of invalid documents. This includes empty, over-size limit or non-supported languages documents. </param>
        /// <param name="transactionCount"> Number of transactions for the request. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TextDocumentBatchStatistics(int documentCount, int validDocumentCount, int invalidDocumentCount, long transactionCount, Dictionary<string, BinaryData> rawData)
        {
            DocumentCount = documentCount;
            ValidDocumentCount = validDocumentCount;
            InvalidDocumentCount = invalidDocumentCount;
            TransactionCount = transactionCount;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextDocumentBatchStatistics"/> for deserialization. </summary>
        internal TextDocumentBatchStatistics()
        {
        }
    }
}
