// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The policy property value override. </summary>
    public partial class PolicyOverride
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

        /// <summary> Initializes a new instance of <see cref="PolicyOverride"/>. </summary>
        public PolicyOverride()
        {
            Selectors = new ChangeTrackingList<ResourceSelectorExpression>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyOverride"/>. </summary>
        /// <param name="kind"> The override kind. </param>
        /// <param name="value"> The value to override the policy property. </param>
        /// <param name="selectors"> The list of the selector expressions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyOverride(PolicyOverrideKind? kind, string value, IList<ResourceSelectorExpression> selectors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Value = value;
            Selectors = selectors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The override kind. </summary>
        public PolicyOverrideKind? Kind { get; set; }
        /// <summary> The value to override the policy property. </summary>
        public string Value { get; set; }
        /// <summary> The list of the selector expressions. </summary>
        public IList<ResourceSelectorExpression> Selectors { get; }
    }
}
