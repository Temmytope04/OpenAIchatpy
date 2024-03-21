// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to add a new Azure Storage account while creating a new Data Lake Analytics account.
    /// Serialized Name: AddStorageAccountWithAccountParameters
    /// </summary>
    public partial class StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </param>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="accessKey"/> is null. </exception>
        public StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent(string name, string accessKey)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(accessKey, nameof(accessKey));

            Name = name;
            AccessKey = accessKey;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </param>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </param>
        /// <param name="suffix">
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.suffix
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent(string name, string accessKey, string suffix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessKey = accessKey;
            Suffix = suffix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent"/> for deserialization. </summary>
        internal StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent()
        {
        }

        /// <summary>
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </summary>
        public string AccessKey { get; }
        /// <summary>
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.suffix
        /// </summary>
        public string Suffix { get; set; }
    }
}
