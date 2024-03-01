// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The properties of SMB share endpoint. </summary>
    public partial class SmbMountEndpointProperties : EndpointBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="SmbMountEndpointProperties"/>. </summary>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="shareName"> The name of the SMB share being exported from the server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> or <paramref name="shareName"/> is null. </exception>
        public SmbMountEndpointProperties(string host, string shareName)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (shareName == null)
            {
                throw new ArgumentNullException(nameof(shareName));
            }

            Host = host;
            ShareName = shareName;
            EndpointType = EndpointType.SmbMount;
        }

        /// <summary> Initializes a new instance of <see cref="SmbMountEndpointProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="shareName"> The name of the SMB share being exported from the server. </param>
        /// <param name="credentials"> The Azure Key Vault secret URIs which store the required credentials to access the SMB share. </param>
        internal SmbMountEndpointProperties(EndpointType endpointType, string description, StorageMoverProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, string host, string shareName, AzureKeyVaultSmbCredentials credentials) : base(endpointType, description, provisioningState, serializedAdditionalRawData)
        {
            Host = host;
            ShareName = shareName;
            Credentials = credentials;
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="SmbMountEndpointProperties"/> for deserialization. </summary>
        internal SmbMountEndpointProperties()
        {
        }

        /// <summary> The host name or IP address of the server exporting the file system. </summary>
        public string Host { get; set; }
        /// <summary> The name of the SMB share being exported from the server. </summary>
        public string ShareName { get; set; }
        /// <summary> The Azure Key Vault secret URIs which store the required credentials to access the SMB share. </summary>
        public AzureKeyVaultSmbCredentials Credentials { get; set; }
    }
}
