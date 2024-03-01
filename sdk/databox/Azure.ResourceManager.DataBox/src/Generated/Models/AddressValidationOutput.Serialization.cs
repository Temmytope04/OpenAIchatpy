// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AddressValidationOutput : IUtf8JsonSerializable, IJsonModel<AddressValidationOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddressValidationOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AddressValidationOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ValidationType.HasValue)
            {
                writer.WritePropertyName("validationType"u8);
                writer.WriteStringValue(ValidationType.Value.ToSerialString());
            }
            if (options.Format != "W" && Error != null)
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W" && ValidationStatus.HasValue)
            {
                writer.WritePropertyName("validationStatus"u8);
                writer.WriteStringValue(ValidationStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && !(AlternateAddresses is ChangeTrackingList<DataBoxShippingAddress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("alternateAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AddressValidationOutput IJsonModel<AddressValidationOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValidationOutput(document.RootElement, options);
        }

        internal static AddressValidationOutput DeserializeAddressValidationOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxValidationInputDiscriminator? validationType = default;
            ResponseError error = default;
            AddressValidationStatus? validationStatus = default;
            IReadOnlyList<DataBoxShippingAddress> alternateAddresses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("validationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationType = property0.Value.GetString().ToDataBoxValidationInputDiscriminator();
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("validationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationStatus = property0.Value.GetString().ToAddressValidationStatus();
                            continue;
                        }
                        if (property0.NameEquals("alternateAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxShippingAddress> array = new List<DataBoxShippingAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxShippingAddress.DeserializeDataBoxShippingAddress(item, options));
                            }
                            alternateAddresses = array;
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
            return new AddressValidationOutput(validationType, error, validationStatus, alternateAddresses ?? new ChangeTrackingList<DataBoxShippingAddress>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AddressValidationOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddressValidationOutput)} does not support '{options.Format}' format.");
            }
        }

        AddressValidationOutput IPersistableModel<AddressValidationOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAddressValidationOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddressValidationOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddressValidationOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
