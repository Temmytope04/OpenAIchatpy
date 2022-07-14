// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerCpuStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CpuUsage))
            {
                writer.WritePropertyName("cpuUsage");
                writer.WriteObjectValue(CpuUsage);
            }
            if (Optional.IsDefined(SystemCpuUsage))
            {
                writer.WritePropertyName("systemCpuUsage");
                writer.WriteNumberValue(SystemCpuUsage.Value);
            }
            if (Optional.IsDefined(OnlineCpuCount))
            {
                writer.WritePropertyName("onlineCpuCount");
                writer.WriteNumberValue(OnlineCpuCount.Value);
            }
            if (Optional.IsDefined(ThrottlingData))
            {
                writer.WritePropertyName("throttlingData");
                writer.WriteObjectValue(ThrottlingData);
            }
            writer.WriteEndObject();
        }

        internal static ContainerCpuStatistics DeserializeContainerCpuStatistics(JsonElement element)
        {
            Optional<ContainerCpuUsage> cpuUsage = default;
            Optional<long> systemCpuUsage = default;
            Optional<int> onlineCpuCount = default;
            Optional<ContainerThrottlingInfo> throttlingData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuUsage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpuUsage = ContainerCpuUsage.DeserializeContainerCpuUsage(property.Value);
                    continue;
                }
                if (property.NameEquals("systemCpuUsage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemCpuUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("onlineCpuCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    onlineCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttlingData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    throttlingData = ContainerThrottlingInfo.DeserializeContainerThrottlingInfo(property.Value);
                    continue;
                }
            }
            return new ContainerCpuStatistics(cpuUsage.Value, Optional.ToNullable(systemCpuUsage), Optional.ToNullable(onlineCpuCount), throttlingData.Value);
        }
    }
}
