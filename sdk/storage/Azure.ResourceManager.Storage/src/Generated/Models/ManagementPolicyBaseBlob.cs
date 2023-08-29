// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Management policy action for base blob. </summary>
    public partial class ManagementPolicyBaseBlob
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyBaseBlob"/>. </summary>
        public ManagementPolicyBaseBlob()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyBaseBlob"/>. </summary>
        /// <param name="tierToCool"> The function to tier blobs to cool storage. </param>
        /// <param name="tierToArchive"> The function to tier blobs to archive storage. </param>
        /// <param name="tierToCold"> The function to tier blobs to cold storage. </param>
        /// <param name="tierToHot"> The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts. </param>
        /// <param name="delete"> The function to delete the blob. </param>
        /// <param name="enableAutoTierToHotFromCool"> This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementPolicyBaseBlob(DateAfterModification tierToCool, DateAfterModification tierToArchive, DateAfterModification tierToCold, DateAfterModification tierToHot, DateAfterModification delete, bool? enableAutoTierToHotFromCool, Dictionary<string, BinaryData> rawData)
        {
            TierToCool = tierToCool;
            TierToArchive = tierToArchive;
            TierToCold = tierToCold;
            TierToHot = tierToHot;
            Delete = delete;
            EnableAutoTierToHotFromCool = enableAutoTierToHotFromCool;
            _rawData = rawData;
        }

        /// <summary> The function to tier blobs to cool storage. </summary>
        public DateAfterModification TierToCool { get; set; }
        /// <summary> The function to tier blobs to archive storage. </summary>
        public DateAfterModification TierToArchive { get; set; }
        /// <summary> The function to tier blobs to cold storage. </summary>
        public DateAfterModification TierToCold { get; set; }
        /// <summary> The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts. </summary>
        public DateAfterModification TierToHot { get; set; }
        /// <summary> The function to delete the blob. </summary>
        public DateAfterModification Delete { get; set; }
        /// <summary> This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan. </summary>
        public bool? EnableAutoTierToHotFromCool { get; set; }
    }
}
