// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Properties of the deleted vault. </summary>
    public partial class DeletedKeyVaultProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeletedKeyVaultProperties"/>. </summary>
        internal DeletedKeyVaultProperties()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeletedKeyVaultProperties"/>. </summary>
        /// <param name="vaultId"> The resource id of the original vault. </param>
        /// <param name="location"> The location of the original vault. </param>
        /// <param name="deletedOn"> The deleted date. </param>
        /// <param name="scheduledPurgeOn"> The scheduled purged date. </param>
        /// <param name="tags"> Tags of the original vault. </param>
        /// <param name="purgeProtectionEnabled"> Purge protection status of the original vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedKeyVaultProperties(ResourceIdentifier vaultId, AzureLocation? location, DateTimeOffset? deletedOn, DateTimeOffset? scheduledPurgeOn, IReadOnlyDictionary<string, string> tags, bool? purgeProtectionEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VaultId = vaultId;
            Location = location;
            DeletedOn = deletedOn;
            ScheduledPurgeOn = scheduledPurgeOn;
            Tags = tags;
            PurgeProtectionEnabled = purgeProtectionEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource id of the original vault. </summary>
        public ResourceIdentifier VaultId { get; }
        /// <summary> The location of the original vault. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The deleted date. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The scheduled purged date. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Tags of the original vault. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Purge protection status of the original vault. </summary>
        public bool? PurgeProtectionEnabled { get; }
    }
}
