// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the SSH public key. </summary>
    public partial class SshPublicKeyPatch : UpdateResource
    {
        /// <summary> Initializes a new instance of SshPublicKeyPatch. </summary>
        public SshPublicKeyPatch()
        {
        }

        /// <summary> SSH public key used to authenticate to a virtual machine through ssh. If this property is not initially provided when the resource is created, the publicKey property will be populated when generateKeyPair is called. If the public key is provided upon resource creation, the provided public key needs to be at least 2048-bit and in ssh-rsa format. </summary>
        public string PublicKey { get; set; }
    }
}
