// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class BinaryHardeningSummary : IUtf8JsonSerializable, IJsonModel<BinaryHardeningSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BinaryHardeningSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BinaryHardeningSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardeningSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalFiles))
            {
                writer.WritePropertyName("totalFiles"u8);
                writer.WriteNumberValue(TotalFiles.Value);
            }
            if (Optional.IsDefined(NXPercentage))
            {
                if (NXPercentage != null)
                {
                    writer.WritePropertyName("nx"u8);
                    writer.WriteNumberValue(NXPercentage.Value);
                }
                else
                {
                    writer.WriteNull("nx");
                }
            }
            if (Optional.IsDefined(PiePercentage))
            {
                if (PiePercentage != null)
                {
                    writer.WritePropertyName("pie"u8);
                    writer.WriteNumberValue(PiePercentage.Value);
                }
                else
                {
                    writer.WriteNull("pie");
                }
            }
            if (Optional.IsDefined(RelroPercentage))
            {
                if (RelroPercentage != null)
                {
                    writer.WritePropertyName("relro"u8);
                    writer.WriteNumberValue(RelroPercentage.Value);
                }
                else
                {
                    writer.WriteNull("relro");
                }
            }
            if (Optional.IsDefined(CanaryPercentage))
            {
                if (CanaryPercentage != null)
                {
                    writer.WritePropertyName("canary"u8);
                    writer.WriteNumberValue(CanaryPercentage.Value);
                }
                else
                {
                    writer.WriteNull("canary");
                }
            }
            if (Optional.IsDefined(StrippedPercentage))
            {
                if (StrippedPercentage != null)
                {
                    writer.WritePropertyName("stripped"u8);
                    writer.WriteNumberValue(StrippedPercentage.Value);
                }
                else
                {
                    writer.WriteNull("stripped");
                }
            }
            writer.WritePropertyName("summaryType"u8);
            writer.WriteStringValue(SummaryType.ToString());
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

        BinaryHardeningSummary IJsonModel<BinaryHardeningSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardeningSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBinaryHardeningSummary(document.RootElement, options);
        }

        internal static BinaryHardeningSummary DeserializeBinaryHardeningSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalFiles = default;
            int? nx = default;
            int? pie = default;
            int? relro = default;
            int? canary = default;
            int? stripped = default;
            FirmwareAnalysisSummaryType summaryType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFiles = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nx = null;
                        continue;
                    }
                    nx = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pie"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pie = null;
                        continue;
                    }
                    pie = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("relro"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        relro = null;
                        continue;
                    }
                    relro = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("canary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        canary = null;
                        continue;
                    }
                    canary = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stripped"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stripped = null;
                        continue;
                    }
                    stripped = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("summaryType"u8))
                {
                    summaryType = new FirmwareAnalysisSummaryType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BinaryHardeningSummary(
                summaryType,
                serializedAdditionalRawData,
                totalFiles,
                nx,
                pie,
                relro,
                canary,
                stripped);
        }

        BinaryData IPersistableModel<BinaryHardeningSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BinaryHardeningSummary)} does not support '{options.Format}' format.");
            }
        }

        BinaryHardeningSummary IPersistableModel<BinaryHardeningSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardeningSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBinaryHardeningSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BinaryHardeningSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BinaryHardeningSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
