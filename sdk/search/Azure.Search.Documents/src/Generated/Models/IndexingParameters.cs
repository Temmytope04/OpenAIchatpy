// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents parameters for indexer execution. </summary>
    public partial class IndexingParameters
    {
        /// <summary> Initializes a new instance of <see cref="IndexingParameters"/>. </summary>
        /// <param name="batchSize"> The number of items that are read from the data source and indexed as a single batch in order to improve performance. The default depends on the data source type. </param>
        /// <param name="maxFailedItems"> The maximum number of items that can fail indexing for indexer execution to still be considered successful. -1 means no limit. Default is 0. </param>
        /// <param name="maxFailedItemsPerBatch"> The maximum number of items in a single batch that can fail indexing for the batch to still be considered successful. -1 means no limit. Default is 0. </param>
        /// <param name="indexingParametersConfiguration"> A dictionary of indexer-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </param>
        internal IndexingParameters(int? batchSize, int? maxFailedItems, int? maxFailedItemsPerBatch, IndexingParametersConfiguration indexingParametersConfiguration)
        {
            BatchSize = batchSize;
            MaxFailedItems = maxFailedItems;
            MaxFailedItemsPerBatch = maxFailedItemsPerBatch;
            IndexingParametersConfiguration = indexingParametersConfiguration;
        }

        /// <summary> The number of items that are read from the data source and indexed as a single batch in order to improve performance. The default depends on the data source type. </summary>
        public int? BatchSize { get; set; }
        /// <summary> The maximum number of items that can fail indexing for indexer execution to still be considered successful. -1 means no limit. Default is 0. </summary>
        public int? MaxFailedItems { get; set; }
        /// <summary> The maximum number of items in a single batch that can fail indexing for the batch to still be considered successful. -1 means no limit. Default is 0. </summary>
        public int? MaxFailedItemsPerBatch { get; set; }
    }
}
