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
    public partial class SynapseIntegrationRuntimeStatusResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseIntegrationRuntimeStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseIntegrationRuntimeStatusResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseIntegrationRuntimeStatusResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeStatusResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SynapseIntegrationRuntimeStatus>)Properties).Serialize(writer, options);
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

        internal static SynapseIntegrationRuntimeStatusResult DeserializeSynapseIntegrationRuntimeStatusResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            SynapseIntegrationRuntimeStatus properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = SynapseIntegrationRuntimeStatus.DeserializeSynapseIntegrationRuntimeStatus(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseIntegrationRuntimeStatusResult(name.Value, properties, rawData);
        }

        SynapseIntegrationRuntimeStatusResult IModelJsonSerializable<SynapseIntegrationRuntimeStatusResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeStatusResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeStatusResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseIntegrationRuntimeStatusResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeStatusResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseIntegrationRuntimeStatusResult IModelSerializable<SynapseIntegrationRuntimeStatusResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseIntegrationRuntimeStatusResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseIntegrationRuntimeStatusResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseIntegrationRuntimeStatusResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseIntegrationRuntimeStatusResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseIntegrationRuntimeStatusResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseIntegrationRuntimeStatusResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseIntegrationRuntimeStatusResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseIntegrationRuntimeStatusResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
