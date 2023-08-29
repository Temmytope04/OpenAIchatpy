// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Number of unauthorized operations is not in allowed range. </summary>
    public partial class UnauthorizedOperationsNotInAllowedRange : TimeWindowCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="UnauthorizedOperationsNotInAllowedRange"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        public UnauthorizedOperationsNotInAllowedRange(bool isEnabled, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(isEnabled, minThreshold, maxThreshold, timeWindowSize)
        {
            RuleType = "UnauthorizedOperationsNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="UnauthorizedOperationsNotInAllowedRange"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnauthorizedOperationsNotInAllowedRange(string displayName, string description, bool isEnabled, string ruleType, int minThreshold, int maxThreshold, TimeSpan timeWindowSize, Dictionary<string, BinaryData> rawData) : base(displayName, description, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize, rawData)
        {
            RuleType = ruleType ?? "UnauthorizedOperationsNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="UnauthorizedOperationsNotInAllowedRange"/> for deserialization. </summary>
        internal UnauthorizedOperationsNotInAllowedRange()
        {
        }
    }
}
