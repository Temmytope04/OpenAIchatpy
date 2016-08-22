// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specifies some text and analysis components used to break that text
    /// into tokens.
    /// </summary>
    public partial class AnalyzeRequest
    {
        /// <summary>
        /// Initializes a new instance of the AnalyzeRequest class.
        /// </summary>
        public AnalyzeRequest() { }

        /// <summary>
        /// Initializes a new instance of the AnalyzeRequest class.
        /// </summary>
        public AnalyzeRequest(string text, AnalyzerName analyzer = default(AnalyzerName), TokenizerName tokenizer = default(TokenizerName), IList<TokenFilterName> tokenFilters = default(IList<TokenFilterName>), IList<CharFilterName> charFilters = default(IList<CharFilterName>))
        {
            Text = text;
            Analyzer = analyzer;
            Tokenizer = tokenizer;
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
        }

        /// <summary>
        /// Gets or sets the text to break into tokens.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer to use to break the given
        /// text. If this parameter is not specified, you must specify a
        /// tokenizer instead. The tokenizer and analyzer parameters are
        /// mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "analyzer")]
        public AnalyzerName Analyzer { get; set; }

        /// <summary>
        /// Gets or sets the name of the tokenizer to use to break the given
        /// text. If this parameter is not specified, you must specify an
        /// analyzer instead. The tokenizer and analyzer parameters are
        /// mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "tokenizer")]
        public TokenizerName Tokenizer { get; set; }

        /// <summary>
        /// Gets or sets an optional list of token filters to use when
        /// breaking the given text. This parameter can only be set when
        /// using the tokenizer parameter.
        /// </summary>
        [JsonProperty(PropertyName = "tokenFilters")]
        public IList<TokenFilterName> TokenFilters { get; set; }

        /// <summary>
        /// Gets or sets an optional list of character filters to use when
        /// breaking the given text. This parameter can only be set when
        /// using the tokenizer parameter.
        /// </summary>
        [JsonProperty(PropertyName = "charFilters")]
        public IList<CharFilterName> CharFilters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
        }
    }
}
