// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceMetric
    {
        internal static ThreatIntelligenceMetric DeserializeThreatIntelligenceMetric(JsonElement element)
        {
            Optional<string> lastUpdatedTimeUtc = default;
            Optional<IReadOnlyList<ThreatIntelligenceMetricEntity>> threatTypeMetrics = default;
            Optional<IReadOnlyList<ThreatIntelligenceMetricEntity>> patternTypeMetrics = default;
            Optional<IReadOnlyList<ThreatIntelligenceMetricEntity>> sourceMetrics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimeUtc"))
                {
                    lastUpdatedTimeUtc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threatTypeMetrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item));
                    }
                    threatTypeMetrics = array;
                    continue;
                }
                if (property.NameEquals("patternTypeMetrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item));
                    }
                    patternTypeMetrics = array;
                    continue;
                }
                if (property.NameEquals("sourceMetrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ThreatIntelligenceMetricEntity> array = new List<ThreatIntelligenceMetricEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceMetricEntity.DeserializeThreatIntelligenceMetricEntity(item));
                    }
                    sourceMetrics = array;
                    continue;
                }
            }
            return new ThreatIntelligenceMetric(lastUpdatedTimeUtc.Value, Optional.ToList(threatTypeMetrics), Optional.ToList(patternTypeMetrics), Optional.ToList(sourceMetrics));
        }
    }
}
