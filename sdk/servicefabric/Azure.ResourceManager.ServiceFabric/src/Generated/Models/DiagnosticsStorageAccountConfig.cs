// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The storage account information for storing Service Fabric diagnostic logs. </summary>
    public partial class DiagnosticsStorageAccountConfig
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticsStorageAccountConfig"/>. </summary>
        /// <param name="storageAccountName"> The Azure storage account name. </param>
        /// <param name="protectedAccountKeyName"> The protected diagnostics storage key name. </param>
        /// <param name="blobEndpoint"> The blob endpoint of the azure storage account. </param>
        /// <param name="queueEndpoint"> The queue endpoint of the azure storage account. </param>
        /// <param name="tableEndpoint"> The table endpoint of the azure storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountName"/>, <paramref name="protectedAccountKeyName"/>, <paramref name="blobEndpoint"/>, <paramref name="queueEndpoint"/> or <paramref name="tableEndpoint"/> is null. </exception>
        public DiagnosticsStorageAccountConfig(string storageAccountName, string protectedAccountKeyName, Uri blobEndpoint, Uri queueEndpoint, Uri tableEndpoint)
        {
            if (storageAccountName == null)
            {
                throw new ArgumentNullException(nameof(storageAccountName));
            }
            if (protectedAccountKeyName == null)
            {
                throw new ArgumentNullException(nameof(protectedAccountKeyName));
            }
            if (blobEndpoint == null)
            {
                throw new ArgumentNullException(nameof(blobEndpoint));
            }
            if (queueEndpoint == null)
            {
                throw new ArgumentNullException(nameof(queueEndpoint));
            }
            if (tableEndpoint == null)
            {
                throw new ArgumentNullException(nameof(tableEndpoint));
            }

            StorageAccountName = storageAccountName;
            ProtectedAccountKeyName = protectedAccountKeyName;
            BlobEndpoint = blobEndpoint;
            QueueEndpoint = queueEndpoint;
            TableEndpoint = tableEndpoint;
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticsStorageAccountConfig"/>. </summary>
        /// <param name="storageAccountName"> The Azure storage account name. </param>
        /// <param name="protectedAccountKeyName"> The protected diagnostics storage key name. </param>
        /// <param name="protectedAccountKeyName2"> The secondary protected diagnostics storage key name. If one of the storage account keys is rotated the cluster will fallback to using the other. </param>
        /// <param name="blobEndpoint"> The blob endpoint of the azure storage account. </param>
        /// <param name="queueEndpoint"> The queue endpoint of the azure storage account. </param>
        /// <param name="tableEndpoint"> The table endpoint of the azure storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticsStorageAccountConfig(string storageAccountName, string protectedAccountKeyName, string protectedAccountKeyName2, Uri blobEndpoint, Uri queueEndpoint, Uri tableEndpoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccountName = storageAccountName;
            ProtectedAccountKeyName = protectedAccountKeyName;
            ProtectedAccountKeyName2 = protectedAccountKeyName2;
            BlobEndpoint = blobEndpoint;
            QueueEndpoint = queueEndpoint;
            TableEndpoint = tableEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticsStorageAccountConfig"/> for deserialization. </summary>
        internal DiagnosticsStorageAccountConfig()
        {
        }

        /// <summary> The Azure storage account name. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> The protected diagnostics storage key name. </summary>
        public string ProtectedAccountKeyName { get; set; }
        /// <summary> The secondary protected diagnostics storage key name. If one of the storage account keys is rotated the cluster will fallback to using the other. </summary>
        public string ProtectedAccountKeyName2 { get; set; }
        /// <summary> The blob endpoint of the azure storage account. </summary>
        public Uri BlobEndpoint { get; set; }
        /// <summary> The queue endpoint of the azure storage account. </summary>
        public Uri QueueEndpoint { get; set; }
        /// <summary> The table endpoint of the azure storage account. </summary>
        public Uri TableEndpoint { get; set; }
    }
}
