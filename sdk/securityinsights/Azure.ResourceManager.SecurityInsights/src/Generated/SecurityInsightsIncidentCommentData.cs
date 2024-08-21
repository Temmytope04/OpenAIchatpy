// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsIncidentComment data model.
    /// Represents an incident comment
    /// Serialized Name: IncidentComment
    /// </summary>
    public partial class SecurityInsightsIncidentCommentData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentCommentData"/>. </summary>
        public SecurityInsightsIncidentCommentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentCommentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="message">
        /// The comment message
        /// Serialized Name: IncidentComment.properties.message
        /// </param>
        /// <param name="createdOn">
        /// The time the comment was created
        /// Serialized Name: IncidentComment.properties.createdTimeUtc
        /// </param>
        /// <param name="lastModifiedOn">
        /// The time the comment was updated
        /// Serialized Name: IncidentComment.properties.lastModifiedTimeUtc
        /// </param>
        /// <param name="author">
        /// Describes the client that created the comment
        /// Serialized Name: IncidentComment.properties.author
        /// </param>
        /// <param name="etag">
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentCommentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string message, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, SecurityInsightsClientInfo author, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Message = message;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Author = author;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The comment message
        /// Serialized Name: IncidentComment.properties.message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The time the comment was created
        /// Serialized Name: IncidentComment.properties.createdTimeUtc
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// The time the comment was updated
        /// Serialized Name: IncidentComment.properties.lastModifiedTimeUtc
        /// </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary>
        /// Describes the client that created the comment
        /// Serialized Name: IncidentComment.properties.author
        /// </summary>
        public SecurityInsightsClientInfo Author { get; }
        /// <summary>
        /// Etag of the azure resource
        /// Serialized Name: ResourceWithEtag.etag
        /// </summary>
        public ETag? ETag { get; set; }
    }
}
