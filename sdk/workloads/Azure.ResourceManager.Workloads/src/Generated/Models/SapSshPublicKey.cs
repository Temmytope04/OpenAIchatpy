// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed. </summary>
    public partial class SapSshPublicKey
    {
        /// <summary> Initializes a new instance of SapSshPublicKey. </summary>
        public SapSshPublicKey()
        {
        }

        /// <summary> Initializes a new instance of SapSshPublicKey. </summary>
        /// <param name="keyData"> SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in ssh-rsa format. &lt;br&gt;&lt;br&gt; For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed). </param>
        internal SapSshPublicKey(string keyData)
        {
            KeyData = keyData;
        }

        /// <summary> SSH public key certificate used to authenticate with the VM through ssh. The key needs to be at least 2048-bit and in ssh-rsa format. &lt;br&gt;&lt;br&gt; For creating ssh keys, see [Create SSH keys on Linux and Mac for Linux VMs in Azure](https://docs.microsoft.com/azure/virtual-machines/linux/create-ssh-keys-detailed). </summary>
        public string KeyData { get; set; }
    }
}
