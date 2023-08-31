// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Represent a parameter with constrains and metadata. </summary>
    public partial class ParameterDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ParameterDefinition"/>. </summary>
        /// <param name="templateParameterType"> Allowed data types for Resource Manager template parameters. </param>
        public ParameterDefinition(TemplateParameterType templateParameterType)
        {
            TemplateParameterType = templateParameterType;
            AllowedValues = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ParameterDefinition"/>. </summary>
        /// <param name="templateParameterType"> Allowed data types for Resource Manager template parameters. </param>
        /// <param name="defaultValue"> Default Value for this parameter. </param>
        /// <param name="allowedValues"> Array of allowed values for this parameter. </param>
        /// <param name="displayName"> DisplayName of this parameter/resourceGroup. </param>
        /// <param name="description"> Description of this parameter/resourceGroup. </param>
        /// <param name="strongType"> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ParameterDefinition(TemplateParameterType templateParameterType, BinaryData defaultValue, IList<BinaryData> allowedValues, string displayName, string description, string strongType, Dictionary<string, BinaryData> rawData)
        {
            TemplateParameterType = templateParameterType;
            DefaultValue = defaultValue;
            AllowedValues = allowedValues;
            DisplayName = displayName;
            Description = description;
            StrongType = strongType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ParameterDefinition"/> for deserialization. </summary>
        internal ParameterDefinition()
        {
        }

        /// <summary> Allowed data types for Resource Manager template parameters. </summary>
        public TemplateParameterType TemplateParameterType { get; set; }
        /// <summary>
        /// Default Value for this parameter.
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
        public BinaryData DefaultValue { get; set; }
        /// <summary>
        /// Array of allowed values for this parameter.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> AllowedValues { get; }
        /// <summary> DisplayName of this parameter/resourceGroup. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of this parameter/resourceGroup. </summary>
        public string Description { get; set; }
        /// <summary> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </summary>
        public string StrongType { get; set; }
    }
}
