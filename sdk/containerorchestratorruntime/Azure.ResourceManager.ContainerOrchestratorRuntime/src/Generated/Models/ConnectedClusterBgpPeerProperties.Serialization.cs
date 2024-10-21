// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    public partial class ConnectedClusterBgpPeerProperties : IUtf8JsonSerializable, IJsonModel<ConnectedClusterBgpPeerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedClusterBgpPeerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectedClusterBgpPeerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterBgpPeerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterBgpPeerProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("myAsn"u8);
            writer.WriteNumberValue(MyAsn);
            writer.WritePropertyName("peerAsn"u8);
            writer.WriteNumberValue(PeerAsn);
            writer.WritePropertyName("peerAddress"u8);
            writer.WriteStringValue(PeerAddress);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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
        }

        ConnectedClusterBgpPeerProperties IJsonModel<ConnectedClusterBgpPeerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterBgpPeerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterBgpPeerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedClusterBgpPeerProperties(document.RootElement, options);
        }

        internal static ConnectedClusterBgpPeerProperties DeserializeConnectedClusterBgpPeerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int myAsn = default;
            int peerAsn = default;
            string peerAddress = default;
            ContainerOrchestratorProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("myAsn"u8))
                {
                    myAsn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    peerAsn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peerAddress"u8))
                {
                    peerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ContainerOrchestratorProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectedClusterBgpPeerProperties(myAsn, peerAsn, peerAddress, provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectedClusterBgpPeerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterBgpPeerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterBgpPeerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectedClusterBgpPeerProperties IPersistableModel<ConnectedClusterBgpPeerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterBgpPeerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectedClusterBgpPeerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterBgpPeerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedClusterBgpPeerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
