// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> A user delegation key. </summary>
    public partial class UserDelegationKey
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserDelegationKey"/>. </summary>
        /// <param name="signedObjectId"> The Azure Active Directory object ID in GUID format. </param>
        /// <param name="signedTenantId"> The Azure Active Directory tenant ID in GUID format. </param>
        /// <param name="signedStartsOn"> The date-time the key is active. </param>
        /// <param name="signedExpiresOn"> The date-time the key expires. </param>
        /// <param name="signedService"> Abbreviation of the Azure Storage service that accepts the key. </param>
        /// <param name="signedVersion"> The service version that created the key. </param>
        /// <param name="value"> The key as a base64 string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="signedObjectId"/>, <paramref name="signedTenantId"/>, <paramref name="signedService"/>, <paramref name="signedVersion"/> or <paramref name="value"/> is null. </exception>
        internal UserDelegationKey(string signedObjectId, string signedTenantId, DateTimeOffset signedStartsOn, DateTimeOffset signedExpiresOn, string signedService, string signedVersion, string value)
        {
            Argument.AssertNotNull(signedObjectId, nameof(signedObjectId));
            Argument.AssertNotNull(signedTenantId, nameof(signedTenantId));
            Argument.AssertNotNull(signedService, nameof(signedService));
            Argument.AssertNotNull(signedVersion, nameof(signedVersion));
            Argument.AssertNotNull(value, nameof(value));

            SignedObjectId = signedObjectId;
            SignedTenantId = signedTenantId;
            SignedStartsOn = signedStartsOn;
            SignedExpiresOn = signedExpiresOn;
            SignedService = signedService;
            SignedVersion = signedVersion;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="UserDelegationKey"/>. </summary>
        /// <param name="signedObjectId"> The Azure Active Directory object ID in GUID format. </param>
        /// <param name="signedTenantId"> The Azure Active Directory tenant ID in GUID format. </param>
        /// <param name="signedStartsOn"> The date-time the key is active. </param>
        /// <param name="signedExpiresOn"> The date-time the key expires. </param>
        /// <param name="signedService"> Abbreviation of the Azure Storage service that accepts the key. </param>
        /// <param name="signedVersion"> The service version that created the key. </param>
        /// <param name="value"> The key as a base64 string. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserDelegationKey(string signedObjectId, string signedTenantId, DateTimeOffset signedStartsOn, DateTimeOffset signedExpiresOn, string signedService, string signedVersion, string value, Dictionary<string, BinaryData> rawData)
        {
            SignedObjectId = signedObjectId;
            SignedTenantId = signedTenantId;
            SignedStartsOn = signedStartsOn;
            SignedExpiresOn = signedExpiresOn;
            SignedService = signedService;
            SignedVersion = signedVersion;
            Value = value;
            _rawData = rawData;
        }
    }
}
