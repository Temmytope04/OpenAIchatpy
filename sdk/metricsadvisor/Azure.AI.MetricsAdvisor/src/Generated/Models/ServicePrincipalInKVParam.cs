// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ServicePrincipalInKVParam. </summary>
    internal partial class ServicePrincipalInKVParam
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKVParam"/>. </summary>
        /// <param name="keyVaultEndpoint"> The Key Vault endpoint that storing the service principal. </param>
        /// <param name="keyVaultClientId"> The Client Id to access the Key Vault. </param>
        /// <param name="servicePrincipalIdNameInKV"> The secret name of the service principal's client Id in the Key Vault. </param>
        /// <param name="servicePrincipalSecretNameInKV"> The secret name of the service principal's client secret in the Key Vault. </param>
        /// <param name="tenantId"> The tenant id of your service principal. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultEndpoint"/>, <paramref name="keyVaultClientId"/>, <paramref name="servicePrincipalIdNameInKV"/>, <paramref name="servicePrincipalSecretNameInKV"/> or <paramref name="tenantId"/> is null. </exception>
        public ServicePrincipalInKVParam(string keyVaultEndpoint, string keyVaultClientId, string servicePrincipalIdNameInKV, string servicePrincipalSecretNameInKV, string tenantId)
        {
            Argument.AssertNotNull(keyVaultEndpoint, nameof(keyVaultEndpoint));
            Argument.AssertNotNull(keyVaultClientId, nameof(keyVaultClientId));
            Argument.AssertNotNull(servicePrincipalIdNameInKV, nameof(servicePrincipalIdNameInKV));
            Argument.AssertNotNull(servicePrincipalSecretNameInKV, nameof(servicePrincipalSecretNameInKV));
            Argument.AssertNotNull(tenantId, nameof(tenantId));

            KeyVaultEndpoint = keyVaultEndpoint;
            KeyVaultClientId = keyVaultClientId;
            ServicePrincipalIdNameInKV = servicePrincipalIdNameInKV;
            ServicePrincipalSecretNameInKV = servicePrincipalSecretNameInKV;
            TenantId = tenantId;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKVParam"/>. </summary>
        /// <param name="keyVaultEndpoint"> The Key Vault endpoint that storing the service principal. </param>
        /// <param name="keyVaultClientId"> The Client Id to access the Key Vault. </param>
        /// <param name="keyVaultClientSecret"> The Client Secret to access the Key Vault. </param>
        /// <param name="servicePrincipalIdNameInKV"> The secret name of the service principal's client Id in the Key Vault. </param>
        /// <param name="servicePrincipalSecretNameInKV"> The secret name of the service principal's client secret in the Key Vault. </param>
        /// <param name="tenantId"> The tenant id of your service principal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalInKVParam(string keyVaultEndpoint, string keyVaultClientId, string keyVaultClientSecret, string servicePrincipalIdNameInKV, string servicePrincipalSecretNameInKV, string tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyVaultEndpoint = keyVaultEndpoint;
            KeyVaultClientId = keyVaultClientId;
            KeyVaultClientSecret = keyVaultClientSecret;
            ServicePrincipalIdNameInKV = servicePrincipalIdNameInKV;
            ServicePrincipalSecretNameInKV = servicePrincipalSecretNameInKV;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInKVParam"/> for deserialization. </summary>
        internal ServicePrincipalInKVParam()
        {
        }

        /// <summary> The Key Vault endpoint that storing the service principal. </summary>
        public string KeyVaultEndpoint { get; set; }
        /// <summary> The Client Id to access the Key Vault. </summary>
        public string KeyVaultClientId { get; set; }
        /// <summary> The Client Secret to access the Key Vault. </summary>
        public string KeyVaultClientSecret { get; set; }
        /// <summary> The secret name of the service principal's client Id in the Key Vault. </summary>
        public string ServicePrincipalIdNameInKV { get; set; }
        /// <summary> The secret name of the service principal's client secret in the Key Vault. </summary>
        public string ServicePrincipalSecretNameInKV { get; set; }
        /// <summary> The tenant id of your service principal. </summary>
        public string TenantId { get; set; }
    }
}
