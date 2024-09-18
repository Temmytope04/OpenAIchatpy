// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceRelativeMonthlySchedule : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceRelativeMonthlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceRelativeMonthlySchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceMaintenanceRelativeMonthlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceRelativeMonthlySchedule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("intervalMonths"u8);
            writer.WriteNumberValue(IntervalMonths);
            writer.WritePropertyName("weekIndex"u8);
            writer.WriteStringValue(WeekIndex.ToString());
            writer.WritePropertyName("dayOfWeek"u8);
            writer.WriteStringValue(DayOfWeek.ToString());
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

        ContainerServiceMaintenanceRelativeMonthlySchedule IJsonModel<ContainerServiceMaintenanceRelativeMonthlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceRelativeMonthlySchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceRelativeMonthlySchedule DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalMonths = default;
            ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex weekIndex = default;
            ContainerServiceWeekDay dayOfWeek = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalMonths"u8))
                {
                    intervalMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weekIndex"u8))
                {
                    weekIndex = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    dayOfWeek = new ContainerServiceWeekDay(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceMaintenanceRelativeMonthlySchedule(intervalMonths, weekIndex, dayOfWeek, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IntervalMonths), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  intervalMonths: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  intervalMonths: ");
                builder.AppendLine($"{IntervalMonths}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WeekIndex), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  weekIndex: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  weekIndex: ");
                builder.AppendLine($"'{WeekIndex.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DayOfWeek), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dayOfWeek: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  dayOfWeek: ");
                builder.AppendLine($"'{DayOfWeek.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceRelativeMonthlySchedule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceRelativeMonthlySchedule IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceRelativeMonthlySchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceRelativeMonthlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
