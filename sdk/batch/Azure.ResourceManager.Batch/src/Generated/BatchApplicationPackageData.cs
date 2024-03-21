// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchApplicationPackage data model.
    /// An application package which represents a particular version of an application.
    /// </summary>
    public partial class BatchApplicationPackageData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageData"/>. </summary>
        public BatchApplicationPackageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> The current state of the application package. </param>
        /// <param name="format"> The format of the application package, if the package is active. </param>
        /// <param name="storageUri"> The URL for the application package in Azure Storage. </param>
        /// <param name="storageUriExpireOn"> The UTC time at which the Azure Storage URL will expire. </param>
        /// <param name="lastActivatedOn"> The time at which the package was last activated, if the package is active. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplicationPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BatchApplicationPackageState? state, string format, Uri storageUri, DateTimeOffset? storageUriExpireOn, DateTimeOffset? lastActivatedOn, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            State = state;
            Format = format;
            StorageUri = storageUri;
            StorageUriExpireOn = storageUriExpireOn;
            LastActivatedOn = lastActivatedOn;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current state of the application package. </summary>
        public BatchApplicationPackageState? State { get; }
        /// <summary> The format of the application package, if the package is active. </summary>
        public string Format { get; }
        /// <summary> The URL for the application package in Azure Storage. </summary>
        public Uri StorageUri { get; }
        /// <summary> The UTC time at which the Azure Storage URL will expire. </summary>
        public DateTimeOffset? StorageUriExpireOn { get; }
        /// <summary> The time at which the package was last activated, if the package is active. </summary>
        public DateTimeOffset? LastActivatedOn { get; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
