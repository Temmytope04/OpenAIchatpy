// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The recurrence schedule. </summary>
    public partial class RecurrenceSchedule
    {
        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        public RecurrenceSchedule()
        {
            Minutes = new ChangeTrackingList<int>();
            Hours = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<DaysOfWeek>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<RecurrenceScheduleOccurrence>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        /// <param name="minutes"> The minutes. </param>
        /// <param name="hours"> The hours. </param>
        /// <param name="weekDays"> The days of the week. </param>
        /// <param name="monthDays"> The month days. </param>
        /// <param name="monthlyOccurrences"> The monthly occurrences. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RecurrenceSchedule(IList<int> minutes, IList<int> hours, IList<DaysOfWeek> weekDays, IList<int> monthDays, IList<RecurrenceScheduleOccurrence> monthlyOccurrences, IDictionary<string, BinaryData> additionalProperties)
        {
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The minutes. </summary>
        public IList<int> Minutes { get; }
        /// <summary> The hours. </summary>
        public IList<int> Hours { get; }
        /// <summary> The days of the week. </summary>
        public IList<DaysOfWeek> WeekDays { get; }
        /// <summary> The month days. </summary>
        public IList<int> MonthDays { get; }
        /// <summary> The monthly occurrences. </summary>
        public IList<RecurrenceScheduleOccurrence> MonthlyOccurrences { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
