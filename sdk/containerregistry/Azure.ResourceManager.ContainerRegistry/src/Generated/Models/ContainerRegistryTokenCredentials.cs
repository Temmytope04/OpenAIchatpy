// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of the credentials that can be used for authenticating the token. </summary>
    public partial class ContainerRegistryTokenCredentials
    {
        /// <summary> Initializes a new instance of ContainerRegistryTokenCredentials. </summary>
        public ContainerRegistryTokenCredentials()
        {
            Certificates = new ChangeTrackingList<ContainerRegistryTokenCertificate>();
            Passwords = new ChangeTrackingList<ContainerRegistryTokenPassword>();
        }

        /// <summary> Initializes a new instance of ContainerRegistryTokenCredentials. </summary>
        /// <param name="certificates"></param>
        /// <param name="passwords"></param>
        internal ContainerRegistryTokenCredentials(IList<ContainerRegistryTokenCertificate> certificates, IList<ContainerRegistryTokenPassword> passwords)
        {
            Certificates = certificates;
            Passwords = passwords;
        }

        /// <summary> Gets the certificates. </summary>
        public IList<ContainerRegistryTokenCertificate> Certificates { get; }
        /// <summary> Gets the passwords. </summary>
        public IList<ContainerRegistryTokenPassword> Passwords { get; }
    }
}
