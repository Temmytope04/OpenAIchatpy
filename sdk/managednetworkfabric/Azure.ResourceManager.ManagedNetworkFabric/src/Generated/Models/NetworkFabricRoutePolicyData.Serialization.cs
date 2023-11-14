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
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricRoutePolicyData : IUtf8JsonSerializable, IJsonModel<NetworkFabricRoutePolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricRoutePolicyData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkFabricRoutePolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkFabricRoutePolicyData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkFabricRoutePolicyData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Statements))
            {
                writer.WritePropertyName("statements"u8);
                writer.WriteStartArray();
                foreach (var item in Statements)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkFabricId"u8);
            writer.WriteStringValue(NetworkFabricId);
            if (Optional.IsDefined(AddressFamilyType))
            {
                writer.WritePropertyName("addressFamilyType"u8);
                writer.WriteStringValue(AddressFamilyType.Value.ToString());
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ConfigurationState))
                {
                    writer.WritePropertyName("configurationState"u8);
                    writer.WriteStringValue(ConfigurationState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AdministrativeState))
                {
                    writer.WritePropertyName("administrativeState"u8);
                    writer.WriteStringValue(AdministrativeState.Value.ToString());
                }
            }
            writer.WriteEndObject();
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

        NetworkFabricRoutePolicyData IJsonModel<NetworkFabricRoutePolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricRoutePolicyData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricRoutePolicyData(document.RootElement, options);
        }

        internal static NetworkFabricRoutePolicyData DeserializeNetworkFabricRoutePolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<CommunityActionType> defaultAction = default;
            Optional<IList<RoutePolicyStatementProperties>> statements = default;
            ResourceIdentifier networkFabricId = default;
            Optional<AddressFamilyType> addressFamilyType = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAction = new CommunityActionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statements"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoutePolicyStatementProperties> array = new List<RoutePolicyStatementProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoutePolicyStatementProperties.DeserializeRoutePolicyStatementProperties(item));
                            }
                            statements = array;
                            continue;
                        }
                        if (property0.NameEquals("networkFabricId"u8))
                        {
                            networkFabricId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("addressFamilyType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressFamilyType = new AddressFamilyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFabricRoutePolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, annotation.Value, Optional.ToNullable(defaultAction), Optional.ToList(statements), networkFabricId, Optional.ToNullable(addressFamilyType), Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricRoutePolicyData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricRoutePolicyData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkFabricRoutePolicyData IPersistableModel<NetworkFabricRoutePolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricRoutePolicyData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkFabricRoutePolicyData(document.RootElement, options);
        }

        string IPersistableModel<NetworkFabricRoutePolicyData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
