// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Raw failure information if DNS verification fails. </summary>
    public partial class ContainerAppCustomDomainVerificationFailureInfo
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainVerificationFailureInfo"/>. </summary>
        internal ContainerAppCustomDomainVerificationFailureInfo()
        {
            Details = new ChangeTrackingList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainVerificationFailureInfo"/>. </summary>
        /// <param name="code"> Standardized string to programmatically identify the error. </param>
        /// <param name="message"> Detailed error description and debugging information. </param>
        /// <param name="target"> Detailed error description and debugging information. </param>
        /// <param name="details"> Details or the error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCustomDomainVerificationFailureInfo(string code, string message, string target, IReadOnlyList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Standardized string to programmatically identify the error. </summary>
        [WirePath("code")]
        public string Code { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        [WirePath("message")]
        public string Message { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        [WirePath("target")]
        public string Target { get; }
        /// <summary> Details or the error. </summary>
        [WirePath("details")]
        public IReadOnlyList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> Details { get; }
    }
}
