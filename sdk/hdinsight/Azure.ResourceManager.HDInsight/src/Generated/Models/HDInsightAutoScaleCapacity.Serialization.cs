// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleCapacity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MinInstanceCount))
            {
                writer.WritePropertyName("minInstanceCount");
                writer.WriteNumberValue(MinInstanceCount.Value);
            }
            if (Optional.IsDefined(MaxInstanceCount))
            {
                writer.WritePropertyName("maxInstanceCount");
                writer.WriteNumberValue(MaxInstanceCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightAutoScaleCapacity DeserializeHDInsightAutoScaleCapacity(JsonElement element)
        {
            Optional<int> minInstanceCount = default;
            Optional<int> maxInstanceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minInstanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new HDInsightAutoScaleCapacity(Optional.ToNullable(minInstanceCount), Optional.ToNullable(maxInstanceCount));
        }
    }
}
