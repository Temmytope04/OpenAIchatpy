// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionGradesItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GradeName))
            {
                writer.WritePropertyName("gradeName"u8);
                writer.WriteStringValue(GradeName);
            }
            if (Optional.IsDefined(MinScoreThreshold))
            {
                writer.WritePropertyName("minScoreThreshold"u8);
                writer.WriteNumberValue(MinScoreThreshold.Value);
            }
            if (Optional.IsDefined(MaxScoreThreshold))
            {
                writer.WritePropertyName("maxScoreThreshold"u8);
                writer.WriteNumberValue(MaxScoreThreshold.Value);
            }
            writer.WriteEndObject();
        }

        internal static PredictionGradesItem DeserializePredictionGradesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> gradeName = default;
            Optional<int> minScoreThreshold = default;
            Optional<int> maxScoreThreshold = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gradeName"u8))
                {
                    gradeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minScoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minScoreThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxScoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxScoreThreshold = property.Value.GetInt32();
                    continue;
                }
            }
            return new PredictionGradesItem(gradeName.Value, Optional.ToNullable(minScoreThreshold), Optional.ToNullable(maxScoreThreshold));
        }
    }
}
