// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Trigger Rollover Request. </summary>
    public partial class TriggerRolloverContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TriggerRolloverContent"/>. </summary>
        public TriggerRolloverContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TriggerRolloverContent"/>. </summary>
        /// <param name="serverCertificate"> Certificate Data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerRolloverContent(BinaryData serverCertificate, Dictionary<string, BinaryData> rawData)
        {
            ServerCertificate = serverCertificate;
            _rawData = rawData;
        }

        /// <summary>
        /// Certificate Data
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
        public BinaryData ServerCertificate { get; set; }
    }
}
