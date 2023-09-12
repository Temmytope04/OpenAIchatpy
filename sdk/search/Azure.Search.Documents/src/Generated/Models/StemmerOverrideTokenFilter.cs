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
    /// <summary> Provides the ability to override other stemming filters with custom dictionary-based stemming. Any dictionary-stemmed terms will be marked as keywords so that they will not be stemmed with stemmers down the chain. Must be placed before any stemming filters. This token filter is implemented using Apache Lucene. </summary>
    public partial class StemmerOverrideTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of StemmerOverrideTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="rules"> A list of stemming rules in the following format: "word =&gt; stem", for example: "ran =&gt; run". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="rules"/> is null. </exception>
        public StemmerOverrideTokenFilter(string name, IEnumerable<string> rules) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(rules, nameof(rules));

            Rules = rules.ToList();
            ODataType = "#Microsoft.Azure.Search.StemmerOverrideTokenFilter";
        }

        /// <summary> Initializes a new instance of StemmerOverrideTokenFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="rules"> A list of stemming rules in the following format: "word =&gt; stem", for example: "ran =&gt; run". </param>
        internal StemmerOverrideTokenFilter(string oDataType, string name, IList<string> rules) : base(oDataType, name)
        {
            Rules = rules;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.StemmerOverrideTokenFilter";
        }
    }
}
