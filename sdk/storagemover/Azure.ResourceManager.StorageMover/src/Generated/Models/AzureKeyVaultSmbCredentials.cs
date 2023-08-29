// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The Azure Key Vault secret URIs which store the credentials. </summary>
    public partial class AzureKeyVaultSmbCredentials : StorageMoverCredentials
    {
        /// <summary> Initializes a new instance of <see cref="AzureKeyVaultSmbCredentials"/>. </summary>
        public AzureKeyVaultSmbCredentials()
        {
            CredentialType = CredentialType.AzureKeyVaultSmb;
        }

        /// <summary> Initializes a new instance of <see cref="AzureKeyVaultSmbCredentials"/>. </summary>
        /// <param name="credentialType"> The Credentials type. </param>
        /// <param name="usernameUriString"> The Azure Key Vault secret URI which stores the username. Use empty string to clean-up existing value. </param>
        /// <param name="passwordUriString"> The Azure Key Vault secret URI which stores the password. Use empty string to clean-up existing value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureKeyVaultSmbCredentials(CredentialType credentialType, string usernameUriString, string passwordUriString, Dictionary<string, BinaryData> rawData) : base(credentialType, rawData)
        {
            UsernameUriString = usernameUriString;
            PasswordUriString = passwordUriString;
            CredentialType = credentialType;
        }

        /// <summary> The Azure Key Vault secret URI which stores the username. Use empty string to clean-up existing value. </summary>
        public string UsernameUriString { get; set; }
        /// <summary> The Azure Key Vault secret URI which stores the password. Use empty string to clean-up existing value. </summary>
        public string PasswordUriString { get; set; }
    }
}
