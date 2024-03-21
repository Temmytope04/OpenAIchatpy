// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPPrefixRule : IUtf8JsonSerializable, IJsonModel<IPPrefixRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPPrefixRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPPrefixRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPrefixRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPPrefixRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WritePropertyName("sequenceNumber"u8);
            writer.WriteNumberValue(SequenceNumber);
            writer.WritePropertyName("networkPrefix"u8);
            writer.WriteStringValue(NetworkPrefix);
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition.Value.ToString());
            }
            if (Optional.IsDefined(SubnetMaskLength))
            {
                writer.WritePropertyName("subnetMaskLength"u8);
                writer.WriteStringValue(SubnetMaskLength);
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

        IPPrefixRule IJsonModel<IPPrefixRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPrefixRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPPrefixRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPPrefixRule(document.RootElement, options);
        }

        internal static IPPrefixRule DeserializeIPPrefixRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunityActionType action = default;
            long sequenceNumber = default;
            string networkPrefix = default;
            IPPrefixRuleCondition? condition = default;
            string subnetMaskLength = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = new CommunityActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("networkPrefix"u8))
                {
                    networkPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("condition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    condition = new IPPrefixRuleCondition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetMaskLength"u8))
                {
                    subnetMaskLength = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPPrefixRule(
                action,
                sequenceNumber,
                networkPrefix,
                condition,
                subnetMaskLength,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPPrefixRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPrefixRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IPPrefixRule)} does not support '{options.Format}' format.");
            }
        }

        IPPrefixRule IPersistableModel<IPPrefixRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPrefixRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPPrefixRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IPPrefixRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPPrefixRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
