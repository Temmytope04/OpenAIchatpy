// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFeatureSetVersionCollectionGetAllOptions. </summary>
    public partial class MachineLearningFeatureSetVersionCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureSetVersionCollectionGetAllOptions"/>. </summary>
        public MachineLearningFeatureSetVersionCollectionGetAllOptions()
        {
        }

        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
        /// <summary> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </summary>
        public string Tags { get; set; }
        /// <summary> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </summary>
        public MachineLearningListViewType? ListViewType { get; set; }
        /// <summary> page size. </summary>
        public int? PageSize { get; set; }
        /// <summary> name for the featureset version. </summary>
        public string VersionName { get; set; }
        /// <summary> featureset version. </summary>
        public string Version { get; set; }
        /// <summary> description for the feature set version. </summary>
        public string Description { get; set; }
        /// <summary> createdBy user name. </summary>
        public string CreatedBy { get; set; }
        /// <summary> Specifies the featurestore stage. </summary>
        public string Stage { get; set; }
    }
}
