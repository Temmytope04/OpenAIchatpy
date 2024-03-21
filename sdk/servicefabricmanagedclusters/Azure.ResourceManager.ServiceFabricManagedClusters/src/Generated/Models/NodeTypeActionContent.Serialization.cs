// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeActionContent : IUtf8JsonSerializable, IJsonModel<NodeTypeActionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeActionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeTypeActionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeActionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsForced))
            {
                writer.WritePropertyName("force"u8);
                writer.WriteBooleanValue(IsForced.Value);
            }
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("updateType"u8);
                writer.WriteStringValue(UpdateType.Value.ToString());
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

        NodeTypeActionContent IJsonModel<NodeTypeActionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeActionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeActionContent(document.RootElement, options);
        }

        internal static NodeTypeActionContent DeserializeNodeTypeActionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> nodes = default;
            bool? force = default;
            ServiceFabricManagedClusterUpdateType? updateType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nodes = array;
                    continue;
                }
                if (property.NameEquals("force"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    force = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("updateType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateType = new ServiceFabricManagedClusterUpdateType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeTypeActionContent(nodes ?? new ChangeTrackingList<string>(), force, updateType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeTypeActionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeTypeActionContent)} does not support '{options.Format}' format.");
            }
        }

        NodeTypeActionContent IPersistableModel<NodeTypeActionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeTypeActionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeTypeActionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeTypeActionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
