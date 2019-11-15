﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Storage.Sas
{
    /// <summary>
    /// A <see cref="BlobSasQueryParameters"/> object represents the components
    /// that make up an Azure Storage Shared Access Signature's query
    /// parameters.  You can construct a new instance using
    /// <see cref="BlobSasBuilder"/>.
    ///
    /// For more information, <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/constructing-a-service-sas"/>.
    /// </summary>
    public sealed class BlobSasQueryParameters : SasQueryParameters
    {
        internal UserDelegationKeyProperties _keyProperties;
        /// <summary>
        /// Gets the Azure Active Directory object ID in GUID format.
        /// </summary>
        public string KeyObjectId => _keyProperties._objectId;

        /// <summary>
        /// Gets the Azure Active Directory tenant ID in GUID format
        /// </summary>
        public string KeyTenantId => _keyProperties._tenantId;

        /// <summary>
        /// Gets the time at which the key becomes valid.
        /// </summary>
        public DateTimeOffset KeyStartsOn => _keyProperties._startsOn;

        /// <summary>
        /// Gets the time at which the key becomes expires.
        /// </summary>
        public DateTimeOffset KeyExpiresOn => _keyProperties._expiresOn;

        /// <summary>
        /// Gets the Storage service that accepts the key.
        /// </summary>
        public string KeyService => _keyProperties._service;

        /// <summary>
        /// Gets the Storage service version that created the key.
        /// </summary>
        public string KeyVersion => _keyProperties._version;

        /// <summary>
        /// Gets empty shared access signature query parameters.
        /// </summary>
        public static new BlobSasQueryParameters Empty => new BlobSasQueryParameters();

        internal BlobSasQueryParameters()
            : base()
        {
        }

        /// <summary>
        /// Creates a new BlobSasQueryParameters instance.
        /// </summary>
        internal BlobSasQueryParameters (
            string version,
            AccountSasServices? services,
            AccountSasResourceTypes? resourceTypes,
            SasProtocol protocol,
            DateTimeOffset startsOn,
            DateTimeOffset expiresOn,
            SasIPRange ipRange,
            string identifier,
            string resource,
            string permissions,
            string signature,
            string keyOid = default,
            string keyTid = default,
            DateTimeOffset keyStart = default,
            DateTimeOffset keyExpiry = default,
            string keyService = default,
            string keyVersion = default,
            string cacheControl = default,
            string contentDisposition = default,
            string contentEncoding = default,
            string contentLanguage = default,
            string contentType = default)
            : base(
                version,
                services,
                resourceTypes,
                protocol,
                startsOn,
                expiresOn,
                ipRange,
                identifier,
                resource,
                permissions,
                signature,
                cacheControl,
                contentDisposition,
                contentEncoding,
                contentLanguage,
                contentType)
        {
            _keyProperties._objectId = keyOid;
            _keyProperties._tenantId = keyTid;
            _keyProperties._startsOn = keyStart;
            _keyProperties._expiresOn = keyExpiry;
            _keyProperties._service = keyService;
            _keyProperties._version = keyVersion;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        internal BlobSasQueryParameters (
            Dictionary<string, string> values)
            : base (values)
        {
            this.ParseKeyProperties(values);
        }

        /// <summary>
        /// Convert the SAS query parameters into a URL encoded query string.
        /// </summary>
        /// <returns>
        /// A URL encoded query string representing the SAS.
        /// </returns>
        public override string ToString()
        {
            return _keyProperties.ToString() + Encode();
        }
    }
}
