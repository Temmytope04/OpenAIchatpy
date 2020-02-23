// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.Search.Models
{
    /// <summary> Represents various service level limits. </summary>
    public partial class SearchServiceLimits
    {
        /// <summary> The maximum allowed fields per index. </summary>
        public int? MaxFieldsPerIndex { get; set; }
        /// <summary> The maximum depth which you can nest sub-fields in an index, including the top-level complex field. For example, a/b/c has a nesting depth of 3. </summary>
        public int? MaxFieldNestingDepthPerIndex { get; set; }
        /// <summary> The maximum number of fields of type Collection(Edm.ComplexType) allowed in an index. </summary>
        public int? MaxComplexCollectionFieldsPerIndex { get; set; }
        /// <summary> The maximum number of objects in complex collections allowed per document. </summary>
        public int? MaxComplexObjectsInCollectionsPerDocument { get; set; }
    }
}
