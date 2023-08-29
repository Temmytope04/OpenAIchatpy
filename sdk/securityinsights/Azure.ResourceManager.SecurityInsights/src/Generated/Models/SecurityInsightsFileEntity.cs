// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a file entity. </summary>
    public partial class SecurityInsightsFileEntity : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileEntity"/>. </summary>
        public SecurityInsightsFileEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            FileHashEntityIds = new ChangeTrackingList<string>();
            Kind = SecurityInsightsEntityKind.File;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsFileEntity"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="directory"> The full path to the file. </param>
        /// <param name="fileHashEntityIds"> The file hash entity identifiers associated with this file. </param>
        /// <param name="fileName"> The file name without path (some alerts might not include path). </param>
        /// <param name="hostEntityId"> The Host entity id which the file belongs to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsFileEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string directory, IReadOnlyList<string> fileHashEntityIds, string fileName, string hostEntityId, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, kind, rawData)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            Directory = directory;
            FileHashEntityIds = fileHashEntityIds;
            FileName = fileName;
            HostEntityId = hostEntityId;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The full path to the file. </summary>
        public string Directory { get; }
        /// <summary> The file hash entity identifiers associated with this file. </summary>
        public IReadOnlyList<string> FileHashEntityIds { get; }
        /// <summary> The file name without path (some alerts might not include path). </summary>
        public string FileName { get; }
        /// <summary> The Host entity id which the file belongs to. </summary>
        public string HostEntityId { get; }
    }
}
