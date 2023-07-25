// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class MaxSizeRangeCapability
    {
        internal static MaxSizeRangeCapability DeserializeMaxSizeRangeCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MaxSizeCapability> minValue = default;
            Optional<MaxSizeCapability> maxValue = default;
            Optional<MaxSizeCapability> scaleSize = default;
            Optional<LogSizeCapability> logSize = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minValue = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("maxValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxValue = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("scaleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("logSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logSize = LogSizeCapability.DeserializeLogSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new MaxSizeRangeCapability(minValue.Value, maxValue.Value, scaleSize.Value, logSize.Value, Optional.ToNullable(status), reason.Value);
        }
    }
}
