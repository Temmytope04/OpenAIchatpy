// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.Search.Models
{
    /// <summary> Represents a resource&apos;s usage and quota. </summary>
    public partial class SearchResourceCounter
    {
        /// <summary> The resource usage amount. </summary>
        public long? Usage { get; set; }
        /// <summary> The resource amount quota. </summary>
        public long? Quota { get; set; }
    }
}
