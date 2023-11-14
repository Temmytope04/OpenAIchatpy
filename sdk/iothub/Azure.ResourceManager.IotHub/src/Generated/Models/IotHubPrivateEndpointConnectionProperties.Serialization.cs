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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubPrivateEndpointConnectionProperties : IUtf8JsonSerializable, IJsonModel<IotHubPrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubPrivateEndpointConnectionProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotHubPrivateEndpointConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotHubPrivateEndpointConnectionProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotHubPrivateEndpointConnectionProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            writer.WritePropertyName("privateLinkServiceConnectionState"u8);
            writer.WriteObjectValue(ConnectionState);
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

        IotHubPrivateEndpointConnectionProperties IJsonModel<IotHubPrivateEndpointConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubPrivateEndpointConnectionProperties(document.RootElement, options);
        }

        internal static IotHubPrivateEndpointConnectionProperties DeserializeIotHubPrivateEndpointConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubResource> privateEndpoint = default;
            IotHubPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    privateLinkServiceConnectionState = IotHubPrivateLinkServiceConnectionState.DeserializeIotHubPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubPrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubPrivateEndpointConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointConnectionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotHubPrivateEndpointConnectionProperties IPersistableModel<IotHubPrivateEndpointConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotHubPrivateEndpointConnectionProperties(document.RootElement, options);
        }

        string IPersistableModel<IotHubPrivateEndpointConnectionProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
