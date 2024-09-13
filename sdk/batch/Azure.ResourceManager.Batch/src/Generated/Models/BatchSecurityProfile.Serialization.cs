// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchSecurityProfile : IUtf8JsonSerializable, IJsonModel<BatchSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchSecurityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchSecurityProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecurityType))
            {
                writer.WritePropertyName("securityType"u8);
                writer.WriteStringValue(SecurityType.Value.ToSerialString());
            }
            if (Optional.IsDefined(EncryptionAtHost))
            {
                writer.WritePropertyName("encryptionAtHost"u8);
                writer.WriteBooleanValue(EncryptionAtHost.Value);
            }
            if (Optional.IsDefined(UefiSettings))
            {
                writer.WritePropertyName("uefiSettings"u8);
                writer.WriteObjectValue(UefiSettings, options);
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

        BatchSecurityProfile IJsonModel<BatchSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchSecurityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchSecurityProfile(document.RootElement, options);
        }

        internal static BatchSecurityProfile DeserializeBatchSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchSecurityType? securityType = default;
            bool? encryptionAtHost = default;
            BatchUefiSettings uefiSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("securityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityType = property.Value.GetString().ToBatchSecurityType();
                    continue;
                }
                if (property.NameEquals("encryptionAtHost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("uefiSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uefiSettings = BatchUefiSettings.DeserializeBatchUefiSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchSecurityProfile(securityType, encryptionAtHost, uefiSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchSecurityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        BatchSecurityProfile IPersistableModel<BatchSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchSecurityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
