// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    public partial class ExtensionData : IUtf8JsonSerializable, IJsonModel<ExtensionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtensionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ExtensionId))
            {
                writer.WritePropertyName("extensionId"u8);
                writer.WriteStringValue(ExtensionId);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionCategory))
            {
                writer.WritePropertyName("extensionCategory"u8);
                writer.WriteStringValue(ExtensionCategory);
            }
            if (options.Format != "W" && Optional.IsDefined(InstalledExtensionVersion))
            {
                writer.WritePropertyName("installedExtensionVersion"u8);
                writer.WriteStringValue(InstalledExtensionVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionAuthLink))
            {
                writer.WritePropertyName("extensionAuthLink"u8);
                writer.WriteStringValue(ExtensionAuthLink);
            }
            if (options.Format != "W" && Optional.IsDefined(ExtensionApiDocsLink))
            {
                writer.WritePropertyName("extensionApiDocsLink"u8);
                writer.WriteStringValue(ExtensionApiDocsLink);
            }
            writer.WriteEndObject();
        }

        ExtensionData IJsonModel<ExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtensionData(document.RootElement, options);
        }

        internal static ExtensionData DeserializeExtensionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string extensionId = default;
            string extensionCategory = default;
            string installedExtensionVersion = default;
            string extensionAuthLink = default;
            string extensionApiDocsLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("extensionId"u8))
                        {
                            extensionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionCategory"u8))
                        {
                            extensionCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("installedExtensionVersion"u8))
                        {
                            installedExtensionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionAuthLink"u8))
                        {
                            extensionAuthLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionApiDocsLink"u8))
                        {
                            extensionApiDocsLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtensionData(
                id,
                name,
                type,
                systemData,
                etag,
                extensionId,
                extensionCategory,
                installedExtensionVersion,
                extensionAuthLink,
                extensionApiDocsLink,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtensionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtensionData)} does not support writing '{options.Format}' format.");
            }
        }

        ExtensionData IPersistableModel<ExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtensionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtensionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
