// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> configuration for the servers offering subPlan. </summary>
    internal partial class DefenderForServersGcpOfferingSubPlan
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingSubPlan"/>. </summary>
        public DefenderForServersGcpOfferingSubPlan()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderForServersGcpOfferingSubPlan"/>. </summary>
        /// <param name="availableSubPlanType"> The available sub plans. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderForServersGcpOfferingSubPlan(AvailableSubPlanType? availableSubPlanType, Dictionary<string, BinaryData> rawData)
        {
            AvailableSubPlanType = availableSubPlanType;
            _rawData = rawData;
        }

        /// <summary> The available sub plans. </summary>
        public AvailableSubPlanType? AvailableSubPlanType { get; set; }
    }
}
