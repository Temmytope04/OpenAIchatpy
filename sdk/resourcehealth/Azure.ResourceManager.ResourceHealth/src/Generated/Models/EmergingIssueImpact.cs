// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Object of the emerging issue impact on services and regions. </summary>
    public partial class EmergingIssueImpact
    {
        /// <summary> Initializes a new instance of EmergingIssueImpact. </summary>
        internal EmergingIssueImpact()
        {
            Regions = new ChangeTrackingList<EmergingIssueImpactedRegion>();
        }

        /// <summary> Initializes a new instance of EmergingIssueImpact. </summary>
        /// <param name="id"> The impacted service id. </param>
        /// <param name="name"> The impacted service name. </param>
        /// <param name="regions"> The list of impacted regions for corresponding emerging issues. </param>
        internal EmergingIssueImpact(string id, string name, IReadOnlyList<EmergingIssueImpactedRegion> regions)
        {
            Id = id;
            Name = name;
            Regions = regions;
        }

        /// <summary> The impacted service id. </summary>
        public string Id { get; }
        /// <summary> The impacted service name. </summary>
        public string Name { get; }
        /// <summary> The list of impacted regions for corresponding emerging issues. </summary>
        public IReadOnlyList<EmergingIssueImpactedRegion> Regions { get; }
    }
}
