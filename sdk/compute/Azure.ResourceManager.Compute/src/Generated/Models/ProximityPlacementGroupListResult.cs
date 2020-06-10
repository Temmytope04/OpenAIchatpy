// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Proximity Placement Group operation response. </summary>
    public partial class ProximityPlacementGroupListResult
    {
        /// <summary> Initializes a new instance of ProximityPlacementGroupListResult. </summary>
        /// <param name="value"> The list of proximity placement groups. </param>
        internal ProximityPlacementGroupListResult(IEnumerable<ProximityPlacementGroup> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of ProximityPlacementGroupListResult. </summary>
        /// <param name="value"> The list of proximity placement groups. </param>
        /// <param name="nextLink"> The URI to fetch the next page of proximity placement groups. </param>
        internal ProximityPlacementGroupListResult(IReadOnlyList<ProximityPlacementGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of proximity placement groups. </summary>
        public IReadOnlyList<ProximityPlacementGroup> Value { get; }
        /// <summary> The URI to fetch the next page of proximity placement groups. </summary>
        public string NextLink { get; }
    }
}
