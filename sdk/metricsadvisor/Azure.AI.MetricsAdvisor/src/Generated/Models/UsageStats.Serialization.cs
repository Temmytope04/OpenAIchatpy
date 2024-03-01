// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class UsageStats
    {
        internal static UsageStats DeserializeUsageStats(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            int? activeSeriesCount = default;
            int? allSeriesCount = default;
            int? metricsCount = default;
            int? dataFeedCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activeSeriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeSeriesCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allSeriesCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allSeriesCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("metricsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFeedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFeedCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new UsageStats(timestamp, activeSeriesCount, allSeriesCount, metricsCount, dataFeedCount);
        }
    }
}
