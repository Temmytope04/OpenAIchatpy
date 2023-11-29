// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> filters over knowledge base. </summary>
    public partial class QueryFilters
    {
        /// <summary> Initializes a new instance of <see cref="QueryFilters"/>. </summary>
        public QueryFilters()
        {
            SourceFilter = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryFilters"/>. </summary>
        /// <param name="metadataFilter"> Find QnAs that are associated with the given list of metadata. </param>
        /// <param name="sourceFilter"> Find QnAs that are associated with any of the given list of sources in knowledge base. </param>
        /// <param name="logicalOperation"> Logical operation used to join metadata filter with source filter. </param>
        internal QueryFilters(MetadataFilter metadataFilter, IList<string> sourceFilter, LogicalOperationKind? logicalOperation)
        {
            MetadataFilter = metadataFilter;
            SourceFilter = sourceFilter;
            LogicalOperation = logicalOperation;
        }

        /// <summary> Find QnAs that are associated with the given list of metadata. </summary>
        public MetadataFilter MetadataFilter { get; set; }
        /// <summary> Find QnAs that are associated with any of the given list of sources in knowledge base. </summary>
        public IList<string> SourceFilter { get; }
        /// <summary> Logical operation used to join metadata filter with source filter. </summary>
        public LogicalOperationKind? LogicalOperation { get; set; }
    }
}
