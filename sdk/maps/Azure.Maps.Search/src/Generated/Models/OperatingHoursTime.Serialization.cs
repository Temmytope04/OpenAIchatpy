// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class OperatingHoursTime
    {
        internal static OperatingHoursTime DeserializeOperatingHoursTime(JsonElement element)
        {
            Optional<string> date = default;
            Optional<int> hour = default;
            Optional<int> minute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"))
                {
                    date = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hour"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
            }
            return new OperatingHoursTime(date.Value, Optional.ToNullable(hour), Optional.ToNullable(minute));
        }
    }
}
