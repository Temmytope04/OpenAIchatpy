// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class FusionSourceSettings : IUtf8JsonSerializable, IJsonModel<FusionSourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FusionSourceSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FusionSourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionSourceSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("sourceName"u8);
            writer.WriteStringValue(SourceName);
            if (Optional.IsCollectionDefined(SourceSubTypes))
            {
                writer.WritePropertyName("sourceSubTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SourceSubTypes)
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

        FusionSourceSettings IJsonModel<FusionSourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionSourceSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFusionSourceSettings(document.RootElement, options);
        }

        internal static FusionSourceSettings DeserializeFusionSourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            string sourceName = default;
            IList<FusionSourceSubTypeSetting> sourceSubTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sourceName"u8))
                {
                    sourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSubTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FusionSourceSubTypeSetting> array = new List<FusionSourceSubTypeSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FusionSourceSubTypeSetting.DeserializeFusionSourceSubTypeSetting(item, options));
                    }
                    sourceSubTypes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FusionSourceSettings(enabled, sourceName, sourceSubTypes ?? new ChangeTrackingList<FusionSourceSubTypeSetting>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FusionSourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FusionSourceSettings)} does not support writing '{options.Format}' format.");
            }
        }

        FusionSourceSettings IPersistableModel<FusionSourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFusionSourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FusionSourceSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FusionSourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
