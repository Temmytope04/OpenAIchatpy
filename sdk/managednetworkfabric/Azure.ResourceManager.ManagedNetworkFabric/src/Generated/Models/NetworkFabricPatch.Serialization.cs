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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricPatch : IUtf8JsonSerializable, IJsonModel<NetworkFabricPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricPatch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkFabricPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(RackCount))
            {
                writer.WritePropertyName("rackCount"u8);
                writer.WriteNumberValue(RackCount.Value);
            }
            if (Optional.IsDefined(ServerCountPerRack))
            {
                writer.WritePropertyName("serverCountPerRack"u8);
                writer.WriteNumberValue(ServerCountPerRack.Value);
            }
            if (Optional.IsDefined(IPv4Prefix))
            {
                writer.WritePropertyName("ipv4Prefix"u8);
                writer.WriteStringValue(IPv4Prefix);
            }
            if (Optional.IsDefined(IPv6Prefix))
            {
                writer.WritePropertyName("ipv6Prefix"u8);
                writer.WriteStringValue(IPv6Prefix);
            }
            if (Optional.IsDefined(FabricAsn))
            {
                writer.WritePropertyName("fabricASN"u8);
                writer.WriteNumberValue(FabricAsn.Value);
            }
            if (Optional.IsDefined(TerminalServerConfiguration))
            {
                writer.WritePropertyName("terminalServerConfiguration"u8);
                writer.WriteObjectValue(TerminalServerConfiguration);
            }
            if (Optional.IsDefined(ManagementNetworkConfiguration))
            {
                writer.WritePropertyName("managementNetworkConfiguration"u8);
                writer.WriteObjectValue(ManagementNetworkConfiguration);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        NetworkFabricPatch IJsonModel<NetworkFabricPatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricPatch(document.RootElement, options);
        }

        internal static NetworkFabricPatch DeserializeNetworkFabricPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> annotation = default;
            Optional<int> rackCount = default;
            Optional<int> serverCountPerRack = default;
            Optional<string> ipv4Prefix = default;
            Optional<string> ipv6Prefix = default;
            Optional<long> fabricAsn = default;
            Optional<NetworkFabricPatchablePropertiesTerminalServerConfiguration> terminalServerConfiguration = default;
            Optional<ManagementNetworkConfigurationPatchableProperties> managementNetworkConfiguration = default;
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
                        if (property0.NameEquals("rackCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rackCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverCountPerRack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverCountPerRack = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipv4Prefix"u8))
                        {
                            ipv4Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6Prefix"u8))
                        {
                            ipv6Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fabricASN"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fabricAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("terminalServerConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            terminalServerConfiguration = NetworkFabricPatchablePropertiesTerminalServerConfiguration.DeserializeNetworkFabricPatchablePropertiesTerminalServerConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managementNetworkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementNetworkConfiguration = ManagementNetworkConfigurationPatchableProperties.DeserializeManagementNetworkConfigurationPatchableProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFabricPatch(Optional.ToDictionary(tags), serializedAdditionalRawData, annotation.Value, Optional.ToNullable(rackCount), Optional.ToNullable(serverCountPerRack), ipv4Prefix.Value, ipv6Prefix.Value, Optional.ToNullable(fabricAsn), terminalServerConfiguration.Value, managementNetworkConfiguration.Value);
        }

        BinaryData IModel<NetworkFabricPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkFabricPatch IModel<NetworkFabricPatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFabricPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkFabricPatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkFabricPatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
