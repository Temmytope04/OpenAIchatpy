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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksComputeProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningAksComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAksComputeProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningAksComputeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterFqdn))
            {
                if (ClusterFqdn != null)
                {
                    writer.WritePropertyName("clusterFqdn"u8);
                    writer.WriteStringValue(ClusterFqdn);
                }
                else
                {
                    writer.WriteNull("clusterFqdn");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(SystemServices))
                {
                    if (SystemServices != null)
                    {
                        writer.WritePropertyName("systemServices"u8);
                        writer.WriteStartArray();
                        foreach (var item in SystemServices)
                        {
                            writer.WriteObjectValue(item);
                        }
                        writer.WriteEndArray();
                    }
                    else
                    {
                        writer.WriteNull("systemServices");
                    }
                }
            }
            if (Optional.IsDefined(AgentCount))
            {
                if (AgentCount != null)
                {
                    writer.WritePropertyName("agentCount"u8);
                    writer.WriteNumberValue(AgentCount.Value);
                }
                else
                {
                    writer.WriteNull("agentCount");
                }
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                if (AgentVmSize != null)
                {
                    writer.WritePropertyName("agentVmSize"u8);
                    writer.WriteStringValue(AgentVmSize);
                }
                else
                {
                    writer.WriteNull("agentVmSize");
                }
            }
            if (Optional.IsDefined(ClusterPurpose))
            {
                writer.WritePropertyName("clusterPurpose"u8);
                writer.WriteStringValue(ClusterPurpose.Value.ToString());
            }
            if (Optional.IsDefined(SslConfiguration))
            {
                if (SslConfiguration != null)
                {
                    writer.WritePropertyName("sslConfiguration"u8);
                    writer.WriteObjectValue(SslConfiguration);
                }
                else
                {
                    writer.WriteNull("sslConfiguration");
                }
            }
            if (Optional.IsDefined(AksNetworkingConfiguration))
            {
                if (AksNetworkingConfiguration != null)
                {
                    writer.WritePropertyName("aksNetworkingConfiguration"u8);
                    writer.WriteObjectValue(AksNetworkingConfiguration);
                }
                else
                {
                    writer.WriteNull("aksNetworkingConfiguration");
                }
            }
            if (Optional.IsDefined(LoadBalancerType))
            {
                writer.WritePropertyName("loadBalancerType"u8);
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerSubnet))
            {
                if (LoadBalancerSubnet != null)
                {
                    writer.WritePropertyName("loadBalancerSubnet"u8);
                    writer.WriteStringValue(LoadBalancerSubnet);
                }
                else
                {
                    writer.WriteNull("loadBalancerSubnet");
                }
            }
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

        MachineLearningAksComputeProperties IJsonModel<MachineLearningAksComputeProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksComputeProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAksComputeProperties(document.RootElement, options);
        }

        internal static MachineLearningAksComputeProperties DeserializeMachineLearningAksComputeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clusterFqdn = default;
            Optional<IReadOnlyList<MachineLearningComputeSystemService>> systemServices = default;
            Optional<int?> agentCount = default;
            Optional<string> agentVmSize = default;
            Optional<MachineLearningClusterPurpose> clusterPurpose = default;
            Optional<MachineLearningSslConfiguration> sslConfiguration = default;
            Optional<MachineLearningAksNetworkingConfiguration> aksNetworkingConfiguration = default;
            Optional<MachineLearningLoadBalancerType> loadBalancerType = default;
            Optional<string> loadBalancerSubnet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clusterFqdn = null;
                        continue;
                    }
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemServices = null;
                        continue;
                    }
                    List<MachineLearningComputeSystemService> array = new List<MachineLearningComputeSystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeSystemService.DeserializeMachineLearningComputeSystemService(item));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("agentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        agentCount = null;
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        agentVmSize = null;
                        continue;
                    }
                    agentVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterPurpose"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterPurpose = new MachineLearningClusterPurpose(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sslConfiguration = null;
                        continue;
                    }
                    sslConfiguration = MachineLearningSslConfiguration.DeserializeMachineLearningSslConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("aksNetworkingConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        aksNetworkingConfiguration = null;
                        continue;
                    }
                    aksNetworkingConfiguration = MachineLearningAksNetworkingConfiguration.DeserializeMachineLearningAksNetworkingConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("loadBalancerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerType = new MachineLearningLoadBalancerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerSubnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        loadBalancerSubnet = null;
                        continue;
                    }
                    loadBalancerSubnet = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAksComputeProperties(clusterFqdn.Value, Optional.ToList(systemServices), Optional.ToNullable(agentCount), agentVmSize.Value, Optional.ToNullable(clusterPurpose), sslConfiguration.Value, aksNetworkingConfiguration.Value, Optional.ToNullable(loadBalancerType), loadBalancerSubnet.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<MachineLearningAksComputeProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksComputeProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningAksComputeProperties IModel<MachineLearningAksComputeProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksComputeProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningAksComputeProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningAksComputeProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
