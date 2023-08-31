// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource group export result. </summary>
    public partial class ResourceGroupExportResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceGroupExportResult"/>. </summary>
        internal ResourceGroupExportResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupExportResult"/>. </summary>
        /// <param name="template"> The template content. </param>
        /// <param name="error"> The template export error. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceGroupExportResult(BinaryData template, ResponseError error, Dictionary<string, BinaryData> rawData)
        {
            Template = template;
            Error = error;
            _rawData = rawData;
        }

        /// <summary>
        /// The template content.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Template { get; }
        /// <summary> The template export error. </summary>
        public ResponseError Error { get; }
    }
}
