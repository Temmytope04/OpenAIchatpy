// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the service task to upload an OCI driver. </summary>
    internal partial class UploadOciDriverTaskInput
    {
        /// <summary> Initializes a new instance of UploadOciDriverTaskInput. </summary>
        public UploadOciDriverTaskInput()
        {
        }

        /// <summary> Initializes a new instance of UploadOciDriverTaskInput. </summary>
        /// <param name="driverShare"> File share information for the OCI driver archive. </param>
        internal UploadOciDriverTaskInput(FileShare driverShare)
        {
            DriverShare = driverShare;
        }

        /// <summary> File share information for the OCI driver archive. </summary>
        public FileShare DriverShare { get; set; }
    }
}
