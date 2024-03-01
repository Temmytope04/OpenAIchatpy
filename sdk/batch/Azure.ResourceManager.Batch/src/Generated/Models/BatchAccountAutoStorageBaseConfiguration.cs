// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The properties related to the auto-storage account. </summary>
    public partial class BatchAccountAutoStorageBaseConfiguration
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

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageBaseConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountId"/> is null. </exception>
        public BatchAccountAutoStorageBaseConfiguration(ResourceIdentifier storageAccountId)
        {
            if (storageAccountId == null)
            {
                throw new ArgumentNullException(nameof(storageAccountId));
            }

            StorageAccountId = storageAccountId;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageBaseConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <param name="authenticationMode"> The authentication mode which the Batch service will use to manage the auto-storage account. </param>
        /// <param name="nodeIdentity"> The identity referenced here must be assigned to pools which have compute nodes that need access to auto-storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAccountAutoStorageBaseConfiguration(ResourceIdentifier storageAccountId, BatchAutoStorageAuthenticationMode? authenticationMode, ComputeNodeIdentityReference nodeIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccountId = storageAccountId;
            AuthenticationMode = authenticationMode;
            NodeIdentity = nodeIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageBaseConfiguration"/> for deserialization. </summary>
        internal BatchAccountAutoStorageBaseConfiguration()
        {
        }

        /// <summary> The resource ID of the storage account to be used for auto-storage account. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The authentication mode which the Batch service will use to manage the auto-storage account. </summary>
        public BatchAutoStorageAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> The identity referenced here must be assigned to pools which have compute nodes that need access to auto-storage. </summary>
        internal ComputeNodeIdentityReference NodeIdentity { get; set; }
        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public ResourceIdentifier NodeIdentityResourceId
        {
            get => NodeIdentity is null ? default : NodeIdentity.ResourceId;
            set
            {
                if (NodeIdentity is null)
                    NodeIdentity = new ComputeNodeIdentityReference();
                NodeIdentity.ResourceId = value;
            }
        }
    }
}
