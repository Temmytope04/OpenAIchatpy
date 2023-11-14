// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCryptoKeySummary : IUtf8JsonSerializable, IJsonModel<FirmwareCryptoKeySummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirmwareCryptoKeySummary>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FirmwareCryptoKeySummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FirmwareCryptoKeySummary>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FirmwareCryptoKeySummary>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalKeys))
            {
                writer.WritePropertyName("totalKeys"u8);
                writer.WriteNumberValue(TotalKeys.Value);
            }
            if (Optional.IsDefined(PublicKeys))
            {
                writer.WritePropertyName("publicKeys"u8);
                writer.WriteNumberValue(PublicKeys.Value);
            }
            if (Optional.IsDefined(PrivateKeys))
            {
                writer.WritePropertyName("privateKeys"u8);
                writer.WriteNumberValue(PrivateKeys.Value);
            }
            if (Optional.IsDefined(PairedKeys))
            {
                writer.WritePropertyName("pairedKeys"u8);
                writer.WriteNumberValue(PairedKeys.Value);
            }
            if (Optional.IsDefined(ShortKeySize))
            {
                writer.WritePropertyName("shortKeySize"u8);
                writer.WriteNumberValue(ShortKeySize.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FirmwareCryptoKeySummary IJsonModel<FirmwareCryptoKeySummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoKeySummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoKeySummary(document.RootElement, options);
        }

        internal static FirmwareCryptoKeySummary DeserializeFirmwareCryptoKeySummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalKeys = default;
            Optional<long> publicKeys = default;
            Optional<long> privateKeys = default;
            Optional<long> pairedKeys = default;
            Optional<long> shortKeySize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("publicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("privateKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("pairedKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pairedKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("shortKeySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shortKeySize = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirmwareCryptoKeySummary(Optional.ToNullable(totalKeys), Optional.ToNullable(publicKeys), Optional.ToNullable(privateKeys), Optional.ToNullable(pairedKeys), Optional.ToNullable(shortKeySize), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirmwareCryptoKeySummary>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoKeySummary)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirmwareCryptoKeySummary IPersistableModel<FirmwareCryptoKeySummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoKeySummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirmwareCryptoKeySummary(document.RootElement, options);
        }

        string IPersistableModel<FirmwareCryptoKeySummary>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
