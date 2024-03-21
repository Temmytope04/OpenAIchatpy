// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for evaluating a policy set. </summary>
    public partial class DevTestLabEvaluatePoliciesContent
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

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesContent"/>. </summary>
        public DevTestLabEvaluatePoliciesContent()
        {
            Policies = new ChangeTrackingList<DevTestLabEvaluatePolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabEvaluatePoliciesContent"/>. </summary>
        /// <param name="policies"> Policies to evaluate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabEvaluatePoliciesContent(IList<DevTestLabEvaluatePolicy> policies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Policies = policies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Policies to evaluate. </summary>
        public IList<DevTestLabEvaluatePolicy> Policies { get; }
    }
}
