// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownLexicalNormalizer. </summary>
    internal partial class UnknownLexicalNormalizer : LexicalNormalizer
    {
        /// <summary> Initializes a new instance of <see cref="UnknownLexicalNormalizer"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the normalizer. </param>
        /// <param name="name"> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownLexicalNormalizer(string oDataType, string name, Dictionary<string, BinaryData> rawData) : base(oDataType, name, rawData)
        {
            ODataType = oDataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownLexicalNormalizer"/> for deserialization. </summary>
        internal UnknownLexicalNormalizer()
        {
        }
    }
}
