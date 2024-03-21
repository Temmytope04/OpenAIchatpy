// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The check policy restrictions parameters describing the resource that is being evaluated. </summary>
    public partial class CheckPolicyRestrictionsContent
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

        /// <summary> Initializes a new instance of <see cref="CheckPolicyRestrictionsContent"/>. </summary>
        /// <param name="resourceDetails"> The information about the resource that will be evaluated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceDetails"/> is null. </exception>
        public CheckPolicyRestrictionsContent(CheckRestrictionsResourceDetails resourceDetails)
        {
            Argument.AssertNotNull(resourceDetails, nameof(resourceDetails));

            ResourceDetails = resourceDetails;
            PendingFields = new ChangeTrackingList<PendingField>();
        }

        /// <summary> Initializes a new instance of <see cref="CheckPolicyRestrictionsContent"/>. </summary>
        /// <param name="resourceDetails"> The information about the resource that will be evaluated. </param>
        /// <param name="pendingFields"> The list of fields and values that should be evaluated for potential restrictions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckPolicyRestrictionsContent(CheckRestrictionsResourceDetails resourceDetails, IList<PendingField> pendingFields, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceDetails = resourceDetails;
            PendingFields = pendingFields;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CheckPolicyRestrictionsContent"/> for deserialization. </summary>
        internal CheckPolicyRestrictionsContent()
        {
        }

        /// <summary> The information about the resource that will be evaluated. </summary>
        public CheckRestrictionsResourceDetails ResourceDetails { get; }
        /// <summary> The list of fields and values that should be evaluated for potential restrictions. </summary>
        public IList<PendingField> PendingFields { get; }
    }
}
