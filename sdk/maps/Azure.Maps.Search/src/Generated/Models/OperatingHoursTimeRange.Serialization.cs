// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class OperatingHoursTimeRange
    {
        internal static OperatingHoursTimeRange DeserializeOperatingHoursTimeRange(JsonElement element)
        {
            Optional<OperatingHoursTime> startTime = default;
            Optional<OperatingHoursTime> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = OperatingHoursTime.DeserializeOperatingHoursTime(property.Value);
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = OperatingHoursTime.DeserializeOperatingHoursTime(property.Value);
                    continue;
                }
            }
            return new OperatingHoursTimeRange(startTime.Value, endTime.Value);
        }
    }
}
