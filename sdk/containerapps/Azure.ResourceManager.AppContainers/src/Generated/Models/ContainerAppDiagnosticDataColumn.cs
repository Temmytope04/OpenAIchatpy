// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Diagnostics data column. </summary>
    public partial class ContainerAppDiagnosticDataColumn
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticDataColumn"/>. </summary>
        public ContainerAppDiagnosticDataColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticDataColumn"/>. </summary>
        /// <param name="columnName"> Column name. </param>
        /// <param name="dataType"> Data type of the column. </param>
        /// <param name="columnType"> Column type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDiagnosticDataColumn(string columnName, string dataType, string columnType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ColumnName = columnName;
            DataType = dataType;
            ColumnType = columnType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Column name. </summary>
        [WirePath("columnName")]
        public string ColumnName { get; set; }
        /// <summary> Data type of the column. </summary>
        [WirePath("dataType")]
        public string DataType { get; set; }
        /// <summary> Column type. </summary>
        [WirePath("columnType")]
        public string ColumnType { get; set; }
    }
}
