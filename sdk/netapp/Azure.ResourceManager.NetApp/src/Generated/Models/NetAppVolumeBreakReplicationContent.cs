// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Break replication request. </summary>
    public partial class NetAppVolumeBreakReplicationContent
    {
        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBreakReplicationContent"/>. </summary>
        public NetAppVolumeBreakReplicationContent()
        {
        }

        /// <summary> If replication is in status transferring and you want to force break the replication, set to true. </summary>
        public bool? ForceBreakReplication { get; set; }
    }
}
