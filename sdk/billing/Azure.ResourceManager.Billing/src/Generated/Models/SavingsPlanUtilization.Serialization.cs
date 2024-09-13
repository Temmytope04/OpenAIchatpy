// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class SavingsPlanUtilization : IUtf8JsonSerializable, IJsonModel<SavingsPlanUtilization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanUtilization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SavingsPlanUtilization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilization)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Trend))
            {
                writer.WritePropertyName("trend"u8);
                writer.WriteStringValue(Trend);
            }
            if (Optional.IsCollectionDefined(Aggregates))
            {
                writer.WritePropertyName("aggregates"u8);
                writer.WriteStartArray();
                foreach (var item in Aggregates)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        SavingsPlanUtilization IJsonModel<SavingsPlanUtilization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanUtilization(document.RootElement, options);
        }

        internal static SavingsPlanUtilization DeserializeSavingsPlanUtilization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string trend = default;
            IReadOnlyList<SavingsPlanUtilizationAggregates> aggregates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trend"u8))
                {
                    trend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanUtilizationAggregates> array = new List<SavingsPlanUtilizationAggregates>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanUtilizationAggregates.DeserializeSavingsPlanUtilizationAggregates(item, options));
                    }
                    aggregates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SavingsPlanUtilization(trend, aggregates ?? new ChangeTrackingList<SavingsPlanUtilizationAggregates>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Trend), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trend: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Trend))
                {
                    builder.Append("  trend: ");
                    if (Trend.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Trend}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Trend}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Aggregates), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aggregates: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Aggregates))
                {
                    if (Aggregates.Any())
                    {
                        builder.Append("  aggregates: ");
                        builder.AppendLine("[");
                        foreach (var item in Aggregates)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  aggregates: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SavingsPlanUtilization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilization)} does not support writing '{options.Format}' format.");
            }
        }

        SavingsPlanUtilization IPersistableModel<SavingsPlanUtilization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanUtilization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanUtilization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
