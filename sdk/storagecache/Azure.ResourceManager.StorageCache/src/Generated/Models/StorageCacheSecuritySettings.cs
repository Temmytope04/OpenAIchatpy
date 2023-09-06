// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache security settings. </summary>
    internal partial class StorageCacheSecuritySettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheSecuritySettings"/>. </summary>
        public StorageCacheSecuritySettings()
        {
            AccessPolicies = new ChangeTrackingList<NfsAccessPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheSecuritySettings"/>. </summary>
        /// <param name="accessPolicies"> NFS access policies defined for this cache. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheSecuritySettings(IList<NfsAccessPolicy> accessPolicies, Dictionary<string, BinaryData> rawData)
        {
            AccessPolicies = accessPolicies;
            _rawData = rawData;
        }

        /// <summary> NFS access policies defined for this cache. </summary>
        public IList<NfsAccessPolicy> AccessPolicies { get; }
    }
}
