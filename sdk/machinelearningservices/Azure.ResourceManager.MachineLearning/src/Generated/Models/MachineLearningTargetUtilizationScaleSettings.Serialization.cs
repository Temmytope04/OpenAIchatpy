// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningTargetUtilizationScaleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxInstances))
            {
                writer.WritePropertyName("maxInstances"u8);
                writer.WriteNumberValue(MaxInstances.Value);
            }
            if (Optional.IsDefined(MinInstances))
            {
                writer.WritePropertyName("minInstances"u8);
                writer.WriteNumberValue(MinInstances.Value);
            }
            if (Optional.IsDefined(PollingInterval))
            {
                writer.WritePropertyName("pollingInterval"u8);
                writer.WriteStringValue(PollingInterval.Value, "P");
            }
            if (Optional.IsDefined(TargetUtilizationPercentage))
            {
                writer.WritePropertyName("targetUtilizationPercentage"u8);
                writer.WriteNumberValue(TargetUtilizationPercentage.Value);
            }
            writer.WritePropertyName("scaleType"u8);
            writer.WriteStringValue(ScaleType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningTargetUtilizationScaleSettings DeserializeMachineLearningTargetUtilizationScaleSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxInstances = default;
            Optional<int> minInstances = default;
            Optional<TimeSpan> pollingInterval = default;
            Optional<int> targetUtilizationPercentage = default;
            ScaleType scaleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInstances = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstances = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pollingInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollingInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("targetUtilizationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetUtilizationPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    scaleType = new ScaleType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningTargetUtilizationScaleSettings(scaleType, Optional.ToNullable(maxInstances), Optional.ToNullable(minInstances), Optional.ToNullable(pollingInterval), Optional.ToNullable(targetUtilizationPercentage));
        }
    }
}
