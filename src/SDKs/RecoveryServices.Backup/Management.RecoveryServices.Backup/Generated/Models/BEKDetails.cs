// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// BEK is bitlocker encrpytion key.
    /// </summary>
    public partial class BEKDetails
    {
        /// <summary>
        /// Initializes a new instance of the BEKDetails class.
        /// </summary>
        public BEKDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BEKDetails class.
        /// </summary>
        /// <param name="secretUrl">Secret is BEK.</param>
        /// <param name="secretVaultId">ID of the Key Vault where this Secret
        /// is stored.</param>
        /// <param name="secretData">BEK data.</param>
        public BEKDetails(string secretUrl = default(string), string secretVaultId = default(string), string secretData = default(string))
        {
            SecretUrl = secretUrl;
            SecretVaultId = secretVaultId;
            SecretData = secretData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets secret is BEK.
        /// </summary>
        [JsonProperty(PropertyName = "secretUrl")]
        public string SecretUrl { get; set; }

        /// <summary>
        /// Gets or sets ID of the Key Vault where this Secret is stored.
        /// </summary>
        [JsonProperty(PropertyName = "secretVaultId")]
        public string SecretVaultId { get; set; }

        /// <summary>
        /// Gets or sets BEK data.
        /// </summary>
        [JsonProperty(PropertyName = "secretData")]
        public string SecretData { get; set; }

    }
}
