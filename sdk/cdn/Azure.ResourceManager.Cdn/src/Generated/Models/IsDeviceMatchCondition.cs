// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for IsDevice match conditions. </summary>
    public partial class IsDeviceMatchCondition
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

        /// <summary> Initializes a new instance of <see cref="IsDeviceMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="isDeviceOperator"> Describes operator to be matched. </param>
        public IsDeviceMatchCondition(IsDeviceMatchConditionType conditionType, IsDeviceOperator isDeviceOperator)
        {
            ConditionType = conditionType;
            IsDeviceOperator = isDeviceOperator;
            MatchValues = new ChangeTrackingList<IsDeviceMatchConditionMatchValue>();
            Transforms = new ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="IsDeviceMatchCondition"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="isDeviceOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IsDeviceMatchCondition(IsDeviceMatchConditionType conditionType, IsDeviceOperator isDeviceOperator, bool? negateCondition, IList<IsDeviceMatchConditionMatchValue> matchValues, IList<PreTransformCategory> transforms, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConditionType = conditionType;
            IsDeviceOperator = isDeviceOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IsDeviceMatchCondition"/> for deserialization. </summary>
        internal IsDeviceMatchCondition()
        {
        }

        /// <summary> Gets or sets the condition type. </summary>
        public IsDeviceMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public IsDeviceOperator IsDeviceOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<IsDeviceMatchConditionMatchValue> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
