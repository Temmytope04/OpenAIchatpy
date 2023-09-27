// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> The node upgrade image version. </summary>
    public partial class NodeImageVersion
    {
        /// <summary> Initializes a new instance of NodeImageVersion. </summary>
        internal NodeImageVersion()
        {
        }

        /// <summary> Initializes a new instance of NodeImageVersion. </summary>
        /// <param name="version"> The image version to upgrade the nodes to (e.g., 'AKSUbuntu-1804gen2containerd-2022.12.13'). </param>
        internal NodeImageVersion(string version)
        {
            Version = version;
        }

        /// <summary> The image version to upgrade the nodes to (e.g., 'AKSUbuntu-1804gen2containerd-2022.12.13'). </summary>
        public string Version { get; }
    }
}
