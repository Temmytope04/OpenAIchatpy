// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> KPack ClusterStack properties payload. </summary>
    public partial class AppPlatformClusterStackProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformClusterStackProperties"/>. </summary>
        public AppPlatformClusterStackProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformClusterStackProperties"/>. </summary>
        /// <param name="id"> Id of the ClusterStack. </param>
        /// <param name="version"> Version of the ClusterStack. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformClusterStackProperties(string id, string version, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> Id of the ClusterStack. </summary>
        public string Id { get; set; }
        /// <summary> Version of the ClusterStack. </summary>
        public string Version { get; set; }
    }
}
