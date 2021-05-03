// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Data.Purview.Scanning
{
    /// <summary> Client options for ScanningClient. </summary>
    public partial class ScanningClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2018_12_01_preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2018-12-01-preview". </summary>
            V2018_12_01_preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of ScanningClientOptions. </summary>
        public ScanningClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2018_12_01_preview => "2018-12-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
