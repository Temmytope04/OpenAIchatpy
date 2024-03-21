// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Import disk details. </summary>
    public partial class ImportDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="ImportDiskDetails"/>. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="bitLockerKey"> BitLocker key used to encrypt the disk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="manifestFile"/>, <paramref name="manifestHash"/> or <paramref name="bitLockerKey"/> is null. </exception>
        public ImportDiskDetails(string manifestFile, string manifestHash, string bitLockerKey)
        {
            Argument.AssertNotNull(manifestFile, nameof(manifestFile));
            Argument.AssertNotNull(manifestHash, nameof(manifestHash));
            Argument.AssertNotNull(bitLockerKey, nameof(bitLockerKey));

            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BitLockerKey = bitLockerKey;
        }

        /// <summary> Initializes a new instance of <see cref="ImportDiskDetails"/>. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="bitLockerKey"> BitLocker key used to encrypt the disk. </param>
        /// <param name="backupManifestCloudPath"> Path to backed up manifest, only returned if enableManifestBackup is true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImportDiskDetails(string manifestFile, string manifestHash, string bitLockerKey, string backupManifestCloudPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BitLockerKey = bitLockerKey;
            BackupManifestCloudPath = backupManifestCloudPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImportDiskDetails"/> for deserialization. </summary>
        internal ImportDiskDetails()
        {
        }

        /// <summary> The relative path of the manifest file on the disk. </summary>
        public string ManifestFile { get; set; }
        /// <summary> The Base16-encoded MD5 hash of the manifest file on the disk. </summary>
        public string ManifestHash { get; set; }
        /// <summary> BitLocker key used to encrypt the disk. </summary>
        public string BitLockerKey { get; set; }
        /// <summary> Path to backed up manifest, only returned if enableManifestBackup is true. </summary>
        public string BackupManifestCloudPath { get; }
    }
}
