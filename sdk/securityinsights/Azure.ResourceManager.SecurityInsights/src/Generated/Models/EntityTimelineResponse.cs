// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The entity timeline result operation response.
    /// Serialized Name: EntityTimelineResponse
    /// </summary>
    internal partial class EntityTimelineResponse
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

        /// <summary> Initializes a new instance of <see cref="EntityTimelineResponse"/>. </summary>
        internal EntityTimelineResponse()
        {
            Value = new ChangeTrackingList<EntityTimelineItem>();
        }

        /// <summary> Initializes a new instance of <see cref="EntityTimelineResponse"/>. </summary>
        /// <param name="metaData">
        /// The metadata from the timeline operation results.
        /// Serialized Name: EntityTimelineResponse.metaData
        /// </param>
        /// <param name="value">
        /// The timeline result values.
        /// Serialized Name: EntityTimelineResponse.value
        /// Please note <see cref="EntityTimelineItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActivityTimelineItem"/>, <see cref="AnomalyTimelineItem"/>, <see cref="BookmarkTimelineItem"/> and <see cref="SecurityAlertTimelineItem"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityTimelineResponse(TimelineResultsMetadata metaData, IReadOnlyList<EntityTimelineItem> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetaData = metaData;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The metadata from the timeline operation results.
        /// Serialized Name: EntityTimelineResponse.metaData
        /// </summary>
        public TimelineResultsMetadata MetaData { get; }
        /// <summary>
        /// The timeline result values.
        /// Serialized Name: EntityTimelineResponse.value
        /// Please note <see cref="EntityTimelineItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActivityTimelineItem"/>, <see cref="AnomalyTimelineItem"/>, <see cref="BookmarkTimelineItem"/> and <see cref="SecurityAlertTimelineItem"/>.
        /// </summary>
        public IReadOnlyList<EntityTimelineItem> Value { get; }
    }
}
