// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for tokenizers.
    /// Please note <see cref="LexicalTokenizer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ClassicTokenizer"/>, <see cref="EdgeNGramTokenizer"/>, <see cref="KeywordTokenizerV1"/>, <see cref="KeywordTokenizer"/>, <see cref="MicrosoftLanguageStemmingTokenizer"/>, <see cref="MicrosoftLanguageTokenizer"/>, <see cref="NGramTokenizer"/>, <see cref="PathHierarchyTokenizer"/>, <see cref="PatternTokenizer"/>, <see cref="LuceneStandardTokenizerV1"/>, <see cref="LuceneStandardTokenizer"/> and <see cref="UaxUrlEmailTokenizer"/>.
    /// </summary>
    public partial class LexicalTokenizer
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LexicalTokenizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LexicalTokenizer(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ODataType = oDataType;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LexicalTokenizer"/> for deserialization. </summary>
        internal LexicalTokenizer()
        {
        }

        /// <summary> A URI fragment specifying the type of tokenizer. </summary>
        internal string ODataType { get; set; }
        /// <summary> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
