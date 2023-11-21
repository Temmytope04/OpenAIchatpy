// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualWanSecurityProviders : IUtf8JsonSerializable, IJsonModel<VirtualWanSecurityProviders>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualWanSecurityProviders>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualWanSecurityProviders>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanSecurityProviders>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualWanSecurityProviders)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SupportedProviders))
            {
                writer.WritePropertyName("supportedProviders"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedProviders)
                {
                    writer.WriteObjectValue(item);
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

        VirtualWanSecurityProviders IJsonModel<VirtualWanSecurityProviders>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanSecurityProviders>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualWanSecurityProviders)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualWanSecurityProviders(document.RootElement, options);
        }

        internal static VirtualWanSecurityProviders DeserializeVirtualWanSecurityProviders(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<VirtualWanSecurityProvider>> supportedProviders = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualWanSecurityProvider> array = new List<VirtualWanSecurityProvider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualWanSecurityProvider.DeserializeVirtualWanSecurityProvider(item));
                    }
                    supportedProviders = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualWanSecurityProviders(Optional.ToList(supportedProviders), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualWanSecurityProviders>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanSecurityProviders>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualWanSecurityProviders)} does not support '{options.Format}' format.");
            }
        }

        VirtualWanSecurityProviders IPersistableModel<VirtualWanSecurityProviders>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualWanSecurityProviders>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualWanSecurityProviders(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualWanSecurityProviders)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualWanSecurityProviders>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
