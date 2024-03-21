// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The ServiceAccountQuotaLimit. </summary>
    public partial class ServiceAccountQuotaLimit
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

        /// <summary> Initializes a new instance of <see cref="ServiceAccountQuotaLimit"/>. </summary>
        internal ServiceAccountQuotaLimit()
        {
            Rules = new ChangeTrackingList<ServiceAccountThrottlingRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountQuotaLimit"/>. </summary>
        /// <param name="count"></param>
        /// <param name="renewalPeriod"></param>
        /// <param name="rules"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAccountQuotaLimit(float? count, float? renewalPeriod, IReadOnlyList<ServiceAccountThrottlingRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            RenewalPeriod = renewalPeriod;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the count. </summary>
        public float? Count { get; }
        /// <summary> Gets the renewal period. </summary>
        public float? RenewalPeriod { get; }
        /// <summary> Gets the rules. </summary>
        public IReadOnlyList<ServiceAccountThrottlingRule> Rules { get; }
    }
}
