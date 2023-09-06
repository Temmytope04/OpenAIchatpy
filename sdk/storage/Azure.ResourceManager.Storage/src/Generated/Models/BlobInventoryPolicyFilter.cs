// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> An object that defines the blob inventory rule filter conditions. For 'Blob' definition.objectType all filter properties are applicable, 'blobTypes' is required and others are optional. For 'Container' definition.objectType only prefixMatch is applicable and is optional. </summary>
    public partial class BlobInventoryPolicyFilter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyFilter"/>. </summary>
        public BlobInventoryPolicyFilter()
        {
            IncludePrefix = new ChangeTrackingList<string>();
            ExcludePrefix = new ChangeTrackingList<string>();
            BlobTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicyFilter"/>. </summary>
        /// <param name="includePrefix"> An array of strings with maximum 10 blob prefixes to be included in the inventory. </param>
        /// <param name="excludePrefix"> An array of strings with maximum 10 blob prefixes to be excluded from the inventory. </param>
        /// <param name="blobTypes"> An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs. This field is required when definition.objectType property is set to 'Blob'. </param>
        /// <param name="includeBlobVersions"> Includes blob versions in blob inventory when value is set to true. The definition.schemaFields values 'VersionId and IsCurrentVersion' are required if this property is set to true, else they must be excluded. </param>
        /// <param name="includeSnapshots"> Includes blob snapshots in blob inventory when value is set to true. The definition.schemaFields value 'Snapshot' is required if this property is set to true, else it must be excluded. </param>
        /// <param name="includeDeleted"> For 'Container' definition.objectType the definition.schemaFields must include 'Deleted, Version, DeletedTime and RemainingRetentionDays'. For 'Blob' definition.objectType and HNS enabled storage accounts the definition.schemaFields must include 'DeletionId, Deleted, DeletedTime and RemainingRetentionDays' and for Hns disabled accounts the definition.schemaFields must include 'Deleted and RemainingRetentionDays', else it must be excluded. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobInventoryPolicyFilter(IList<string> includePrefix, IList<string> excludePrefix, IList<string> blobTypes, bool? includeBlobVersions, bool? includeSnapshots, bool? includeDeleted, Dictionary<string, BinaryData> rawData)
        {
            IncludePrefix = includePrefix;
            ExcludePrefix = excludePrefix;
            BlobTypes = blobTypes;
            IncludeBlobVersions = includeBlobVersions;
            IncludeSnapshots = includeSnapshots;
            IncludeDeleted = includeDeleted;
            _rawData = rawData;
        }

        /// <summary> An array of strings with maximum 10 blob prefixes to be included in the inventory. </summary>
        public IList<string> IncludePrefix { get; }
        /// <summary> An array of strings with maximum 10 blob prefixes to be excluded from the inventory. </summary>
        public IList<string> ExcludePrefix { get; }
        /// <summary> An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs. This field is required when definition.objectType property is set to 'Blob'. </summary>
        public IList<string> BlobTypes { get; }
        /// <summary> Includes blob versions in blob inventory when value is set to true. The definition.schemaFields values 'VersionId and IsCurrentVersion' are required if this property is set to true, else they must be excluded. </summary>
        public bool? IncludeBlobVersions { get; set; }
        /// <summary> Includes blob snapshots in blob inventory when value is set to true. The definition.schemaFields value 'Snapshot' is required if this property is set to true, else it must be excluded. </summary>
        public bool? IncludeSnapshots { get; set; }
        /// <summary> For 'Container' definition.objectType the definition.schemaFields must include 'Deleted, Version, DeletedTime and RemainingRetentionDays'. For 'Blob' definition.objectType and HNS enabled storage accounts the definition.schemaFields must include 'DeletionId, Deleted, DeletedTime and RemainingRetentionDays' and for Hns disabled accounts the definition.schemaFields must include 'Deleted and RemainingRetentionDays', else it must be excluded. </summary>
        public bool? IncludeDeleted { get; set; }
    }
}
