// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Storage Target space allocation properties. </summary>
    public partial class StorageTargetSpaceAllocation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageTargetSpaceAllocation"/>. </summary>
        public StorageTargetSpaceAllocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageTargetSpaceAllocation"/>. </summary>
        /// <param name="name"> Name of the storage target. </param>
        /// <param name="allocationPercentage"> The percentage of cache space allocated for this storage target. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTargetSpaceAllocation(string name, int? allocationPercentage, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            AllocationPercentage = allocationPercentage;
            _rawData = rawData;
        }

        /// <summary> Name of the storage target. </summary>
        public string Name { get; set; }
        /// <summary> The percentage of cache space allocated for this storage target. </summary>
        public int? AllocationPercentage { get; set; }
    }
}
