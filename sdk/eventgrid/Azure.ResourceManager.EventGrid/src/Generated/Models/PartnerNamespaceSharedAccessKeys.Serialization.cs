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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerNamespaceSharedAccessKeys : IUtf8JsonSerializable, IJsonModel<PartnerNamespaceSharedAccessKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerNamespaceSharedAccessKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PartnerNamespaceSharedAccessKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceSharedAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceSharedAccessKeys)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Key1))
            {
                writer.WritePropertyName("key1"u8);
                writer.WriteStringValue(Key1);
            }
            if (Optional.IsDefined(Key2))
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(Key2);
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
        }

        PartnerNamespaceSharedAccessKeys IJsonModel<PartnerNamespaceSharedAccessKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceSharedAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceSharedAccessKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerNamespaceSharedAccessKeys(document.RootElement, options);
        }

        internal static PartnerNamespaceSharedAccessKeys DeserializePartnerNamespaceSharedAccessKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key1 = default;
            string key2 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PartnerNamespaceSharedAccessKeys(key1, key2, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key1), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key1: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key1))
                {
                    builder.Append("  key1: ");
                    if (Key1.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key1}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key1}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key2), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key2: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key2))
                {
                    builder.Append("  key2: ");
                    if (Key2.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key2}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key2}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PartnerNamespaceSharedAccessKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceSharedAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceSharedAccessKeys)} does not support writing '{options.Format}' format.");
            }
        }

        PartnerNamespaceSharedAccessKeys IPersistableModel<PartnerNamespaceSharedAccessKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceSharedAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerNamespaceSharedAccessKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceSharedAccessKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerNamespaceSharedAccessKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
