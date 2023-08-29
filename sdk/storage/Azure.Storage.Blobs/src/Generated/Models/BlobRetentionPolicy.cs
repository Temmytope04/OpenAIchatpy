// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> the retention policy which determines how long the associated data should persist. </summary>
    public partial class BlobRetentionPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobRetentionPolicy"/>. </summary>
        /// <param name="enabled"> Indicates whether a retention policy is enabled for the storage service. </param>
        /// <param name="days"> Indicates the number of days that metrics or logging or soft-deleted data should be retained. All data older than this value will be deleted. </param>
        /// <param name="allowPermanentDelete"> Indicates whether permanent delete is allowed on this storage account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobRetentionPolicy(bool enabled, int? days, bool? allowPermanentDelete, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            Days = days;
            AllowPermanentDelete = allowPermanentDelete;
            _rawData = rawData;
        }

        /// <summary> Indicates whether a retention policy is enabled for the storage service. </summary>
        public bool Enabled { get; set; }
        /// <summary> Indicates the number of days that metrics or logging or soft-deleted data should be retained. All data older than this value will be deleted. </summary>
        public int? Days { get; set; }
    }
}
