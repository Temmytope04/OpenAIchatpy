// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafMetricsResponse
    {
        internal static WafMetricsResponse DeserializeWafMetricsResponse(JsonElement element)
        {
            Optional<DateTimeOffset> dateTimeBegin = default;
            Optional<DateTimeOffset> dateTimeEnd = default;
            Optional<WafMetricsResponseGranularity> granularity = default;
            Optional<IReadOnlyList<WafMetricsResponseSeriesItem>> series = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeBegin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dateTimeEnd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("granularity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    granularity = new WafMetricsResponseGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("series"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WafMetricsResponseSeriesItem> array = new List<WafMetricsResponseSeriesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafMetricsResponseSeriesItem.DeserializeWafMetricsResponseSeriesItem(item));
                    }
                    series = array;
                    continue;
                }
            }
            return new WafMetricsResponse(Optional.ToNullable(dateTimeBegin), Optional.ToNullable(dateTimeEnd), Optional.ToNullable(granularity), Optional.ToList(series));
        }
    }
}
