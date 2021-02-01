﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// A user delegation key.
    /// </summary>
    public partial class UserDelegationKey
    {
        /// <summary>
        /// The Azure Active Directory object ID in GUID format.
        /// </summary>
        [CodeGenMember("SignedOid")]
        public string SignedObjectId { get; internal set; }

        /// <summary>
        /// The Azure Active Directory tenant ID in GUID format.
        /// </summary>
        [CodeGenMember("SignedTid")]
        public string SignedTenantId { get; internal set; }

        /// <summary>
        /// The date-time the key expires.
        /// </summary>
        [CodeGenMember("SignedExpiry")]
        public DateTimeOffset SignedExpiresOn { get; internal set; }

        /// <summary>
        /// The date-time the key is active.
        /// </summary>
        [CodeGenMember("SignedStart")]
        public DateTimeOffset SignedStartsOn { get; internal set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        internal UserDelegationKey() { }
    }
}
