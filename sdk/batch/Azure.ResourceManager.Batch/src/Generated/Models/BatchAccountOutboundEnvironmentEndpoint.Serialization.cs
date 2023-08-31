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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountOutboundEnvironmentEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<BatchAccountOutboundEnvironmentEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchAccountOutboundEnvironmentEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchAccountOutboundEnvironmentEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static BatchAccountOutboundEnvironmentEndpoint DeserializeBatchAccountOutboundEnvironmentEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<IReadOnlyList<BatchAccountEndpointDependency>> endpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchAccountEndpointDependency> array = new List<BatchAccountEndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchAccountEndpointDependency.DeserializeBatchAccountEndpointDependency(item));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchAccountOutboundEnvironmentEndpoint(category.Value, Optional.ToList(endpoints), rawData);
        }

        BatchAccountOutboundEnvironmentEndpoint IModelJsonSerializable<BatchAccountOutboundEnvironmentEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountOutboundEnvironmentEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchAccountOutboundEnvironmentEndpoint>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchAccountOutboundEnvironmentEndpoint IModelSerializable<BatchAccountOutboundEnvironmentEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchAccountOutboundEnvironmentEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchAccountOutboundEnvironmentEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchAccountOutboundEnvironmentEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(BatchAccountOutboundEnvironmentEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchAccountOutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchAccountOutboundEnvironmentEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchAccountOutboundEnvironmentEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
