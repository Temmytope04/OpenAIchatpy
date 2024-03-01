// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntime : IUtf8JsonSerializable, IJsonModel<SynapseSelfHostedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSelfHostedIntegrationRuntime>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSelfHostedIntegrationRuntime>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntime)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(IntegrationRuntimeType.ToString());
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (LinkedInfo != null)
            {
                writer.WritePropertyName("linkedInfo"u8);
                writer.WriteObjectValue(LinkedInfo);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseSelfHostedIntegrationRuntime IJsonModel<SynapseSelfHostedIntegrationRuntime>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntime)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSelfHostedIntegrationRuntime(document.RootElement, options);
        }

        internal static SynapseSelfHostedIntegrationRuntime DeserializeSynapseSelfHostedIntegrationRuntime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            string description = default;
            SynapseLinkedIntegrationRuntimeType linkedInfo = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkedInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedInfo = SynapseLinkedIntegrationRuntimeType.DeserializeSynapseLinkedIntegrationRuntimeType(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntime(type, description, additionalProperties, linkedInfo);
        }

        BinaryData IPersistableModel<SynapseSelfHostedIntegrationRuntime>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        SynapseSelfHostedIntegrationRuntime IPersistableModel<SynapseSelfHostedIntegrationRuntime>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSelfHostedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSelfHostedIntegrationRuntime(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSelfHostedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSelfHostedIntegrationRuntime>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
