// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class SupportServiceLevelAgreement : IUtf8JsonSerializable, IJsonModel<SupportServiceLevelAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportServiceLevelAgreement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SupportServiceLevelAgreement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportServiceLevelAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportServiceLevelAgreement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && SlaInMinutes.HasValue)
            {
                writer.WritePropertyName("slaMinutes"u8);
                writer.WriteNumberValue(SlaInMinutes.Value);
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

        SupportServiceLevelAgreement IJsonModel<SupportServiceLevelAgreement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportServiceLevelAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportServiceLevelAgreement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportServiceLevelAgreement(document.RootElement, options);
        }

        internal static SupportServiceLevelAgreement DeserializeSupportServiceLevelAgreement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startTime = default;
            DateTimeOffset? expirationTime = default;
            int? slaMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("slaMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slaMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SupportServiceLevelAgreement(startTime, expirationTime, slaMinutes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SupportServiceLevelAgreement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportServiceLevelAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SupportServiceLevelAgreement)} does not support '{options.Format}' format.");
            }
        }

        SupportServiceLevelAgreement IPersistableModel<SupportServiceLevelAgreement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportServiceLevelAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSupportServiceLevelAgreement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SupportServiceLevelAgreement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SupportServiceLevelAgreement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
