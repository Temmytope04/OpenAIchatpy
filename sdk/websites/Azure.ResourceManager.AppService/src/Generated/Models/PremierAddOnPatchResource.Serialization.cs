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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PremierAddOnPatchResource : IUtf8JsonSerializable, IJsonModel<PremierAddOnPatchResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PremierAddOnPatchResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PremierAddOnPatchResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(MarketplacePublisher))
            {
                writer.WritePropertyName("marketplacePublisher"u8);
                writer.WriteStringValue(MarketplacePublisher);
            }
            if (Optional.IsDefined(MarketplaceOffer))
            {
                writer.WritePropertyName("marketplaceOffer"u8);
                writer.WriteStringValue(MarketplaceOffer);
            }
            writer.WriteEndObject();
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

        PremierAddOnPatchResource IJsonModel<PremierAddOnPatchResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePremierAddOnPatchResource(document.RootElement, options);
        }

        internal static PremierAddOnPatchResource DeserializePremierAddOnPatchResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string sku = default;
            string product = default;
            string vendor = default;
            string marketplacePublisher = default;
            string marketplaceOffer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplacePublisher"u8))
                        {
                            marketplacePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceOffer"u8))
                        {
                            marketplaceOffer = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PremierAddOnPatchResource(
                id,
                name,
                type,
                systemData,
                sku,
                product,
                vendor,
                marketplacePublisher,
                marketplaceOffer,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PremierAddOnPatchResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support '{options.Format}' format.");
            }
        }

        PremierAddOnPatchResource IPersistableModel<PremierAddOnPatchResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnPatchResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePremierAddOnPatchResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnPatchResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PremierAddOnPatchResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
