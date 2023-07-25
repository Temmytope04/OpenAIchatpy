// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PerfMonSample
    {
        internal static PerfMonSample DeserializePerfMonSample(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> time = default;
            Optional<string> instanceName = default;
            Optional<double> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("instanceName"u8))
                {
                    instanceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
            }
            return new PerfMonSample(Optional.ToNullable(time), instanceName.Value, Optional.ToNullable(value));
        }
    }
}
