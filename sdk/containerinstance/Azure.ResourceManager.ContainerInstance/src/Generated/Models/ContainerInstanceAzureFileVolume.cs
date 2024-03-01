// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The properties of the Azure File volume. Azure File shares are mounted as volumes. </summary>
    public partial class ContainerInstanceAzureFileVolume
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

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceAzureFileVolume"/>. </summary>
        /// <param name="shareName"> The name of the Azure File share to be mounted as a volume. </param>
        /// <param name="storageAccountName"> The name of the storage account that contains the Azure File share. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareName"/> or <paramref name="storageAccountName"/> is null. </exception>
        public ContainerInstanceAzureFileVolume(string shareName, string storageAccountName)
        {
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }
            if (storageAccountName == null)
            {
                throw new ArgumentNullException(nameof(storageAccountName));
            }

            ShareName = shareName;
            StorageAccountName = storageAccountName;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceAzureFileVolume"/>. </summary>
        /// <param name="shareName"> The name of the Azure File share to be mounted as a volume. </param>
        /// <param name="isReadOnly"> The flag indicating whether the Azure File shared mounted as a volume is read-only. </param>
        /// <param name="storageAccountName"> The name of the storage account that contains the Azure File share. </param>
        /// <param name="storageAccountKey"> The storage account access key used to access the Azure File share. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerInstanceAzureFileVolume(string shareName, bool? isReadOnly, string storageAccountName, string storageAccountKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ShareName = shareName;
            IsReadOnly = isReadOnly;
            StorageAccountName = storageAccountName;
            StorageAccountKey = storageAccountKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceAzureFileVolume"/> for deserialization. </summary>
        internal ContainerInstanceAzureFileVolume()
        {
        }

        /// <summary> The name of the Azure File share to be mounted as a volume. </summary>
        public string ShareName { get; set; }
        /// <summary> The flag indicating whether the Azure File shared mounted as a volume is read-only. </summary>
        public bool? IsReadOnly { get; set; }
        /// <summary> The name of the storage account that contains the Azure File share. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> The storage account access key used to access the Azure File share. </summary>
        public string StorageAccountKey { get; set; }
    }
}
