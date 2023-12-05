// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Supported deployment runtime version descriptor. </summary>
    public partial class AppPlatformSupportedRuntimeVersion
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedRuntimeVersion"/>. </summary>
        internal AppPlatformSupportedRuntimeVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformSupportedRuntimeVersion"/>. </summary>
        /// <param name="value"> The raw value which could be passed to deployment CRUD operations. </param>
        /// <param name="platform"> The platform of this runtime version (possible values: "Java" or ".NET"). </param>
        /// <param name="version"> The detailed version (major.minor) of the platform. </param>
        internal AppPlatformSupportedRuntimeVersion(AppPlatformSupportedRuntimeValue? value, AppPlatformSupportedRuntimePlatform? platform, string version)
        {
            Value = value;
            Platform = platform;
            Version = version;
        }

        /// <summary> The raw value which could be passed to deployment CRUD operations. </summary>
        public AppPlatformSupportedRuntimeValue? Value { get; }
        /// <summary> The platform of this runtime version (possible values: "Java" or ".NET"). </summary>
        public AppPlatformSupportedRuntimePlatform? Platform { get; }
        /// <summary> The detailed version (major.minor) of the platform. </summary>
        public string Version { get; }
    }
}
