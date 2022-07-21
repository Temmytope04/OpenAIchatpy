// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VPN client root certificate of virtual network gateway. </summary>
    public partial class VpnClientRootCertificate : NetworkResourceData
    {
        /// <summary> Initializes a new instance of VpnClientRootCertificate. </summary>
        /// <param name="publicCertData"> The certificate public data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicCertData"/> is null. </exception>
        public VpnClientRootCertificate(BinaryData publicCertData)
        {
            if (publicCertData == null)
            {
                throw new ArgumentNullException(nameof(publicCertData));
            }

            PublicCertData = publicCertData;
        }

        /// <summary> Initializes a new instance of VpnClientRootCertificate. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="publicCertData"> The certificate public data. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN client root certificate resource. </param>
        internal VpnClientRootCertificate(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, BinaryData publicCertData, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            PublicCertData = publicCertData;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The certificate public data. </summary>
        public BinaryData PublicCertData { get; set; }
        /// <summary> The provisioning state of the VPN client root certificate resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
