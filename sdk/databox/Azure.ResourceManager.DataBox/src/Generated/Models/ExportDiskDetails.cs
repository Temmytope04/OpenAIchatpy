// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Export disk details. </summary>
    public partial class ExportDiskDetails
    {
        /// <summary> Initializes a new instance of ExportDiskDetails. </summary>
        internal ExportDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of ExportDiskDetails. </summary>
        /// <param name="manifestFile"> The relative path of the manifest file on the disk. </param>
        /// <param name="manifestHash"> The Base16-encoded MD5 hash of the manifest file on the disk. </param>
        /// <param name="backupManifestCloudPath"> Path to backed up manifest, only returned if enableManifestBackup is true. </param>
        internal ExportDiskDetails(string manifestFile, string manifestHash, string backupManifestCloudPath)
        {
            ManifestFile = manifestFile;
            ManifestHash = manifestHash;
            BackupManifestCloudPath = backupManifestCloudPath;
        }

        /// <summary> The relative path of the manifest file on the disk. </summary>
        public string ManifestFile { get; }
        /// <summary> The Base16-encoded MD5 hash of the manifest file on the disk. </summary>
        public string ManifestHash { get; }
        /// <summary> Path to backed up manifest, only returned if enableManifestBackup is true. </summary>
        public string BackupManifestCloudPath { get; }
    }
}
