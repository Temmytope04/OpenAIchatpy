// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> SSH configuration for Linux-based VMs running on Azure. </summary>
    public partial class ContainerServiceSshConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshConfiguration"/>. </summary>
        /// <param name="publicKeys"> The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicKeys"/> is null. </exception>
        public ContainerServiceSshConfiguration(IEnumerable<ContainerServiceSshPublicKey> publicKeys)
        {
            Argument.AssertNotNull(publicKeys, nameof(publicKeys));

            PublicKeys = publicKeys.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshConfiguration"/>. </summary>
        /// <param name="publicKeys"> The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceSshConfiguration(IList<ContainerServiceSshPublicKey> publicKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PublicKeys = publicKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshConfiguration"/> for deserialization. </summary>
        internal ContainerServiceSshConfiguration()
        {
        }

        /// <summary> The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified. </summary>
        [WirePath("publicKeys")]
        public IList<ContainerServiceSshPublicKey> PublicKeys { get; }
    }
}
