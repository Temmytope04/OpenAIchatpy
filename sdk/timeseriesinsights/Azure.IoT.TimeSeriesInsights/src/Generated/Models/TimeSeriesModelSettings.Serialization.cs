// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesModelSettings
    {
        internal static TimeSeriesModelSettings DeserializeTimeSeriesModelSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<TimeSeriesIdProperty> timeSeriesIdProperties = default;
            string defaultTypeId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeSeriesIdProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesIdProperty> array = new List<TimeSeriesIdProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesIdProperty.DeserializeTimeSeriesIdProperty(item));
                    }
                    timeSeriesIdProperties = array;
                    continue;
                }
                if (property.NameEquals("defaultTypeId"u8))
                {
                    defaultTypeId = property.Value.GetString();
                    continue;
                }
            }
            return new TimeSeriesModelSettings(name, timeSeriesIdProperties ?? new ChangeTrackingList<TimeSeriesIdProperty>(), defaultTypeId);
        }
    }
}
