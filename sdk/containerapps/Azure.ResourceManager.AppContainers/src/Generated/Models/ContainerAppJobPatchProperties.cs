// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The ContainerAppJobPatchProperties. </summary>
    public partial class ContainerAppJobPatchProperties
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobPatchProperties"/>. </summary>
        public ContainerAppJobPatchProperties()
        {
            OutboundIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobPatchProperties"/>. </summary>
        /// <param name="environmentId"> Resource ID of environment. </param>
        /// <param name="configuration"> Container Apps Job configuration properties. </param>
        /// <param name="template"> Container Apps job definition. </param>
        /// <param name="outboundIPAddresses"> Outbound IP Addresses of a container apps job. </param>
        /// <param name="eventStreamEndpoint"> The endpoint of the eventstream of the container apps job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppJobPatchProperties(string environmentId, ContainerAppJobConfiguration configuration, ContainerAppJobTemplate template, IList<string> outboundIPAddresses, string eventStreamEndpoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnvironmentId = environmentId;
            Configuration = configuration;
            Template = template;
            OutboundIPAddresses = outboundIPAddresses;
            EventStreamEndpoint = eventStreamEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID of environment. </summary>
        [WirePath("environmentId")]
        public string EnvironmentId { get; set; }
        /// <summary> Container Apps Job configuration properties. </summary>
        [WirePath("configuration")]
        public ContainerAppJobConfiguration Configuration { get; set; }
        /// <summary> Container Apps job definition. </summary>
        [WirePath("template")]
        public ContainerAppJobTemplate Template { get; set; }
        /// <summary> Outbound IP Addresses of a container apps job. </summary>
        [WirePath("outboundIpAddresses")]
        public IList<string> OutboundIPAddresses { get; }
        /// <summary> The endpoint of the eventstream of the container apps job. </summary>
        [WirePath("eventStreamEndpoint")]
        public string EventStreamEndpoint { get; set; }
    }
}
