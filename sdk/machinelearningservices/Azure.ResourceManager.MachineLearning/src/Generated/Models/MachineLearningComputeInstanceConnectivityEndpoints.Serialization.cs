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
    public partial class MachineLearningComputeInstanceConnectivityEndpoints : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PublicIPAddress))
                {
                    if (PublicIPAddress != null)
                    {
                        writer.WritePropertyName("publicIpAddress"u8);
                        writer.WriteStringValue(PublicIPAddress);
                    }
                    else
                    {
                        writer.WriteNull("publicIpAddress");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PrivateIPAddress))
                {
                    if (PrivateIPAddress != null)
                    {
                        writer.WritePropertyName("privateIpAddress"u8);
                        writer.WriteStringValue(PrivateIPAddress);
                    }
                    else
                    {
                        writer.WriteNull("privateIpAddress");
                    }
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

        MachineLearningComputeInstanceConnectivityEndpoints IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceConnectivityEndpoints(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceConnectivityEndpoints DeserializeMachineLearningComputeInstanceConnectivityEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> publicIPAddress = default;
            Optional<string> privateIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        publicIPAddress = null;
                        continue;
                    }
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateIPAddress = null;
                        continue;
                    }
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningComputeInstanceConnectivityEndpoints(publicIPAddress.Value, privateIPAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<MachineLearningComputeInstanceConnectivityEndpoints>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningComputeInstanceConnectivityEndpoints IModel<MachineLearningComputeInstanceConnectivityEndpoints>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningComputeInstanceConnectivityEndpoints(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MachineLearningComputeInstanceConnectivityEndpoints>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
