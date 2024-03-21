// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class RetentionDescription : IUtf8JsonSerializable, IJsonModel<RetentionDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RetentionDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RetentionDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RetentionDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RetentionDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CleanupPolicy))
            {
                writer.WritePropertyName("cleanupPolicy"u8);
                writer.WriteStringValue(CleanupPolicy.Value.ToString());
            }
            if (Optional.IsDefined(RetentionTimeInHours))
            {
                writer.WritePropertyName("retentionTimeInHours"u8);
                writer.WriteNumberValue(RetentionTimeInHours.Value);
            }
            if (Optional.IsDefined(TombstoneRetentionTimeInHours))
            {
                writer.WritePropertyName("tombstoneRetentionTimeInHours"u8);
                writer.WriteNumberValue(TombstoneRetentionTimeInHours.Value);
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

        RetentionDescription IJsonModel<RetentionDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RetentionDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RetentionDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRetentionDescription(document.RootElement, options);
        }

        internal static RetentionDescription DeserializeRetentionDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CleanupPolicyRetentionDescription? cleanupPolicy = default;
            long? retentionTimeInHours = default;
            int? tombstoneRetentionTimeInHours = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cleanupPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cleanupPolicy = new CleanupPolicyRetentionDescription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retentionTimeInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionTimeInHours = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("tombstoneRetentionTimeInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tombstoneRetentionTimeInHours = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RetentionDescription(cleanupPolicy, retentionTimeInHours, tombstoneRetentionTimeInHours, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RetentionDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RetentionDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RetentionDescription)} does not support '{options.Format}' format.");
            }
        }

        RetentionDescription IPersistableModel<RetentionDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RetentionDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRetentionDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RetentionDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RetentionDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
