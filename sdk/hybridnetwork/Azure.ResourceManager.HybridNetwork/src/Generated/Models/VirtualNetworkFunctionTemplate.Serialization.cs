// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    [PersistableModelProxy(typeof(UnknownVirtualNetworkFunctionTemplate))]
    public partial class VirtualNetworkFunctionTemplate : IUtf8JsonSerializable, IJsonModel<VirtualNetworkFunctionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkFunctionTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualNetworkFunctionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
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
            writer.WriteEndObject();
        }

        VirtualNetworkFunctionTemplate IJsonModel<VirtualNetworkFunctionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkFunctionTemplate(document.RootElement, options);
        }

        internal static VirtualNetworkFunctionTemplate DeserializeVirtualNetworkFunctionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("nfviType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureCore": return AzureCoreNetworkFunctionTemplate.DeserializeAzureCoreNetworkFunctionTemplate(element, options);
                    case "AzureOperatorNexus": return AzureOperatorNexusNetworkFunctionTemplate.DeserializeAzureOperatorNexusNetworkFunctionTemplate(element, options);
                }
            }
            return UnknownVirtualNetworkFunctionTemplate.DeserializeUnknownVirtualNetworkFunctionTemplate(element, options);
        }

        BinaryData IPersistableModel<VirtualNetworkFunctionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        VirtualNetworkFunctionTemplate IPersistableModel<VirtualNetworkFunctionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkFunctionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkFunctionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
