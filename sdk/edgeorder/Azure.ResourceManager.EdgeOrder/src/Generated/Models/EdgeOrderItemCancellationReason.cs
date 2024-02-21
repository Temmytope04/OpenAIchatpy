// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Reason for cancellation. </summary>
    public partial class EdgeOrderItemCancellationReason
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

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reason"/> is null. </exception>
        public EdgeOrderItemCancellationReason(string reason)
        {
            if (reason == null)
            {
                throw new ArgumentNullException(nameof(reason));
            }

            Reason = reason;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/>. </summary>
        /// <param name="reason"> Reason for cancellation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderItemCancellationReason(string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemCancellationReason"/> for deserialization. </summary>
        internal EdgeOrderItemCancellationReason()
        {
        }

        /// <summary> Reason for cancellation. </summary>
        public string Reason { get; }
    }
}
