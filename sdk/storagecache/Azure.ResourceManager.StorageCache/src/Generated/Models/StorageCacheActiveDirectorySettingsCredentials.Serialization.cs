// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheActiveDirectorySettingsCredentials : IUtf8JsonSerializable, IJsonModel<StorageCacheActiveDirectorySettingsCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheActiveDirectorySettingsCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheActiveDirectorySettingsCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettingsCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("username"u8);
            writer.WriteStringValue(Username);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
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

        StorageCacheActiveDirectorySettingsCredentials IJsonModel<StorageCacheActiveDirectorySettingsCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettingsCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheActiveDirectorySettingsCredentials(document.RootElement, options);
        }

        internal static StorageCacheActiveDirectorySettingsCredentials DeserializeStorageCacheActiveDirectorySettingsCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string username = default;
            string password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheActiveDirectorySettingsCredentials(username, password, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettingsCredentials)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheActiveDirectorySettingsCredentials IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheActiveDirectorySettingsCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettingsCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheActiveDirectorySettingsCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
