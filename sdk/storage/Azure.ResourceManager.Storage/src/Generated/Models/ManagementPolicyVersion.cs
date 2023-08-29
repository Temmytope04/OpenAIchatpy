// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Management policy action for blob version. </summary>
    public partial class ManagementPolicyVersion
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyVersion"/>. </summary>
        public ManagementPolicyVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyVersion"/>. </summary>
        /// <param name="tierToCool"> The function to tier blob version to cool storage. </param>
        /// <param name="tierToArchive"> The function to tier blob version to archive storage. </param>
        /// <param name="tierToCold"> The function to tier blobs to cold storage. </param>
        /// <param name="tierToHot"> The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts. </param>
        /// <param name="delete"> The function to delete the blob version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementPolicyVersion(DateAfterCreation tierToCool, DateAfterCreation tierToArchive, DateAfterCreation tierToCold, DateAfterCreation tierToHot, DateAfterCreation delete, Dictionary<string, BinaryData> rawData)
        {
            TierToCool = tierToCool;
            TierToArchive = tierToArchive;
            TierToCold = tierToCold;
            TierToHot = tierToHot;
            Delete = delete;
            _rawData = rawData;
        }

        /// <summary> The function to tier blob version to cool storage. </summary>
        public DateAfterCreation TierToCool { get; set; }
        /// <summary> The function to tier blob version to archive storage. </summary>
        public DateAfterCreation TierToArchive { get; set; }
        /// <summary> The function to tier blobs to cold storage. </summary>
        public DateAfterCreation TierToCold { get; set; }
        /// <summary> The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts. </summary>
        public DateAfterCreation TierToHot { get; set; }
        /// <summary> The function to delete the blob version. </summary>
        public DateAfterCreation Delete { get; set; }
    }
}
