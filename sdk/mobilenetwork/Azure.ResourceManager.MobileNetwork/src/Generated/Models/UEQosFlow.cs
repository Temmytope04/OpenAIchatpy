// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// QoS Flow
    /// Serialized Name: UeQOSFlow
    /// </summary>
    public partial class UEQosFlow
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

        /// <summary> Initializes a new instance of <see cref="UEQosFlow"/>. </summary>
        /// <param name="qfi">
        /// Qos Flow Identifier
        /// Serialized Name: UeQOSFlow.qfi
        /// </param>
        /// <param name="fiveqi">
        /// 5G QoS Identifier.
        /// Serialized Name: UeQOSFlow.fiveqi
        /// </param>
        public UEQosFlow(int qfi, int fiveqi)
        {
            Qfi = qfi;
            Fiveqi = fiveqi;
        }

        /// <summary> Initializes a new instance of <see cref="UEQosFlow"/>. </summary>
        /// <param name="qfi">
        /// Qos Flow Identifier
        /// Serialized Name: UeQOSFlow.qfi
        /// </param>
        /// <param name="fiveqi">
        /// 5G QoS Identifier.
        /// Serialized Name: UeQOSFlow.fiveqi
        /// </param>
        /// <param name="uplinkGbrUplink">
        /// Uplink bit rate.
        /// Serialized Name: UeQOSFlow.gbr.uplink
        /// </param>
        /// <param name="downlinkGbrDownlink">
        /// Downlink bit rate.
        /// Serialized Name: UeQOSFlow.gbr.downlink
        /// </param>
        /// <param name="uplinkMbrUplink">
        /// Uplink bit rate.
        /// Serialized Name: UeQOSFlow.mbr.uplink
        /// </param>
        /// <param name="downlinkMbrDownlink">
        /// Downlink bit rate.
        /// Serialized Name: UeQOSFlow.mbr.downlink
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UEQosFlow(int qfi, int fiveqi, string uplinkGbrUplink, string downlinkGbrDownlink, string uplinkMbrUplink, string downlinkMbrDownlink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Qfi = qfi;
            Fiveqi = fiveqi;
            UplinkGbrUplink = uplinkGbrUplink;
            DownlinkGbrDownlink = downlinkGbrDownlink;
            UplinkMbrUplink = uplinkMbrUplink;
            DownlinkMbrDownlink = downlinkMbrDownlink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UEQosFlow"/> for deserialization. </summary>
        internal UEQosFlow()
        {
        }

        /// <summary>
        /// Qos Flow Identifier
        /// Serialized Name: UeQOSFlow.qfi
        /// </summary>
        [WirePath("qfi")]
        public int Qfi { get; set; }
        /// <summary>
        /// 5G QoS Identifier.
        /// Serialized Name: UeQOSFlow.fiveqi
        /// </summary>
        [WirePath("fiveqi")]
        public int Fiveqi { get; set; }
        /// <summary>
        /// Uplink bit rate.
        /// Serialized Name: UeQOSFlow.gbr.uplink
        /// </summary>
        [WirePath("gbr.uplink")]
        public string UplinkGbrUplink { get; set; }
        /// <summary>
        /// Downlink bit rate.
        /// Serialized Name: UeQOSFlow.gbr.downlink
        /// </summary>
        [WirePath("gbr.downlink")]
        public string DownlinkGbrDownlink { get; set; }
        /// <summary>
        /// Uplink bit rate.
        /// Serialized Name: UeQOSFlow.mbr.uplink
        /// </summary>
        [WirePath("mbr.uplink")]
        public string UplinkMbrUplink { get; set; }
        /// <summary>
        /// Downlink bit rate.
        /// Serialized Name: UeQOSFlow.mbr.downlink
        /// </summary>
        [WirePath("mbr.downlink")]
        public string DownlinkMbrDownlink { get; set; }
    }
}
