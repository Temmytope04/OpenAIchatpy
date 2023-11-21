// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<NetAppKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppKeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NetAppKeyVaultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVaultResourceId"u8);
            writer.WriteStringValue(KeyVaultResourceId);
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        NetAppKeyVaultProperties IJsonModel<NetAppKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(NetAppKeyVaultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppKeyVaultProperties(document.RootElement, options);
        }

        internal static NetAppKeyVaultProperties DeserializeNetAppKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyVaultId = default;
            Uri keyVaultUri = default;
            string keyName = default;
            string keyVaultResourceId = default;
            Optional<NetAppKeyVaultStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultResourceId"u8))
                {
                    keyVaultResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new NetAppKeyVaultStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppKeyVaultProperties(keyVaultId.Value, keyVaultUri, keyName, keyVaultResourceId, Optional.ToNullable(status), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(NetAppKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        NetAppKeyVaultProperties IPersistableModel<NetAppKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(NetAppKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
