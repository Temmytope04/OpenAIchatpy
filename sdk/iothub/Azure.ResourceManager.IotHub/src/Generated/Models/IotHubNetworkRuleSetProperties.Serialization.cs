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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubNetworkRuleSetProperties : IUtf8JsonSerializable, IJsonModel<IotHubNetworkRuleSetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubNetworkRuleSetProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<IotHubNetworkRuleSetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<IotHubNetworkRuleSetProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<IotHubNetworkRuleSetProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            writer.WritePropertyName("applyToBuiltInEventHubEndpoint"u8);
            writer.WriteBooleanValue(ApplyToBuiltInEventHubEndpoint);
            writer.WritePropertyName("ipRules"u8);
            writer.WriteStartArray();
            foreach (var item in IPRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        IotHubNetworkRuleSetProperties IJsonModel<IotHubNetworkRuleSetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubNetworkRuleSetProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubNetworkRuleSetProperties(document.RootElement, options);
        }

        internal static IotHubNetworkRuleSetProperties DeserializeIotHubNetworkRuleSetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IotHubNetworkRuleSetDefaultAction> defaultAction = default;
            bool applyToBuiltInEventHubEndpoint = default;
            IList<IotHubNetworkRuleSetIPRule> ipRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new IotHubNetworkRuleSetDefaultAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applyToBuiltInEventHubEndpoint"u8))
                {
                    applyToBuiltInEventHubEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    List<IotHubNetworkRuleSetIPRule> array = new List<IotHubNetworkRuleSetIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubNetworkRuleSetIPRule.DeserializeIotHubNetworkRuleSetIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubNetworkRuleSetProperties(Optional.ToNullable(defaultAction), applyToBuiltInEventHubEndpoint, ipRules, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubNetworkRuleSetProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubNetworkRuleSetProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotHubNetworkRuleSetProperties IPersistableModel<IotHubNetworkRuleSetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotHubNetworkRuleSetProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotHubNetworkRuleSetProperties(document.RootElement, options);
        }

        string IPersistableModel<IotHubNetworkRuleSetProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
