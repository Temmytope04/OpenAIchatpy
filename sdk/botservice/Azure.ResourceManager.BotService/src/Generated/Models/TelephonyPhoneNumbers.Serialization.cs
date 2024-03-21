// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class TelephonyPhoneNumbers : IUtf8JsonSerializable, IJsonModel<TelephonyPhoneNumbers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TelephonyPhoneNumbers>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TelephonyPhoneNumbers>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TelephonyPhoneNumbers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TelephonyPhoneNumbers)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(AcsEndpoint))
            {
                if (AcsEndpoint != null)
                {
                    writer.WritePropertyName("acsEndpoint"u8);
                    writer.WriteStringValue(AcsEndpoint);
                }
                else
                {
                    writer.WriteNull("acsEndpoint");
                }
            }
            if (Optional.IsDefined(AcsSecret))
            {
                if (AcsSecret != null)
                {
                    writer.WritePropertyName("acsSecret"u8);
                    writer.WriteStringValue(AcsSecret);
                }
                else
                {
                    writer.WriteNull("acsSecret");
                }
            }
            if (Optional.IsDefined(AcsResourceId))
            {
                if (AcsResourceId != null)
                {
                    writer.WritePropertyName("acsResourceId"u8);
                    writer.WriteStringValue(AcsResourceId);
                }
                else
                {
                    writer.WriteNull("acsResourceId");
                }
            }
            if (Optional.IsDefined(CognitiveServiceSubscriptionKey))
            {
                if (CognitiveServiceSubscriptionKey != null)
                {
                    writer.WritePropertyName("cognitiveServiceSubscriptionKey"u8);
                    writer.WriteStringValue(CognitiveServiceSubscriptionKey);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceSubscriptionKey");
                }
            }
            if (Optional.IsDefined(CognitiveServiceRegion))
            {
                if (CognitiveServiceRegion != null)
                {
                    writer.WritePropertyName("cognitiveServiceRegion"u8);
                    writer.WriteStringValue(CognitiveServiceRegion);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceRegion");
                }
            }
            if (Optional.IsDefined(CognitiveServiceResourceId))
            {
                if (CognitiveServiceResourceId != null)
                {
                    writer.WritePropertyName("cognitiveServiceResourceId"u8);
                    writer.WriteStringValue(CognitiveServiceResourceId);
                }
                else
                {
                    writer.WriteNull("cognitiveServiceResourceId");
                }
            }
            if (Optional.IsDefined(DefaultLocale))
            {
                if (DefaultLocale != null)
                {
                    writer.WritePropertyName("defaultLocale"u8);
                    writer.WriteStringValue(DefaultLocale);
                }
                else
                {
                    writer.WriteNull("defaultLocale");
                }
            }
            if (Optional.IsDefined(OfferType))
            {
                if (OfferType != null)
                {
                    writer.WritePropertyName("offerType"u8);
                    writer.WriteStringValue(OfferType);
                }
                else
                {
                    writer.WriteNull("offerType");
                }
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

        TelephonyPhoneNumbers IJsonModel<TelephonyPhoneNumbers>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TelephonyPhoneNumbers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TelephonyPhoneNumbers)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTelephonyPhoneNumbers(document.RootElement, options);
        }

        internal static TelephonyPhoneNumbers DeserializeTelephonyPhoneNumbers(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string phoneNumber = default;
            string acsEndpoint = default;
            string acsSecret = default;
            ResourceIdentifier acsResourceId = default;
            string cognitiveServiceSubscriptionKey = default;
            string cognitiveServiceRegion = default;
            ResourceIdentifier cognitiveServiceResourceId = default;
            string defaultLocale = default;
            string offerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsEndpoint = null;
                        continue;
                    }
                    acsEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsSecret = null;
                        continue;
                    }
                    acsSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acsResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acsResourceId = null;
                        continue;
                    }
                    acsResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cognitiveServiceSubscriptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceSubscriptionKey = null;
                        continue;
                    }
                    cognitiveServiceSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceRegion = null;
                        continue;
                    }
                    cognitiveServiceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cognitiveServiceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cognitiveServiceResourceId = null;
                        continue;
                    }
                    cognitiveServiceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultLocale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLocale = null;
                        continue;
                    }
                    defaultLocale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        offerType = null;
                        continue;
                    }
                    offerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TelephonyPhoneNumbers(
                id,
                phoneNumber,
                acsEndpoint,
                acsSecret,
                acsResourceId,
                cognitiveServiceSubscriptionKey,
                cognitiveServiceRegion,
                cognitiveServiceResourceId,
                defaultLocale,
                offerType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TelephonyPhoneNumbers>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TelephonyPhoneNumbers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TelephonyPhoneNumbers)} does not support '{options.Format}' format.");
            }
        }

        TelephonyPhoneNumbers IPersistableModel<TelephonyPhoneNumbers>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TelephonyPhoneNumbers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTelephonyPhoneNumbers(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TelephonyPhoneNumbers)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TelephonyPhoneNumbers>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
