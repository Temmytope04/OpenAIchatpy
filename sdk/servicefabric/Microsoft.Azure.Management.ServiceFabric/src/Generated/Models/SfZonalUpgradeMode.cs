// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{

    /// <summary>
    /// Defines values for SfZonalUpgradeMode.
    /// </summary>
    public static class SfZonalUpgradeMode
    {
        /// <summary>
        /// VMs under the node type are grouped into UDs and ignore the zone
        /// info in five UDs. This setting causes UDs across all zones to be
        /// upgraded at the same time. This deployment mode is faster for
        /// upgrades, we don't recommend it because it goes against the SDP
        /// guidelines, which state that the updates should be applied to one
        /// zone at a time.
        /// </summary>
        public const string Parallel = "Parallel";
        /// <summary>
        /// If this value is omitted or set to Hierarchical, VMs are grouped to
        /// reflect the zonal distribution in up to 15 UDs. Each of the three
        /// zones has five UDs. This ensures that the zones are updated one at
        /// a time, moving to next zone only after completing five UDs within
        /// the first zone. This update process is safer for the cluster and
        /// the user application.
        /// </summary>
        public const string Hierarchical = "Hierarchical";
    }
}
