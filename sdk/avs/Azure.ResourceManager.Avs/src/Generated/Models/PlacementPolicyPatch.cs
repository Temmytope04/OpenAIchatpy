// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An update of a DRS placement policy resource. </summary>
    public partial class PlacementPolicyPatch
    {
        /// <summary> Initializes a new instance of <see cref="PlacementPolicyPatch"/>. </summary>
        public PlacementPolicyPatch()
        {
            VmMembers = new ChangeTrackingList<ResourceIdentifier>();
            HostMembers = new ChangeTrackingList<string>();
        }

        /// <summary> Whether the placement policy is enabled or disabled. </summary>
        public PlacementPolicyState? State { get; set; }
        /// <summary> Virtual machine members list. </summary>
        public IList<ResourceIdentifier> VmMembers { get; }
        /// <summary> Host members list. </summary>
        public IList<string> HostMembers { get; }
        /// <summary> vm-host placement policy affinity strength (should/must). </summary>
        public VmHostPlacementPolicyAffinityStrength? AffinityStrength { get; set; }
        /// <summary> placement policy azure hybrid benefit opt-in type. </summary>
        public AzureHybridBenefitType? AzureHybridBenefitType { get; set; }
    }
}
