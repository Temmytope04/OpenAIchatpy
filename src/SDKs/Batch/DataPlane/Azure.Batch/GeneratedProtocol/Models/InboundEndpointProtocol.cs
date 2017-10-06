// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InboundEndpointProtocol.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InboundEndpointProtocol
    {
        [EnumMember(Value = "tcp")]
        Tcp,
        [EnumMember(Value = "udp")]
        Udp
    }
    internal static class InboundEndpointProtocolEnumExtension
    {
        internal static string ToSerializedValue(this InboundEndpointProtocol? value)
        {
            return value == null ? null : ((InboundEndpointProtocol)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InboundEndpointProtocol value)
        {
            switch( value )
            {
                case InboundEndpointProtocol.Tcp:
                    return "tcp";
                case InboundEndpointProtocol.Udp:
                    return "udp";
            }
            return null;
        }

        internal static InboundEndpointProtocol? ParseInboundEndpointProtocol(this string value)
        {
            switch( value )
            {
                case "tcp":
                    return InboundEndpointProtocol.Tcp;
                case "udp":
                    return InboundEndpointProtocol.Udp;
            }
            return null;
        }
    }
}
