// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapLandscapeMonitorData : IUtf8JsonSerializable, IJsonModel<SapLandscapeMonitorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapLandscapeMonitorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapLandscapeMonitorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLandscapeMonitorData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Grouping != null)
            {
                writer.WritePropertyName("grouping"u8);
                writer.WriteObjectValue(Grouping);
            }
            if (!(TopMetricsThresholds is ChangeTrackingList<SapLandscapeMonitorMetricThresholds> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("topMetricsThresholds"u8);
                writer.WriteStartArray();
                foreach (var item in TopMetricsThresholds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SapLandscapeMonitorData IJsonModel<SapLandscapeMonitorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapLandscapeMonitorData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapLandscapeMonitorData(document.RootElement, options);
        }

        internal static SapLandscapeMonitorData DeserializeSapLandscapeMonitorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SapLandscapeMonitorProvisioningState? provisioningState = default;
            SapLandscapeMonitorPropertiesGrouping grouping = default;
            IList<SapLandscapeMonitorMetricThresholds> topMetricsThresholds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SapLandscapeMonitorProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("grouping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            grouping = SapLandscapeMonitorPropertiesGrouping.DeserializeSapLandscapeMonitorPropertiesGrouping(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("topMetricsThresholds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SapLandscapeMonitorMetricThresholds> array = new List<SapLandscapeMonitorMetricThresholds>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SapLandscapeMonitorMetricThresholds.DeserializeSapLandscapeMonitorMetricThresholds(item, options));
                            }
                            topMetricsThresholds = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapLandscapeMonitorData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                grouping,
                topMetricsThresholds ?? new ChangeTrackingList<SapLandscapeMonitorMetricThresholds>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapLandscapeMonitorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapLandscapeMonitorData)} does not support '{options.Format}' format.");
            }
        }

        SapLandscapeMonitorData IPersistableModel<SapLandscapeMonitorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapLandscapeMonitorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapLandscapeMonitorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapLandscapeMonitorData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapLandscapeMonitorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
