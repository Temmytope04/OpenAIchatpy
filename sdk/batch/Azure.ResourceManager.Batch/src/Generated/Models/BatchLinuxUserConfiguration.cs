// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Properties used to create a user account on a Linux node. </summary>
    public partial class BatchLinuxUserConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchLinuxUserConfiguration"/>. </summary>
        public BatchLinuxUserConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchLinuxUserConfiguration"/>. </summary>
        /// <param name="uid"> The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the uid. </param>
        /// <param name="gid"> The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the gid. </param>
        /// <param name="sshPrivateKey"> The private key must not be password protected. The private key is used to automatically configure asymmetric-key based authentication for SSH between nodes in a Linux pool when the pool's enableInterNodeCommunication property is true (it is ignored if enableInterNodeCommunication is false). It does this by placing the key pair into the user's .ssh directory. If not specified, password-less SSH is not configured between nodes (no modification of the user's .ssh directory is done). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchLinuxUserConfiguration(int? uid, int? gid, string sshPrivateKey, Dictionary<string, BinaryData> rawData)
        {
            Uid = uid;
            Gid = gid;
            SshPrivateKey = sshPrivateKey;
            _rawData = rawData;
        }

        /// <summary> The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the uid. </summary>
        public int? Uid { get; set; }
        /// <summary> The uid and gid properties must be specified together or not at all. If not specified the underlying operating system picks the gid. </summary>
        public int? Gid { get; set; }
        /// <summary> The private key must not be password protected. The private key is used to automatically configure asymmetric-key based authentication for SSH between nodes in a Linux pool when the pool's enableInterNodeCommunication property is true (it is ignored if enableInterNodeCommunication is false). It does this by placing the key pair into the user's .ssh directory. If not specified, password-less SSH is not configured between nodes (no modification of the user's .ssh directory is done). </summary>
        public string SshPrivateKey { get; set; }
    }
}
