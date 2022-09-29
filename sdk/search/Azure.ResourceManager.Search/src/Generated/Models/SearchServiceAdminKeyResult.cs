// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing the primary and secondary admin API keys for a given Azure Cognitive Search service. </summary>
    public partial class SearchServiceAdminKeyResult
    {
        /// <summary> Initializes a new instance of SearchServiceAdminKeyResult. </summary>
        internal SearchServiceAdminKeyResult()
        {
        }

        /// <summary> Initializes a new instance of SearchServiceAdminKeyResult. </summary>
        /// <param name="primaryKey"> The primary admin API key of the search service. </param>
        /// <param name="secondaryKey"> The secondary admin API key of the search service. </param>
        internal SearchServiceAdminKeyResult(string primaryKey, string secondaryKey)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary> The primary admin API key of the search service. </summary>
        public string PrimaryKey { get; }
        /// <summary> The secondary admin API key of the search service. </summary>
        public string SecondaryKey { get; }
    }
}
