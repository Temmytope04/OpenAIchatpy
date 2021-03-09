// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureTableDataFeedPatch. </summary>
    public partial class AzureTableDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureTableDataFeedPatch. </summary>
        public AzureTableDataFeedPatch()
        {
            DataSourceType = DataFeedSourceType.AzureTable;
        }

        public AzureTableParameter DataSourceParameter { get; set; }
    }
}
