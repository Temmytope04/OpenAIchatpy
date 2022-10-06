// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> Properties of an Operation. </summary>
    public partial class OperationsDefinition
    {
        /// <summary> Initializes a new instance of OperationsDefinition. </summary>
        /// <param name="name"> Name of the operation. </param>
        /// <param name="display"> Display information of the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="display"/> is null. </exception>
        internal OperationsDefinition(string name, OperationsDefinitionDisplay display)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (display == null)
            {
                throw new ArgumentNullException(nameof(display));
            }

            Name = name;
            Display = display;
        }

        /// <summary> Initializes a new instance of OperationsDefinition. </summary>
        /// <param name="name"> Name of the operation. </param>
        /// <param name="isDataAction"> Indicates whether the operation applies to data-plane. </param>
        /// <param name="origin"></param>
        /// <param name="display"> Display information of the operation. </param>
        /// <param name="actionType"></param>
        /// <param name="properties"> Anything. </param>
        internal OperationsDefinition(string name, bool? isDataAction, OperationsDefinitionOrigin? origin, OperationsDefinitionDisplay display, OperationsDefinitionActionType? actionType, BinaryData properties)
        {
            Name = name;
            IsDataAction = isDataAction;
            Origin = origin;
            Display = display;
            ActionType = actionType;
            Properties = properties;
        }

        /// <summary> Name of the operation. </summary>
        public string Name { get; }
        /// <summary> Indicates whether the operation applies to data-plane. </summary>
        public bool? IsDataAction { get; }
        /// <summary> Gets the origin. </summary>
        public OperationsDefinitionOrigin? Origin { get; }
        /// <summary> Display information of the operation. </summary>
        public OperationsDefinitionDisplay Display { get; }
        /// <summary> Gets the action type. </summary>
        public OperationsDefinitionActionType? ActionType { get; }
        /// <summary>
        /// Anything
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
        public BinaryData Properties { get; }
    }
}
