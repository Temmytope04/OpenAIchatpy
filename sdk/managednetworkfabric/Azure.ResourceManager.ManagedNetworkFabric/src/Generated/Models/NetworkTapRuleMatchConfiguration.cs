// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the match configuration that are supported to filter the traffic. </summary>
    public partial class NetworkTapRuleMatchConfiguration
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

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleMatchConfiguration"/>. </summary>
        public NetworkTapRuleMatchConfiguration()
        {
            MatchConditions = new ChangeTrackingList<NetworkTapRuleMatchCondition>();
            Actions = new ChangeTrackingList<NetworkTapRuleAction>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapRuleMatchConfiguration"/>. </summary>
        /// <param name="matchConfigurationName"> The name of the match configuration. </param>
        /// <param name="sequenceNumber"> Sequence Number of the match configuration.. </param>
        /// <param name="ipAddressType"> Type of IP Address. IPv4 or IPv6. </param>
        /// <param name="matchConditions"> List of the match conditions. </param>
        /// <param name="actions"> List of actions that need to be performed for the matched conditions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapRuleMatchConfiguration(string matchConfigurationName, long? sequenceNumber, NetworkFabricIPAddressType? ipAddressType, IList<NetworkTapRuleMatchCondition> matchConditions, IList<NetworkTapRuleAction> actions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MatchConfigurationName = matchConfigurationName;
            SequenceNumber = sequenceNumber;
            IPAddressType = ipAddressType;
            MatchConditions = matchConditions;
            Actions = actions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the match configuration. </summary>
        public string MatchConfigurationName { get; set; }
        /// <summary> Sequence Number of the match configuration.. </summary>
        public long? SequenceNumber { get; set; }
        /// <summary> Type of IP Address. IPv4 or IPv6. </summary>
        public NetworkFabricIPAddressType? IPAddressType { get; set; }
        /// <summary> List of the match conditions. </summary>
        public IList<NetworkTapRuleMatchCondition> MatchConditions { get; }
        /// <summary> List of actions that need to be performed for the matched conditions. </summary>
        public IList<NetworkTapRuleAction> Actions { get; }
    }
}
