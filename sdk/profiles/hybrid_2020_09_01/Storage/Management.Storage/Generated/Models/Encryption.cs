// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The encryption settings on the storage account.
    /// </summary>
    public partial class Encryption
    {
        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        public Encryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        /// <param name="keySource">The encryption keySource (provider).
        /// Possible values (case-insensitive):  Microsoft.Storage,
        /// Microsoft.Keyvault. Possible values include: 'Microsoft.Storage',
        /// 'Microsoft.Keyvault'</param>
        /// <param name="services">List of services which support
        /// encryption.</param>
        /// <param name="requireInfrastructureEncryption">A boolean indicating
        /// whether or not the service applies a secondary layer of encryption
        /// with platform managed keys for data at rest.</param>
        /// <param name="keyVaultProperties">Properties provided by key
        /// vault.</param>
        public Encryption(string keySource, EncryptionServices services = default(EncryptionServices), bool? requireInfrastructureEncryption = default(bool?), KeyVaultProperties keyVaultProperties = default(KeyVaultProperties))
        {
            Services = services;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            KeyVaultProperties = keyVaultProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of services which support encryption.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public EncryptionServices Services { get; set; }

        /// <summary>
        /// Gets or sets the encryption keySource (provider). Possible values
        /// (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
        /// Possible values include: 'Microsoft.Storage', 'Microsoft.Keyvault'
        /// </summary>
        [JsonProperty(PropertyName = "keySource")]
        public string KeySource { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether or not the service
        /// applies a secondary layer of encryption with platform managed keys
        /// for data at rest.
        /// </summary>
        [JsonProperty(PropertyName = "requireInfrastructureEncryption")]
        public bool? RequireInfrastructureEncryption { get; set; }

        /// <summary>
        /// Gets or sets properties provided by key vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyvaultproperties")]
        public KeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeySource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeySource");
            }
        }
    }
}
