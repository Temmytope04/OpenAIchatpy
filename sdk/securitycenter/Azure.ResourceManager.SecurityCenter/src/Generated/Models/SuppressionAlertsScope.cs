// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The SuppressionAlertsScope. </summary>
    internal partial class SuppressionAlertsScope
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

        /// <summary> Initializes a new instance of <see cref="SuppressionAlertsScope"/>. </summary>
        /// <param name="allOf"> All the conditions inside need to be true in order to suppress the alert. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allOf"/> is null. </exception>
        public SuppressionAlertsScope(IEnumerable<SuppressionAlertsScopeElement> allOf)
        {
            if (allOf == null)
            {
                throw new ArgumentNullException(nameof(allOf));
            }

            AllOf = allOf.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SuppressionAlertsScope"/>. </summary>
        /// <param name="allOf"> All the conditions inside need to be true in order to suppress the alert. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SuppressionAlertsScope(IList<SuppressionAlertsScopeElement> allOf, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllOf = allOf;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SuppressionAlertsScope"/> for deserialization. </summary>
        internal SuppressionAlertsScope()
        {
        }

        /// <summary> All the conditions inside need to be true in order to suppress the alert. </summary>
        public IList<SuppressionAlertsScopeElement> AllOf { get; }
    }
}
