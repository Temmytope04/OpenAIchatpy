// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class SubscriptionScopeMetricResponse
    {
        internal static SubscriptionScopeMetricResponse DeserializeSubscriptionScopeMetricResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> cost = default;
            string timespan = default;
            Optional<TimeSpan> interval = default;
            Optional<string> @namespace = default;
            Optional<string> resourceregion = default;
            IReadOnlyList<SubscriptionMonitorMetric> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timespan"u8))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<SubscriptionMonitorMetric> array = new List<SubscriptionMonitorMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubscriptionMonitorMetric.DeserializeSubscriptionMonitorMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SubscriptionScopeMetricResponse(Optional.ToNullable(cost), timespan, Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, value);
        }
    }
}
