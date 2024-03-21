// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemAddressProperties : IUtf8JsonSerializable, IJsonModel<EdgeOrderItemAddressProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderItemAddressProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeOrderItemAddressProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue(ContactDetails);
            if (options.Format != "W" && Optional.IsDefined(AddressValidationStatus))
            {
                writer.WritePropertyName("addressValidationStatus"u8);
                writer.WriteStringValue(AddressValidationStatus.Value.ToString());
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

        EdgeOrderItemAddressProperties IJsonModel<EdgeOrderItemAddressProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderItemAddressProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderItemAddressProperties(document.RootElement, options);
        }

        internal static EdgeOrderItemAddressProperties DeserializeEdgeOrderItemAddressProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeOrderShippingAddress shippingAddress = default;
            EdgeOrderAddressContactDetails contactDetails = default;
            EdgeOrderAddressValidationStatus? addressValidationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = EdgeOrderShippingAddress.DeserializeEdgeOrderShippingAddress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = EdgeOrderAddressContactDetails.DeserializeEdgeOrderAddressContactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("addressValidationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressValidationStatus = new EdgeOrderAddressValidationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeOrderItemAddressProperties(shippingAddress, contactDetails, addressValidationStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderItemAddressProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderItemAddressProperties)} does not support '{options.Format}' format.");
            }
        }

        EdgeOrderItemAddressProperties IPersistableModel<EdgeOrderItemAddressProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderItemAddressProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeOrderItemAddressProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderItemAddressProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderItemAddressProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
