// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list statistics operation. </summary>
    internal partial class AutomationAccountStatisticsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationAccountStatisticsListResult"/>. </summary>
        internal AutomationAccountStatisticsListResult()
        {
            Value = new ChangeTrackingList<AutomationAccountStatistics>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationAccountStatisticsListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of statistics. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationAccountStatisticsListResult(IReadOnlyList<AutomationAccountStatistics> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of statistics. </summary>
        public IReadOnlyList<AutomationAccountStatistics> Value { get; }
    }
}
