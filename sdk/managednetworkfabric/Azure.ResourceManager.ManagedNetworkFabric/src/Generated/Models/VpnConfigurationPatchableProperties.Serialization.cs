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
    public partial class VpnConfigurationPatchableProperties : IUtf8JsonSerializable, IJsonModel<VpnConfigurationPatchableProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnConfigurationPatchableProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<VpnConfigurationPatchableProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkToNetworkInterconnectId))
            {
                writer.WritePropertyName("networkToNetworkInterconnectId"u8);
                writer.WriteStringValue(NetworkToNetworkInterconnectId);
            }
            if (Optional.IsDefined(PeeringOption))
            {
                writer.WritePropertyName("peeringOption"u8);
                writer.WriteStringValue(PeeringOption.Value.ToString());
            }
            if (Optional.IsDefined(OptionBProperties))
            {
                writer.WritePropertyName("optionBProperties"u8);
                writer.WriteObjectValue(OptionBProperties);
            }
            if (Optional.IsDefined(OptionAProperties))
            {
                writer.WritePropertyName("optionAProperties"u8);
                writer.WriteObjectValue(OptionAProperties);
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

        VpnConfigurationPatchableProperties IJsonModel<VpnConfigurationPatchableProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
        }

        internal static VpnConfigurationPatchableProperties DeserializeVpnConfigurationPatchableProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> networkToNetworkInterconnectId = default;
            Optional<PeeringOption> peeringOption = default;
            Optional<OptionBProperties> optionBProperties = default;
            Optional<VpnConfigurationPatchableOptionAProperties> optionAProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkToNetworkInterconnectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkToNetworkInterconnectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringOption = new PeeringOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optionBProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionBProperties = OptionBProperties.DeserializeOptionBProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("optionAProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionAProperties = VpnConfigurationPatchableOptionAProperties.DeserializeVpnConfigurationPatchableOptionAProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnConfigurationPatchableProperties(networkToNetworkInterconnectId.Value, Optional.ToNullable(peeringOption), optionBProperties.Value, optionAProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<VpnConfigurationPatchableProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VpnConfigurationPatchableProperties IModel<VpnConfigurationPatchableProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<VpnConfigurationPatchableProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
