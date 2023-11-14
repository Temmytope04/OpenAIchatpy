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

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralAppNameAvailabilityResponse : IUtf8JsonSerializable, IJsonModel<IotCentralAppNameAvailabilityResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotCentralAppNameAvailabilityResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotCentralAppNameAvailabilityResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotCentralAppNameAvailabilityResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotCentralAppNameAvailabilityResponse>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsNameAvailable))
                {
                    writer.WritePropertyName("nameAvailable"u8);
                    writer.WriteBooleanValue(IsNameAvailable.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IotCentralAppNameUnavailableReason))
                {
                    writer.WritePropertyName("reason"u8);
                    writer.WriteStringValue(IotCentralAppNameUnavailableReason);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Message))
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
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

        IotCentralAppNameAvailabilityResponse IJsonModel<IotCentralAppNameAvailabilityResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppNameAvailabilityResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralAppNameAvailabilityResponse(document.RootElement, options);
        }

        internal static IotCentralAppNameAvailabilityResponse DeserializeIotCentralAppNameAvailabilityResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> nameAvailable = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotCentralAppNameAvailabilityResponse(Optional.ToNullable(nameAvailable), reason.Value, message.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotCentralAppNameAvailabilityResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppNameAvailabilityResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotCentralAppNameAvailabilityResponse IPersistableModel<IotCentralAppNameAvailabilityResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotCentralAppNameAvailabilityResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotCentralAppNameAvailabilityResponse(document.RootElement, options);
        }

        string IPersistableModel<IotCentralAppNameAvailabilityResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
