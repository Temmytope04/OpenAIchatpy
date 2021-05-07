// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesIdProperty
    {
        internal static TimeSeriesIdProperty DeserializeTimeSeriesIdProperty(JsonElement element)
        {
            Optional<string> name = default;
            Optional<TimeSeriesIdPropertyTypes> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new TimeSeriesIdPropertyTypes(property.Value.GetString());
                    continue;
                }
            }
            return new TimeSeriesIdProperty(name.Value, Optional.ToNullable(type));
        }
    }
}
