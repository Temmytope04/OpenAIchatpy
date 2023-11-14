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

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownNetworkFunctionDefinitionVersionPropertiesFormat : IUtf8JsonSerializable, IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>)} interface");
            }

            writer.WriteStartObject();
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
                if (Optional.IsDefined(VersionState))
                {
                    writer.WritePropertyName("versionState"u8);
                    writer.WriteStringValue(VersionState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DeployParameters))
            {
                writer.WritePropertyName("deployParameters"u8);
                writer.WriteStringValue(DeployParameters);
            }
            writer.WritePropertyName("networkFunctionType"u8);
            writer.WriteStringValue(NetworkFunctionType.ToString());
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

        NetworkFunctionDefinitionVersionPropertiesFormat IJsonModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownNetworkFunctionDefinitionVersionPropertiesFormat(document.RootElement, options);
        }

        internal static UnknownNetworkFunctionDefinitionVersionPropertiesFormat DeserializeUnknownNetworkFunctionDefinitionVersionPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<VersionState> versionState = default;
            Optional<string> description = default;
            Optional<string> deployParameters = default;
            NetworkFunctionType networkFunctionType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
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
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deployParameters"u8))
                {
                    deployParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionType"u8))
                {
                    networkFunctionType = new NetworkFunctionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownNetworkFunctionDefinitionVersionPropertiesFormat(Optional.ToNullable(provisioningState), Optional.ToNullable(versionState), description.Value, deployParameters.Value, networkFunctionType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkFunctionDefinitionVersionPropertiesFormat IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkFunctionDefinitionVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUnknownNetworkFunctionDefinitionVersionPropertiesFormat(document.RootElement, options);
        }

        string IPersistableModel<NetworkFunctionDefinitionVersionPropertiesFormat>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
