// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class PodEvent : IUtf8JsonSerializable, IJsonModel<PodEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PodEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PodEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PodEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PodEvent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EventType.Value.ToString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(LastSeenOn))
            {
                writer.WritePropertyName("lastSeenTime"u8);
                writer.WriteStringValue(LastSeenOn.Value, "O");
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

        PodEvent IJsonModel<PodEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PodEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PodEvent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePodEvent(document.RootElement, options);
        }

        internal static PodEvent DeserializePodEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PodEventType? type = default;
            string reason = default;
            string message = default;
            DateTimeOffset? lastSeenTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new PodEventType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSeenTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeenTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PodEvent(type, reason, message, lastSeenTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PodEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PodEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PodEvent)} does not support '{options.Format}' format.");
            }
        }

        PodEvent IPersistableModel<PodEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PodEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePodEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PodEvent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PodEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
