// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DedicatedHostGroupInstanceView : IUtf8JsonSerializable, IJsonModel<DedicatedHostGroupInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostGroupInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DedicatedHostGroupInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Hosts is ChangeTrackingList<DedicatedHostInstanceViewWithName> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("hosts"u8);
                writer.WriteStartArray();
                foreach (var item in Hosts)
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

        DedicatedHostGroupInstanceView IJsonModel<DedicatedHostGroupInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostGroupInstanceView(document.RootElement, options);
        }

        internal static DedicatedHostGroupInstanceView DeserializeDedicatedHostGroupInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DedicatedHostInstanceViewWithName> hosts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hosts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DedicatedHostInstanceViewWithName> array = new List<DedicatedHostInstanceViewWithName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHostInstanceViewWithName.DeserializeDedicatedHostInstanceViewWithName(item, options));
                    }
                    hosts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DedicatedHostGroupInstanceView(hosts ?? new ChangeTrackingList<DedicatedHostInstanceViewWithName>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DedicatedHostGroupInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostGroupInstanceView)} does not support '{options.Format}' format.");
            }
        }

        DedicatedHostGroupInstanceView IPersistableModel<DedicatedHostGroupInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedHostGroupInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostGroupInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHostGroupInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
