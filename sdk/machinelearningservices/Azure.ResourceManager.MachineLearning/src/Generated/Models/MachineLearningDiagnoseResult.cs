// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Result of Diagnose. </summary>
    public partial class MachineLearningDiagnoseResult
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningDiagnoseResult"/>. </summary>
        internal MachineLearningDiagnoseResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDiagnoseResult"/>. </summary>
        /// <param name="code"> Code for workspace setup error. </param>
        /// <param name="level"> Level of workspace setup error. </param>
        /// <param name="message"> Message of workspace setup error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDiagnoseResult(string code, MachineLearningDiagnoseResultLevel? level, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Level = level;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Code for workspace setup error. </summary>
        [WirePath("code")]
        public string Code { get; }
        /// <summary> Level of workspace setup error. </summary>
        [WirePath("level")]
        public MachineLearningDiagnoseResultLevel? Level { get; }
        /// <summary> Message of workspace setup error. </summary>
        [WirePath("message")]
        public string Message { get; }
    }
}
