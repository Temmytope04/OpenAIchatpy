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
    public partial class SynapseIntegrationRuntimeMonitoringResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseIntegrationRuntimeMonitoringResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseIntegrationRuntimeMonitoringResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseIntegrationRuntimeMonitoringResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeMonitoringResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Nodes))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SynapseIntegrationRuntimeNodeMonitoringResult>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SynapseIntegrationRuntimeMonitoringResult DeserializeSynapseIntegrationRuntimeMonitoringResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<SynapseIntegrationRuntimeNodeMonitoringResult>> nodes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIntegrationRuntimeNodeMonitoringResult> array = new List<SynapseIntegrationRuntimeNodeMonitoringResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeNodeMonitoringResult.DeserializeSynapseIntegrationRuntimeNodeMonitoringResult(item));
                    }
                    nodes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseIntegrationRuntimeMonitoringResult(name.Value, Optional.ToList(nodes), rawData);
        }

        SynapseIntegrationRuntimeMonitoringResult IModelJsonSerializable<SynapseIntegrationRuntimeMonitoringResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeMonitoringResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeMonitoringResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseIntegrationRuntimeMonitoringResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeMonitoringResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseIntegrationRuntimeMonitoringResult IModelSerializable<SynapseIntegrationRuntimeMonitoringResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeMonitoringResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseIntegrationRuntimeMonitoringResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseIntegrationRuntimeMonitoringResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseIntegrationRuntimeMonitoringResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseIntegrationRuntimeMonitoringResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseIntegrationRuntimeMonitoringResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseIntegrationRuntimeMonitoringResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseIntegrationRuntimeMonitoringResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
