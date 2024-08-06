// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of customer managed encryption key. </summary>
    public partial class CustomerManagedEncryption
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

        /// <summary> Initializes a new instance of <see cref="CustomerManagedEncryption"/>. </summary>
        public CustomerManagedEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomerManagedEncryption"/>. </summary>
        /// <param name="status"> Status of customer managed encryption key. </param>
        /// <param name="keyVaultProperties"> The key vault where the encryption key is stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomerManagedEncryption(AvsEncryptionState? status, EncryptionKeyVaultProperties keyVaultProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            KeyVaultProperties = keyVaultProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of customer managed encryption key. </summary>
        public AvsEncryptionState? Status { get; set; }
        /// <summary> The key vault where the encryption key is stored. </summary>
        public EncryptionKeyVaultProperties KeyVaultProperties { get; set; }
    }
}
