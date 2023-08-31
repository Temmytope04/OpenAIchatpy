// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Monthly recurrence object. </summary>
    public partial class AlertProcessingRuleMonthlyRecurrence : AlertProcessingRuleRecurrence
    {
        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleMonthlyRecurrence"/>. </summary>
        /// <param name="daysOfMonth"> Specifies the values for monthly recurrence pattern. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="daysOfMonth"/> is null. </exception>
        public AlertProcessingRuleMonthlyRecurrence(IEnumerable<int> daysOfMonth)
        {
            Argument.AssertNotNull(daysOfMonth, nameof(daysOfMonth));

            DaysOfMonth = daysOfMonth.ToList();
            RecurrenceType = RecurrenceType.Monthly;
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleMonthlyRecurrence"/>. </summary>
        /// <param name="recurrenceType"> Specifies when the recurrence should be applied. </param>
        /// <param name="startOn"> Start time for recurrence. </param>
        /// <param name="endOn"> End time for recurrence. </param>
        /// <param name="daysOfMonth"> Specifies the values for monthly recurrence pattern. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertProcessingRuleMonthlyRecurrence(RecurrenceType recurrenceType, TimeSpan? startOn, TimeSpan? endOn, IList<int> daysOfMonth, Dictionary<string, BinaryData> rawData) : base(recurrenceType, startOn, endOn, rawData)
        {
            DaysOfMonth = daysOfMonth;
            RecurrenceType = recurrenceType;
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleMonthlyRecurrence"/> for deserialization. </summary>
        internal AlertProcessingRuleMonthlyRecurrence()
        {
        }

        /// <summary> Specifies the values for monthly recurrence pattern. </summary>
        public IList<int> DaysOfMonth { get; }
    }
}
