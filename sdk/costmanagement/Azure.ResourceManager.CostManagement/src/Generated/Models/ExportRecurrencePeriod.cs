// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The start and end date for recurrence schedule. </summary>
    public partial class ExportRecurrencePeriod
    {
        /// <summary> Initializes a new instance of ExportRecurrencePeriod. </summary>
        /// <param name="from"> The start date of recurrence. </param>
        public ExportRecurrencePeriod(DateTimeOffset @from)
        {
            From = @from;
        }

        /// <summary> Initializes a new instance of ExportRecurrencePeriod. </summary>
        /// <param name="from"> The start date of recurrence. </param>
        /// <param name="to"> The end date of recurrence. </param>
        internal ExportRecurrencePeriod(DateTimeOffset @from, DateTimeOffset? to)
        {
            From = @from;
            To = to;
        }

        /// <summary> The start date of recurrence. </summary>
        public DateTimeOffset From { get; set; }
        /// <summary> The end date of recurrence. </summary>
        public DateTimeOffset? To { get; set; }
    }
}
