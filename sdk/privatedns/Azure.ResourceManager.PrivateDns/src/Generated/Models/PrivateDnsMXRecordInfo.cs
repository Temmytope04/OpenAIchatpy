// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> An MX record. </summary>
    public partial class PrivateDnsMXRecordInfo
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

        /// <summary> Initializes a new instance of <see cref="PrivateDnsMXRecordInfo"/>. </summary>
        public PrivateDnsMXRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsMXRecordInfo"/>. </summary>
        /// <param name="preference"> The preference value for this MX record. </param>
        /// <param name="exchange"> The domain name of the mail host for this MX record. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsMXRecordInfo(int? preference, string exchange, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Preference = preference;
            Exchange = exchange;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The preference value for this MX record. </summary>
        [WirePath("preference")]
        public int? Preference { get; set; }
        /// <summary> The domain name of the mail host for this MX record. </summary>
        [WirePath("exchange")]
        public string Exchange { get; set; }
    }
}
