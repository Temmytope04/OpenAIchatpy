// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    internal static class AggregationTypeExtensions
    {
        public static string ToSerialString(this AggregationType value) => value switch
        {
            AggregationType.None => "None",
            AggregationType.Average => "Average",
            AggregationType.Count => "Count",
            AggregationType.Minimum => "Minimum",
            AggregationType.Maximum => "Maximum",
            AggregationType.Total => "Total",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AggregationType value.")
        };

        public static AggregationType ToAggregationType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.None;
            if (string.Equals(value, "Average", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.Average;
            if (string.Equals(value, "Count", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.Count;
            if (string.Equals(value, "Minimum", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.Minimum;
            if (string.Equals(value, "Maximum", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.Maximum;
            if (string.Equals(value, "Total", StringComparison.InvariantCultureIgnoreCase)) return AggregationType.Total;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AggregationType value.");
        }
    }
}
