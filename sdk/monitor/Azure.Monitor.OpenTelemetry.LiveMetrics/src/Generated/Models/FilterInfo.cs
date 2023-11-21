// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> A filter set on UX. </summary>
    internal partial class FilterInfo
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FilterInfo"/>. </summary>
        internal FilterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FilterInfo"/>. </summary>
        /// <param name="fieldName"> dimension name of the filter. </param>
        /// <param name="predicate"> Operator of the filter. </param>
        /// <param name="comparand"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterInfo(string fieldName, FilterInfoPredicate? predicate, string comparand, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FieldName = fieldName;
            Predicate = predicate;
            Comparand = comparand;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> dimension name of the filter. </summary>
        public string FieldName { get; }
        /// <summary> Operator of the filter. </summary>
        public FilterInfoPredicate? Predicate { get; }
        /// <summary> Gets the comparand. </summary>
        public string Comparand { get; }
    }
}
