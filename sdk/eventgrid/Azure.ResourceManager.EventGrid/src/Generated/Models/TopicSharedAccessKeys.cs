// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Shared access keys of the Topic. </summary>
    public partial class TopicSharedAccessKeys
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

        /// <summary> Initializes a new instance of <see cref="TopicSharedAccessKeys"/>. </summary>
        internal TopicSharedAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TopicSharedAccessKeys"/>. </summary>
        /// <param name="key1"> Shared access key1 for the topic. </param>
        /// <param name="key2"> Shared access key2 for the topic. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TopicSharedAccessKeys(string key1, string key2, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key1 = key1;
            Key2 = key2;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Shared access key1 for the topic. </summary>
        [WirePath("key1")]
        public string Key1 { get; }
        /// <summary> Shared access key2 for the topic. </summary>
        [WirePath("key2")]
        public string Key2 { get; }
    }
}
