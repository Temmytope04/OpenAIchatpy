// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PredictiveAutoscalePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scaleMode");
            writer.WriteStringValue(ScaleMode.ToSerialString());
            if (Optional.IsDefined(ScaleLookAheadTime))
            {
                writer.WritePropertyName("scaleLookAheadTime");
                writer.WriteStringValue(ScaleLookAheadTime.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static PredictiveAutoscalePolicy DeserializePredictiveAutoscalePolicy(JsonElement element)
        {
            PredictiveAutoscalePolicyScaleMode scaleMode = default;
            Optional<TimeSpan> scaleLookAheadTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleMode"))
                {
                    scaleMode = property.Value.GetString().ToPredictiveAutoscalePolicyScaleMode();
                    continue;
                }
                if (property.NameEquals("scaleLookAheadTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleLookAheadTime = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new PredictiveAutoscalePolicy(scaleMode, Optional.ToNullable(scaleLookAheadTime));
        }
    }
}
