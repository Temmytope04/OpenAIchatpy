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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentProperties : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IntegrationServiceEnvironmentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IntegrationServiceEnvironmentProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IntegrationServiceEnvironmentProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(IntegrationServiceEnvironmentId))
            {
                writer.WritePropertyName("integrationServiceEnvironmentId"u8);
                writer.WriteStringValue(IntegrationServiceEnvironmentId);
            }
            if (Optional.IsDefined(EndpointsConfiguration))
            {
                writer.WritePropertyName("endpointsConfiguration"u8);
                writer.WriteObjectValue(EndpointsConfiguration);
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            if (Optional.IsDefined(EncryptionConfiguration))
            {
                writer.WritePropertyName("encryptionConfiguration"u8);
                writer.WriteObjectValue(EncryptionConfiguration);
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

        IntegrationServiceEnvironmentProperties IJsonModel<IntegrationServiceEnvironmentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentProperties(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentProperties DeserializeIntegrationServiceEnvironmentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogicWorkflowProvisioningState> provisioningState = default;
            Optional<LogicWorkflowState> state = default;
            Optional<string> integrationServiceEnvironmentId = default;
            Optional<FlowEndpointsConfiguration> endpointsConfiguration = default;
            Optional<IntegrationServiceNetworkConfiguration> networkConfiguration = default;
            Optional<IntegrationServiceEnvironmenEncryptionConfiguration> encryptionConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new LogicWorkflowProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new LogicWorkflowState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("integrationServiceEnvironmentId"u8))
                {
                    integrationServiceEnvironmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointsConfiguration = FlowEndpointsConfiguration.DeserializeFlowEndpointsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = IntegrationServiceNetworkConfiguration.DeserializeIntegrationServiceNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionConfiguration = IntegrationServiceEnvironmenEncryptionConfiguration.DeserializeIntegrationServiceEnvironmenEncryptionConfiguration(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationServiceEnvironmentProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(state), integrationServiceEnvironmentId.Value, endpointsConfiguration.Value, networkConfiguration.Value, encryptionConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IntegrationServiceEnvironmentProperties IPersistableModel<IntegrationServiceEnvironmentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmentProperties(document.RootElement, options);
        }

        string IPersistableModel<IntegrationServiceEnvironmentProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
