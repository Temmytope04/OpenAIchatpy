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
    public partial class SynapseResourceMoveDefinition : IUtf8JsonSerializable, IModelJsonSerializable<SynapseResourceMoveDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseResourceMoveDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseResourceMoveDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseResourceMoveDefinition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        internal static SynapseResourceMoveDefinition DeserializeSynapseResourceMoveDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseResourceMoveDefinition(id, rawData);
        }

        SynapseResourceMoveDefinition IModelJsonSerializable<SynapseResourceMoveDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseResourceMoveDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseResourceMoveDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseResourceMoveDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseResourceMoveDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseResourceMoveDefinition IModelSerializable<SynapseResourceMoveDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseResourceMoveDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseResourceMoveDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseResourceMoveDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseResourceMoveDefinition"/> to convert. </param>
        public static implicit operator RequestContent(SynapseResourceMoveDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseResourceMoveDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseResourceMoveDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseResourceMoveDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
