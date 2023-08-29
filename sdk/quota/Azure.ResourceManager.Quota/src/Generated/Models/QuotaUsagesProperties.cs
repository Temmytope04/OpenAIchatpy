// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Usage properties for the specified resource. </summary>
    public partial class QuotaUsagesProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuotaUsagesProperties"/>. </summary>
        internal QuotaUsagesProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaUsagesProperties"/>. </summary>
        /// <param name="usages"> The quota limit properties for this resource. </param>
        /// <param name="unit"> The units for the quota usage, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </param>
        /// <param name="name"> Resource name provided by the resource provider. Use this property name when requesting quota. </param>
        /// <param name="resourceTypeName"> The name of the resource type. Optional field. </param>
        /// <param name="quotaPeriod">
        /// The time period for the summary of the quota usage values. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because it is not relevant for all resources such as compute.
        /// </param>
        /// <param name="isQuotaApplicable"> States if quota can be requested for this resource. </param>
        /// <param name="properties"> Additional properties for the specific resource provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaUsagesProperties(QuotaUsagesObject usages, string unit, QuotaRequestResourceName name, string resourceTypeName, TimeSpan? quotaPeriod, bool? isQuotaApplicable, BinaryData properties, Dictionary<string, BinaryData> rawData)
        {
            Usages = usages;
            Unit = unit;
            Name = name;
            ResourceTypeName = resourceTypeName;
            QuotaPeriod = quotaPeriod;
            IsQuotaApplicable = isQuotaApplicable;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The quota limit properties for this resource. </summary>
        public QuotaUsagesObject Usages { get; }
        /// <summary> The units for the quota usage, such as Count and Bytes. When requesting quota, use the **unit** value returned in the GET response in the request body of your PUT operation. </summary>
        public string Unit { get; }
        /// <summary> Resource name provided by the resource provider. Use this property name when requesting quota. </summary>
        public QuotaRequestResourceName Name { get; }
        /// <summary> The name of the resource type. Optional field. </summary>
        public string ResourceTypeName { get; }
        /// <summary>
        /// The time period for the summary of the quota usage values. For example:
        /// *P1D (per one day)
        /// *PT1M (per one minute)
        /// *PT1S (per one second).
        /// This parameter is optional because it is not relevant for all resources such as compute.
        /// </summary>
        public TimeSpan? QuotaPeriod { get; }
        /// <summary> States if quota can be requested for this resource. </summary>
        public bool? IsQuotaApplicable { get; }
        /// <summary>
        /// Additional properties for the specific resource provider.
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
        public BinaryData Properties { get; }
    }
}
