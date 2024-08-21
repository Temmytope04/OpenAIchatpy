// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// security ml analytics settings data sources
    /// Serialized Name: SecurityMLAnalyticsSettingsDataSource
    /// </summary>
    public partial class SecurityMLAnalyticsSettingsDataSource
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

        /// <summary> Initializes a new instance of <see cref="SecurityMLAnalyticsSettingsDataSource"/>. </summary>
        public SecurityMLAnalyticsSettingsDataSource()
        {
            DataTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityMLAnalyticsSettingsDataSource"/>. </summary>
        /// <param name="connectorId">
        /// The connector id that provides the following data types
        /// Serialized Name: SecurityMLAnalyticsSettingsDataSource.connectorId
        /// </param>
        /// <param name="dataTypes">
        /// The data types used by the security ml analytics settings
        /// Serialized Name: SecurityMLAnalyticsSettingsDataSource.dataTypes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityMLAnalyticsSettingsDataSource(string connectorId, IList<string> dataTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectorId = connectorId;
            DataTypes = dataTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The connector id that provides the following data types
        /// Serialized Name: SecurityMLAnalyticsSettingsDataSource.connectorId
        /// </summary>
        public string ConnectorId { get; set; }
        /// <summary>
        /// The data types used by the security ml analytics settings
        /// Serialized Name: SecurityMLAnalyticsSettingsDataSource.dataTypes
        /// </summary>
        public IList<string> DataTypes { get; }
    }
}
