// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of a private endpoint connection. </summary>
    public partial class IotHubPrivateEndpointConnectionProperties
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

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="connectionState"> The current state of a private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionState"/> is null. </exception>
        public IotHubPrivateEndpointConnectionProperties(IotHubPrivateLinkServiceConnectionState connectionState)
        {
            Argument.AssertNotNull(connectionState, nameof(connectionState));

            ConnectionState = connectionState;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpoint"> The private endpoint property of a private endpoint connection. </param>
        /// <param name="connectionState"> The current state of a private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubPrivateEndpointConnectionProperties(SubResource privateEndpoint, IotHubPrivateLinkServiceConnectionState connectionState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubPrivateEndpointConnectionProperties"/> for deserialization. </summary>
        internal IotHubPrivateEndpointConnectionProperties()
        {
        }

        /// <summary> The private endpoint property of a private endpoint connection. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> The current state of a private endpoint connection. </summary>
        public IotHubPrivateLinkServiceConnectionState ConnectionState { get; set; }
    }
}
