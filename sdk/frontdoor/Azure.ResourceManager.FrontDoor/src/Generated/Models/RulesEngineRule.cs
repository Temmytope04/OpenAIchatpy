// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Contains a list of match conditions, and an action on how to modify the request/response. If multiple rules match, the actions from one rule that conflict with a previous rule overwrite for a singular action, or append in the case of headers manipulation. </summary>
    public partial class RulesEngineRule
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

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/>. </summary>
        /// <param name="name"> A name to refer to this specific rule. </param>
        /// <param name="priority"> A priority assigned to this rule. </param>
        /// <param name="action"> Actions to perform on the request and response if all of the match conditions are met. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="action"/> is null. </exception>
        public RulesEngineRule(string name, int priority, RulesEngineAction action)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(action, nameof(action));

            Name = name;
            Priority = priority;
            Action = action;
            MatchConditions = new ChangeTrackingList<RulesEngineMatchCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/>. </summary>
        /// <param name="name"> A name to refer to this specific rule. </param>
        /// <param name="priority"> A priority assigned to this rule. </param>
        /// <param name="action"> Actions to perform on the request and response if all of the match conditions are met. </param>
        /// <param name="matchConditions"> A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run. </param>
        /// <param name="matchProcessingBehavior"> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulesEngineRule(string name, int priority, RulesEngineAction action, IList<RulesEngineMatchCondition> matchConditions, MatchProcessingBehavior? matchProcessingBehavior, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Priority = priority;
            Action = action;
            MatchConditions = matchConditions;
            MatchProcessingBehavior = matchProcessingBehavior;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/> for deserialization. </summary>
        internal RulesEngineRule()
        {
        }

        /// <summary> A name to refer to this specific rule. </summary>
        public string Name { get; set; }
        /// <summary> A priority assigned to this rule. </summary>
        public int Priority { get; set; }
        /// <summary> Actions to perform on the request and response if all of the match conditions are met. </summary>
        public RulesEngineAction Action { get; set; }
        /// <summary> A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run. </summary>
        public IList<RulesEngineMatchCondition> MatchConditions { get; set; }
        /// <summary> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </summary>
        public MatchProcessingBehavior? MatchProcessingBehavior { get; set; }
    }
}
