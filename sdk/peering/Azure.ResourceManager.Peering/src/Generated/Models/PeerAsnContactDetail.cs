// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The contact detail class. </summary>
    public partial class PeerAsnContactDetail
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

        /// <summary> Initializes a new instance of <see cref="PeerAsnContactDetail"/>. </summary>
        public PeerAsnContactDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeerAsnContactDetail"/>. </summary>
        /// <param name="role"> The role of the contact. </param>
        /// <param name="email"> The e-mail address of the contact. </param>
        /// <param name="phone"> The phone number of the contact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeerAsnContactDetail(PeeringRole? role, string email, string phone, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Email = email;
            Phone = phone;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The role of the contact. </summary>
        public PeeringRole? Role { get; set; }
        /// <summary> The e-mail address of the contact. </summary>
        public string Email { get; set; }
        /// <summary> The phone number of the contact. </summary>
        public string Phone { get; set; }
    }
}
