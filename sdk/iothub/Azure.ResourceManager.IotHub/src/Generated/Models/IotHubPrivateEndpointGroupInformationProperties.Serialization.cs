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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubPrivateEndpointGroupInformationProperties : IUtf8JsonSerializable, IJsonModel<IotHubPrivateEndpointGroupInformationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubPrivateEndpointGroupInformationProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotHubPrivateEndpointGroupInformationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotHubPrivateEndpointGroupInformationProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotHubPrivateEndpointGroupInformationProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (Optional.IsCollectionDefined(RequiredMembers))
            {
                writer.WritePropertyName("requiredMembers"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredMembers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredDnsZoneNames))
            {
                writer.WritePropertyName("requiredZoneNames"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDnsZoneNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        IotHubPrivateEndpointGroupInformationProperties IJsonModel<IotHubPrivateEndpointGroupInformationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointGroupInformationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubPrivateEndpointGroupInformationProperties(document.RootElement, options);
        }

        internal static IotHubPrivateEndpointGroupInformationProperties DeserializeIotHubPrivateEndpointGroupInformationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupId = default;
            Optional<IReadOnlyList<string>> requiredMembers = default;
            Optional<IReadOnlyList<string>> requiredZoneNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMembers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredMembers = array;
                    continue;
                }
                if (property.NameEquals("requiredZoneNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    requiredZoneNames = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubPrivateEndpointGroupInformationProperties(groupId.Value, Optional.ToList(requiredMembers), Optional.ToList(requiredZoneNames), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubPrivateEndpointGroupInformationProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointGroupInformationProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotHubPrivateEndpointGroupInformationProperties IPersistableModel<IotHubPrivateEndpointGroupInformationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubPrivateEndpointGroupInformationProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotHubPrivateEndpointGroupInformationProperties(document.RootElement, options);
        }

        string IPersistableModel<IotHubPrivateEndpointGroupInformationProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
