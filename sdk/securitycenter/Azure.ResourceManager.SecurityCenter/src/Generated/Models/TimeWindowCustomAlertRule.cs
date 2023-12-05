// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// A custom alert rule that checks if the number of activities (depends on the custom alert type) in a time window is within the given range.
    /// Please note <see cref="TimeWindowCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TwinUpdatesNotInAllowedRange"/> and <see cref="UnauthorizedOperationsNotInAllowedRange"/>.
    /// </summary>
    public partial class TimeWindowCustomAlertRule : ThresholdCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="TimeWindowCustomAlertRule"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        public TimeWindowCustomAlertRule(bool isEnabled, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(isEnabled, minThreshold, maxThreshold)
        {
            TimeWindowSize = timeWindowSize;
            RuleType = "TimeWindowCustomAlertRule";
        }

        /// <summary> Initializes a new instance of <see cref="TimeWindowCustomAlertRule"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        internal TimeWindowCustomAlertRule(string displayName, string description, bool isEnabled, string ruleType, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(displayName, description, isEnabled, ruleType, minThreshold, maxThreshold)
        {
            TimeWindowSize = timeWindowSize;
            RuleType = ruleType ?? "TimeWindowCustomAlertRule";
        }

        /// <summary> The time window size in iso8601 format. </summary>
        public TimeSpan TimeWindowSize { get; set; }
    }
}
