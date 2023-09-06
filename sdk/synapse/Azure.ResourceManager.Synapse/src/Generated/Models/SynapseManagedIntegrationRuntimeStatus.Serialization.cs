// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeStatus : IUtf8JsonSerializable, IModelJsonSerializable<SynapseManagedIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseManagedIntegrationRuntimeStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseManagedIntegrationRuntimeStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeStatus>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SynapseManagedIntegrationRuntimeStatus DeserializeSynapseManagedIntegrationRuntimeStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> dataFactoryName = default;
            Optional<SynapseIntegrationRuntimeState> state = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<IReadOnlyList<SynapseManagedIntegrationRuntimeNode>> nodes = default;
            Optional<IReadOnlyList<SynapseManagedIntegrationRuntimeError>> otherErrors = default;
            Optional<SynapseManagedIntegrationRuntimeOperationResult> lastOperation = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SynapseIntegrationRuntimeState(property.Value.GetString());
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
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeNode> array = new List<SynapseManagedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeNode.DeserializeSynapseManagedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("otherErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeError> array = new List<SynapseManagedIntegrationRuntimeError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeError.DeserializeSynapseManagedIntegrationRuntimeError(item));
                            }
                            otherErrors = array;
                            continue;
                        }
                        if (property0.NameEquals("lastOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOperation = SynapseManagedIntegrationRuntimeOperationResult.DeserializeSynapseManagedIntegrationRuntimeOperationResult(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeStatus(type, dataFactoryName.Value, Optional.ToNullable(state), additionalProperties, Optional.ToNullable(createTime), Optional.ToList(nodes), Optional.ToList(otherErrors), lastOperation.Value);
        }

        SynapseManagedIntegrationRuntimeStatus IModelJsonSerializable<SynapseManagedIntegrationRuntimeStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseManagedIntegrationRuntimeStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseManagedIntegrationRuntimeStatus IModelSerializable<SynapseManagedIntegrationRuntimeStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseManagedIntegrationRuntimeStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseManagedIntegrationRuntimeStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseManagedIntegrationRuntimeStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseManagedIntegrationRuntimeStatus"/> to convert. </param>
        public static implicit operator RequestContent(SynapseManagedIntegrationRuntimeStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseManagedIntegrationRuntimeStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseManagedIntegrationRuntimeStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseManagedIntegrationRuntimeStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
