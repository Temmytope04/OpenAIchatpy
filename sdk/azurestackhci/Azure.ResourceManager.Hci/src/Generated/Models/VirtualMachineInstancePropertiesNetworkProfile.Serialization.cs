// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class VirtualMachineInstancePropertiesNetworkProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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
            writer.WriteEndObject();
        }

        VirtualMachineInstancePropertiesNetworkProfile IJsonModel<VirtualMachineInstancePropertiesNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesNetworkProfile(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesNetworkProfile DeserializeVirtualMachineInstancePropertiesNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WritableSubResource> networkInterfaces = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesNetworkProfile(networkInterfaces ?? new ChangeTrackingList<WritableSubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesNetworkProfile IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
