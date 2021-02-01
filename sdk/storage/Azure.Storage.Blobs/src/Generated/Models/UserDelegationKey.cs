// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> A user delegation key. </summary>
    public partial class UserDelegationKey
    {
        /// <summary> Initializes a new instance of UserDelegationKey. </summary>
        /// <param name="signedObjectId"> The Azure Active Directory object ID in GUID format. </param>
        /// <param name="signedTenantId"> The Azure Active Directory tenant ID in GUID format. </param>
        /// <param name="signedStartsOn"> The date-time the key is active. </param>
        /// <param name="signedExpiresOn"> The date-time the key expires. </param>
        /// <param name="signedService"> Abbreviation of the Azure Storage service that accepts the key. </param>
        /// <param name="signedVersion"> The service version that created the key. </param>
        /// <param name="value"> The key as a base64 string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="signedObjectId"/>, <paramref name="signedTenantId"/>, <paramref name="signedService"/>, <paramref name="signedVersion"/>, or <paramref name="value"/> is null. </exception>
        internal UserDelegationKey(string signedObjectId, string signedTenantId, DateTimeOffset signedStartsOn, DateTimeOffset signedExpiresOn, string signedService, string signedVersion, string value)
        {
            if (signedObjectId == null)
            {
                throw new ArgumentNullException(nameof(signedObjectId));
            }
            if (signedTenantId == null)
            {
                throw new ArgumentNullException(nameof(signedTenantId));
            }
            if (signedService == null)
            {
                throw new ArgumentNullException(nameof(signedService));
            }
            if (signedVersion == null)
            {
                throw new ArgumentNullException(nameof(signedVersion));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            SignedObjectId = signedObjectId;
            SignedTenantId = signedTenantId;
            SignedStartsOn = signedStartsOn;
            SignedExpiresOn = signedExpiresOn;
            SignedService = signedService;
            SignedVersion = signedVersion;
            Value = value;
        }
        /// <summary> Abbreviation of the Azure Storage service that accepts the key. </summary>
        public string SignedService { get; }
        /// <summary> The service version that created the key. </summary>
        public string SignedVersion { get; }
        /// <summary> The key as a base64 string. </summary>
        public string Value { get; }
    }
}
