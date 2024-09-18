// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents a RegistrationInfo definition. </summary>
    public partial class HostPoolRegistrationInfo
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

        /// <summary> Initializes a new instance of <see cref="HostPoolRegistrationInfo"/>. </summary>
        public HostPoolRegistrationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HostPoolRegistrationInfo"/>. </summary>
        /// <param name="expireOn"> Expiration time of registration token. </param>
        /// <param name="token"> The registration token base64 encoded string. </param>
        /// <param name="registrationTokenOperation"> The type of resetting the token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HostPoolRegistrationInfo(DateTimeOffset? expireOn, string token, HostPoolRegistrationTokenOperation? registrationTokenOperation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpireOn = expireOn;
            Token = token;
            RegistrationTokenOperation = registrationTokenOperation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Expiration time of registration token. </summary>
        [WirePath("expirationTime")]
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The registration token base64 encoded string. </summary>
        [WirePath("token")]
        public string Token { get; set; }
        /// <summary> The type of resetting the token. </summary>
        [WirePath("registrationTokenOperation")]
        public HostPoolRegistrationTokenOperation? RegistrationTokenOperation { get; set; }
    }
}
