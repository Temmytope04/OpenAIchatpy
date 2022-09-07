// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Daily recurrence object.
    /// Serialized Name: DailyRecurrence
    /// </summary>
    public partial class DailyRecurrence : AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of DailyRecurrence. </summary>
        public DailyRecurrence()
        {
            RecurrenceType = RecurrenceType.Daily;
        }

        /// <summary> Initializes a new instance of DailyRecurrence. </summary>
        /// <param name="recurrenceType">
        /// Specifies when the recurrence should be applied.
        /// Serialized Name: Recurrence.recurrenceType
        /// </param>
        /// <param name="startOn">
        /// Start time for recurrence.
        /// Serialized Name: Recurrence.startTime
        /// </param>
        /// <param name="endOn">
        /// End time for recurrence.
        /// Serialized Name: Recurrence.endTime
        /// </param>
        internal DailyRecurrence(RecurrenceType recurrenceType, DateTimeOffset? startOn, DateTimeOffset? endOn) : base(recurrenceType, startOn, endOn)
        {
            RecurrenceType = recurrenceType;
        }
    }
}
