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
    public partial class SynapseGetSsisObjectMetadataContent : IUtf8JsonSerializable, IModelJsonSerializable<SynapseGetSsisObjectMetadataContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseGetSsisObjectMetadataContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseGetSsisObjectMetadataContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseGetSsisObjectMetadataContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
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

        internal static SynapseGetSsisObjectMetadataContent DeserializeSynapseGetSsisObjectMetadataContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metadataPath = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataPath"u8))
                {
                    metadataPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseGetSsisObjectMetadataContent(metadataPath.Value, rawData);
        }

        SynapseGetSsisObjectMetadataContent IModelJsonSerializable<SynapseGetSsisObjectMetadataContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseGetSsisObjectMetadataContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseGetSsisObjectMetadataContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseGetSsisObjectMetadataContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseGetSsisObjectMetadataContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseGetSsisObjectMetadataContent IModelSerializable<SynapseGetSsisObjectMetadataContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseGetSsisObjectMetadataContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseGetSsisObjectMetadataContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseGetSsisObjectMetadataContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseGetSsisObjectMetadataContent"/> to convert. </param>
        public static implicit operator RequestContent(SynapseGetSsisObjectMetadataContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseGetSsisObjectMetadataContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseGetSsisObjectMetadataContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseGetSsisObjectMetadataContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
