// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing the RedisFirewallRule data model.
    /// A firewall rule on a redis cache has a name, and describes a contiguous range of IP addresses permitted to connect
    /// </summary>
    public partial class RedisFirewallRuleData : ResourceData
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisFirewallRuleData"/>. </summary>
        /// <param name="startIP"> lowest IP address included in the range. </param>
        /// <param name="endIP"> highest IP address included in the range. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startIP"/> or <paramref name="endIP"/> is null. </exception>
        public RedisFirewallRuleData(IPAddress startIP, IPAddress endIP)
        {
            if (startIP == null)
            {
                throw new ArgumentNullException(nameof(startIP));
            }
            if (endIP == null)
            {
                throw new ArgumentNullException(nameof(endIP));
            }

            StartIP = startIP;
            EndIP = endIP;
        }

        /// <summary> Initializes a new instance of <see cref="RedisFirewallRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIP"> lowest IP address included in the range. </param>
        /// <param name="endIP"> highest IP address included in the range. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisFirewallRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IPAddress startIP, IPAddress endIP, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StartIP = startIP;
            EndIP = endIP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisFirewallRuleData"/> for deserialization. </summary>
        internal RedisFirewallRuleData()
        {
        }

        /// <summary> lowest IP address included in the range. </summary>
        public IPAddress StartIP { get; set; }
        /// <summary> highest IP address included in the range. </summary>
        public IPAddress EndIP { get; set; }
    }
}
