// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ScheduledSourceSynchronizationSetting : IUtf8JsonSerializable, IJsonModel<ScheduledSourceSynchronizationSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledSourceSynchronizationSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduledSourceSynchronizationSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RecurrenceInterval.HasValue)
            {
                writer.WritePropertyName("recurrenceInterval"u8);
                writer.WriteStringValue(RecurrenceInterval.Value.ToString());
            }
            if (SynchronizeOn.HasValue)
            {
                writer.WritePropertyName("synchronizationTime"u8);
                writer.WriteStringValue(SynchronizeOn.Value, "O");
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

        ScheduledSourceSynchronizationSetting IJsonModel<ScheduledSourceSynchronizationSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledSourceSynchronizationSetting(document.RootElement, options);
        }

        internal static ScheduledSourceSynchronizationSetting DeserializeScheduledSourceSynchronizationSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceShareSynchronizationSettingKind kind = default;
            DataShareSynchronizationRecurrenceInterval? recurrenceInterval = default;
            DateTimeOffset? synchronizationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SourceShareSynchronizationSettingKind(property.Value.GetString());
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
                        if (property0.NameEquals("recurrenceInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recurrenceInterval = new DataShareSynchronizationRecurrenceInterval(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("synchronizationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            synchronizationTime = property0.Value.GetDateTimeOffset("O");
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
            return new ScheduledSourceSynchronizationSetting(kind, serializedAdditionalRawData, recurrenceInterval, synchronizationTime);
        }

        BinaryData IPersistableModel<ScheduledSourceSynchronizationSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support '{options.Format}' format.");
            }
        }

        ScheduledSourceSynchronizationSetting IPersistableModel<ScheduledSourceSynchronizationSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledSourceSynchronizationSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledSourceSynchronizationSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledSourceSynchronizationSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledSourceSynchronizationSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
