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
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningRegistryData : IUtf8JsonSerializable, IJsonModel<MachineLearningRegistryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningRegistryData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningRegistryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningRegistryData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningRegistryData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
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
            if (Optional.IsDefined(DiscoveryUri))
            {
                if (DiscoveryUri != null)
                {
                    writer.WritePropertyName("discoveryUrl"u8);
                    writer.WriteStringValue(DiscoveryUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("discoveryUrl");
                }
            }
            if (Optional.IsDefined(IntellectualPropertyPublisher))
            {
                if (IntellectualPropertyPublisher != null)
                {
                    writer.WritePropertyName("intellectualPropertyPublisher"u8);
                    writer.WriteStringValue(IntellectualPropertyPublisher);
                }
                else
                {
                    writer.WriteNull("intellectualPropertyPublisher");
                }
            }
            if (Optional.IsDefined(ManagedResourceGroup))
            {
                if (ManagedResourceGroup != null)
                {
                    writer.WritePropertyName("managedResourceGroup"u8);
                    writer.WriteObjectValue(ManagedResourceGroup);
                }
                else
                {
                    writer.WriteNull("managedResourceGroup");
                }
            }
            if (Optional.IsDefined(MlFlowRegistryUri))
            {
                if (MlFlowRegistryUri != null)
                {
                    writer.WritePropertyName("mlFlowRegistryUri"u8);
                    writer.WriteStringValue(MlFlowRegistryUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("mlFlowRegistryUri");
                }
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                if (PrivateEndpointConnections != null)
                {
                    writer.WritePropertyName("privateEndpointConnections"u8);
                    writer.WriteStartArray();
                    foreach (var item in PrivateEndpointConnections)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("privateEndpointConnections");
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                if (PublicNetworkAccess != null)
                {
                    writer.WritePropertyName("publicNetworkAccess"u8);
                    writer.WriteStringValue(PublicNetworkAccess);
                }
                else
                {
                    writer.WriteNull("publicNetworkAccess");
                }
            }
            if (Optional.IsCollectionDefined(RegionDetails))
            {
                if (RegionDetails != null)
                {
                    writer.WritePropertyName("regionDetails"u8);
                    writer.WriteStartArray();
                    foreach (var item in RegionDetails)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("regionDetails");
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

        MachineLearningRegistryData IJsonModel<MachineLearningRegistryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningRegistryData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningRegistryData(document.RootElement, options);
        }

        internal static MachineLearningRegistryData DeserializeMachineLearningRegistryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> kind = default;
            Optional<MachineLearningSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> discoveryUrl = default;
            Optional<string> intellectualPropertyPublisher = default;
            Optional<ArmResourceId> managedResourceGroup = default;
            Optional<Uri> mlFlowRegistryUri = default;
            Optional<IList<RegistryPrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<string> publicNetworkAccess = default;
            Optional<IList<RegistryRegionArmDetails>> regionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MachineLearningSku.DeserializeMachineLearningSku(property.Value);
                    continue;
                }
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
                        if (property0.NameEquals("discoveryUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                discoveryUrl = null;
                                continue;
                            }
                            discoveryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("intellectualPropertyPublisher"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                intellectualPropertyPublisher = null;
                                continue;
                            }
                            intellectualPropertyPublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                managedResourceGroup = null;
                                continue;
                            }
                            managedResourceGroup = ArmResourceId.DeserializeArmResourceId(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mlFlowRegistryUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                mlFlowRegistryUri = null;
                                continue;
                            }
                            mlFlowRegistryUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateEndpointConnections = null;
                                continue;
                            }
                            List<RegistryPrivateEndpointConnection> array = new List<RegistryPrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RegistryPrivateEndpointConnection.DeserializeRegistryPrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicNetworkAccess = null;
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("regionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                regionDetails = null;
                                continue;
                            }
                            List<RegistryRegionArmDetails> array = new List<RegistryRegionArmDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RegistryRegionArmDetails.DeserializeRegistryRegionArmDetails(item));
                            }
                            regionDetails = array;
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
            return new MachineLearningRegistryData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, kind.Value, sku.Value, discoveryUrl.Value, intellectualPropertyPublisher.Value, managedResourceGroup.Value, mlFlowRegistryUri.Value, Optional.ToList(privateEndpointConnections), publicNetworkAccess.Value, Optional.ToList(regionDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningRegistryData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningRegistryData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningRegistryData IPersistableModel<MachineLearningRegistryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningRegistryData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningRegistryData(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningRegistryData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
