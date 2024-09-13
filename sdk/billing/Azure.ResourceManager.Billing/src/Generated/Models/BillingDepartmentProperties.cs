// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Optional grouping of enrollment accounts to segment costs into logical groupings and set budgets. </summary>
    public partial class BillingDepartmentProperties
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

        /// <summary> Initializes a new instance of <see cref="BillingDepartmentProperties"/>. </summary>
        public BillingDepartmentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingDepartmentProperties"/>. </summary>
        /// <param name="costCenter"> The cost center associated with the department. </param>
        /// <param name="displayName"> The name of the department. </param>
        /// <param name="id"> The ID that uniquely identifies the department. </param>
        /// <param name="status"> The status of the department. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingDepartmentProperties(string costCenter, string displayName, string id, string status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CostCenter = costCenter;
            DisplayName = displayName;
            Id = id;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cost center associated with the department. </summary>
        [WirePath("costCenter")]
        public string CostCenter { get; set; }
        /// <summary> The name of the department. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; set; }
        /// <summary> The ID that uniquely identifies the department. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> The status of the department. </summary>
        [WirePath("status")]
        public string Status { get; }
    }
}
