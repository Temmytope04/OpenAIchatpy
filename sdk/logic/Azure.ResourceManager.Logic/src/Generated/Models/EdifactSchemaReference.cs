// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact schema reference. </summary>
    public partial class EdifactSchemaReference
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

        /// <summary> Initializes a new instance of <see cref="EdifactSchemaReference"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="messageVersion"> The message version. </param>
        /// <param name="messageRelease"> The message release version. </param>
        /// <param name="schemaName"> The schema name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/>, <paramref name="messageVersion"/>, <paramref name="messageRelease"/> or <paramref name="schemaName"/> is null. </exception>
        public EdifactSchemaReference(string messageId, string messageVersion, string messageRelease, string schemaName)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(messageVersion, nameof(messageVersion));
            Argument.AssertNotNull(messageRelease, nameof(messageRelease));
            Argument.AssertNotNull(schemaName, nameof(schemaName));

            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            SchemaName = schemaName;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactSchemaReference"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="messageVersion"> The message version. </param>
        /// <param name="messageRelease"> The message release version. </param>
        /// <param name="senderApplicationId"> The sender application id. </param>
        /// <param name="senderApplicationQualifier"> The sender application qualifier. </param>
        /// <param name="associationAssignedCode"> The association assigned code. </param>
        /// <param name="schemaName"> The schema name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdifactSchemaReference(string messageId, string messageVersion, string messageRelease, string senderApplicationId, string senderApplicationQualifier, string associationAssignedCode, string schemaName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            SenderApplicationId = senderApplicationId;
            SenderApplicationQualifier = senderApplicationQualifier;
            AssociationAssignedCode = associationAssignedCode;
            SchemaName = schemaName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactSchemaReference"/> for deserialization. </summary>
        internal EdifactSchemaReference()
        {
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; set; }
        /// <summary> The message version. </summary>
        public string MessageVersion { get; set; }
        /// <summary> The message release version. </summary>
        public string MessageRelease { get; set; }
        /// <summary> The sender application id. </summary>
        public string SenderApplicationId { get; set; }
        /// <summary> The sender application qualifier. </summary>
        public string SenderApplicationQualifier { get; set; }
        /// <summary> The association assigned code. </summary>
        public string AssociationAssignedCode { get; set; }
        /// <summary> The schema name. </summary>
        public string SchemaName { get; set; }
    }
}
