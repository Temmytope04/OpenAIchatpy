// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdatePrivateLinkServiceProxy : IUtf8JsonSerializable, IJsonModel<DeviceUpdatePrivateLinkServiceProxy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdatePrivateLinkServiceProxy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceUpdatePrivateLinkServiceProxy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateLinkServiceProxy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(RemotePrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("remotePrivateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(RemotePrivateLinkServiceConnectionState);
            }
            if (Optional.IsDefined(RemotePrivateEndpointConnection))
            {
                writer.WritePropertyName("remotePrivateEndpointConnection"u8);
                JsonSerializer.Serialize(writer, RemotePrivateEndpointConnection);
            }
            if (Optional.IsCollectionDefined(GroupConnectivityInformation))
            {
                writer.WritePropertyName("groupConnectivityInformation"u8);
                writer.WriteStartArray();
                foreach (var item in GroupConnectivityInformation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DeviceUpdatePrivateLinkServiceProxy IJsonModel<DeviceUpdatePrivateLinkServiceProxy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdatePrivateLinkServiceProxy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdatePrivateLinkServiceProxy(document.RootElement, options);
        }

        internal static DeviceUpdatePrivateLinkServiceProxy DeserializeDeviceUpdatePrivateLinkServiceProxy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            DeviceUpdatePrivateLinkServiceConnectionState remotePrivateLinkServiceConnectionState = default;
            SubResource remotePrivateEndpointConnection = default;
            IList<GroupConnectivityInformation> groupConnectivityInformation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remotePrivateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remotePrivateLinkServiceConnectionState = DeviceUpdatePrivateLinkServiceConnectionState.DeserializeDeviceUpdatePrivateLinkServiceConnectionState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("remotePrivateEndpointConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remotePrivateEndpointConnection = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("groupConnectivityInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GroupConnectivityInformation> array = new List<GroupConnectivityInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.GroupConnectivityInformation.DeserializeGroupConnectivityInformation(item, options));
                    }
                    groupConnectivityInformation = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceUpdatePrivateLinkServiceProxy(id, remotePrivateLinkServiceConnectionState, remotePrivateEndpointConnection, groupConnectivityInformation ?? new ChangeTrackingList<GroupConnectivityInformation>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateLinkServiceProxy)} does not support '{options.Format}' format.");
            }
        }

        DeviceUpdatePrivateLinkServiceProxy IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceUpdatePrivateLinkServiceProxy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdatePrivateLinkServiceProxy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdatePrivateLinkServiceProxy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
