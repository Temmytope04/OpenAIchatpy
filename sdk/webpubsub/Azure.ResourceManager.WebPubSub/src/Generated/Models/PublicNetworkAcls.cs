// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Network ACL. </summary>
    public partial class PublicNetworkAcls
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

        /// <summary> Initializes a new instance of <see cref="PublicNetworkAcls"/>. </summary>
        public PublicNetworkAcls()
        {
            Allow = new ChangeTrackingList<WebPubSubRequestType>();
            Deny = new ChangeTrackingList<WebPubSubRequestType>();
        }

        /// <summary> Initializes a new instance of <see cref="PublicNetworkAcls"/>. </summary>
        /// <param name="allow"> Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="deny"> Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicNetworkAcls(IList<WebPubSubRequestType> allow, IList<WebPubSubRequestType> deny, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Allow = allow;
            Deny = deny;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </summary>
        public IList<WebPubSubRequestType> Allow { get; }
        /// <summary> Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI. </summary>
        public IList<WebPubSubRequestType> Deny { get; }
    }
}
