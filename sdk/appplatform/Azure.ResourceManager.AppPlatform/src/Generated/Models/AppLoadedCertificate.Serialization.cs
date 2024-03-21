// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppLoadedCertificate : IUtf8JsonSerializable, IJsonModel<AppLoadedCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppLoadedCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppLoadedCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppLoadedCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppLoadedCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            if (Optional.IsDefined(LoadTrustStore))
            {
                writer.WritePropertyName("loadTrustStore"u8);
                writer.WriteBooleanValue(LoadTrustStore.Value);
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

        AppLoadedCertificate IJsonModel<AppLoadedCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppLoadedCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppLoadedCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppLoadedCertificate(document.RootElement, options);
        }

        internal static AppLoadedCertificate DeserializeAppLoadedCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            bool? loadTrustStore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadTrustStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadTrustStore = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppLoadedCertificate(resourceId, loadTrustStore, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppLoadedCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppLoadedCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppLoadedCertificate)} does not support '{options.Format}' format.");
            }
        }

        AppLoadedCertificate IPersistableModel<AppLoadedCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppLoadedCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppLoadedCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppLoadedCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppLoadedCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
