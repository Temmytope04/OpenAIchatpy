// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing storage account input. </summary>
    public partial class ExistingStorageAccount : StorageAccountCustomDetails
    {
        /// <summary> Initializes a new instance of ExistingStorageAccount. </summary>
        /// <param name="azureStorageAccountId"> The storage account Arm Id. Throw error, if resource does not exists. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureStorageAccountId"/> is null. </exception>
        public ExistingStorageAccount(string azureStorageAccountId)
        {
            if (azureStorageAccountId == null)
            {
                throw new ArgumentNullException(nameof(azureStorageAccountId));
            }

            AzureStorageAccountId = azureStorageAccountId;
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of ExistingStorageAccount. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="azureStorageAccountId"> The storage account Arm Id. Throw error, if resource does not exists. </param>
        internal ExistingStorageAccount(string resourceType, string azureStorageAccountId) : base(resourceType)
        {
            AzureStorageAccountId = azureStorageAccountId;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> The storage account Arm Id. Throw error, if resource does not exists. </summary>
        public string AzureStorageAccountId { get; set; }
    }
}
