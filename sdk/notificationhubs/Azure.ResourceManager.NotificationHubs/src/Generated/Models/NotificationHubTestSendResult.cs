// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub Resource. </summary>
    public partial class NotificationHubTestSendResult : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubTestSendResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubTestSendResult(AzureLocation location) : base(location)
        {
            FailureDescription = new ChangeTrackingList<NotificationHubPubRegistrationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubTestSendResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="success"> Gets or sets successful send. </param>
        /// <param name="failure"> Gets or sets send failure. </param>
        /// <param name="failureDescription"> Gets or sets actual failure description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubTestSendResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? success, int? failure, IReadOnlyList<NotificationHubPubRegistrationResult> failureDescription, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Success = success;
            Failure = failure;
            FailureDescription = failureDescription;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubTestSendResult"/> for deserialization. </summary>
        internal NotificationHubTestSendResult()
        {
        }
        /// <summary> Gets or sets actual failure description. </summary>
        public IReadOnlyList<NotificationHubPubRegistrationResult> FailureDescription { get; }
    }
}
