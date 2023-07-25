// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceParsedPattern : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PatternTypeKey))
            {
                writer.WritePropertyName("patternTypeKey"u8);
                writer.WriteStringValue(PatternTypeKey);
            }
            if (Optional.IsCollectionDefined(PatternTypeValues))
            {
                writer.WritePropertyName("patternTypeValues"u8);
                writer.WriteStartArray();
                foreach (var item in PatternTypeValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ThreatIntelligenceParsedPattern DeserializeThreatIntelligenceParsedPattern(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> patternTypeKey = default;
            Optional<IList<ThreatIntelligenceParsedPatternTypeValue>> patternTypeValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patternTypeKey"u8))
                {
                    patternTypeKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("patternTypeValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceParsedPatternTypeValue> array = new List<ThreatIntelligenceParsedPatternTypeValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceParsedPatternTypeValue.DeserializeThreatIntelligenceParsedPatternTypeValue(item));
                    }
                    patternTypeValues = array;
                    continue;
                }
            }
            return new ThreatIntelligenceParsedPattern(patternTypeKey.Value, Optional.ToList(patternTypeValues));
        }
    }
}
