// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The settings for the Cosmos DB database backing the service. </summary>
    public partial class HealthcareApisServiceCosmosDbConfiguration
    {
        /// <summary> Initializes a new instance of HealthcareApisServiceCosmosDbConfiguration. </summary>
        public HealthcareApisServiceCosmosDbConfiguration()
        {
        }

        /// <summary> Initializes a new instance of HealthcareApisServiceCosmosDbConfiguration. </summary>
        /// <param name="offerThroughput"> The provisioned throughput for the backing database. </param>
        /// <param name="keyVaultKeyUri"> The URI of the customer-managed key for the backing database. </param>
        internal HealthcareApisServiceCosmosDbConfiguration(int? offerThroughput, Uri keyVaultKeyUri)
        {
            OfferThroughput = offerThroughput;
            KeyVaultKeyUri = keyVaultKeyUri;
        }

        /// <summary> The provisioned throughput for the backing database. </summary>
        public int? OfferThroughput { get; set; }
        /// <summary> The URI of the customer-managed key for the backing database. </summary>
        public Uri KeyVaultKeyUri { get; set; }
    }
}
