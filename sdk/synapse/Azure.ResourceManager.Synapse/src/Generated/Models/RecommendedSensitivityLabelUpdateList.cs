// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of recommended sensitivity label update operations. </summary>
    public partial class RecommendedSensitivityLabelUpdateList
    {
        /// <summary> Initializes a new instance of RecommendedSensitivityLabelUpdateList. </summary>
        public RecommendedSensitivityLabelUpdateList()
        {
            Operations = new ChangeTrackingList<RecommendedSensitivityLabelUpdate>();
        }

        /// <summary> Gets the operations. </summary>
        public IList<RecommendedSensitivityLabelUpdate> Operations { get; }
    }
}
