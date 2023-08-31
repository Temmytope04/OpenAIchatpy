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
    public partial class BatchEndpointAccessProfile : IUtf8JsonSerializable, IModelJsonSerializable<BatchEndpointAccessProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchEndpointAccessProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchEndpointAccessProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("defaultAction"u8);
            writer.WriteStringValue(DefaultAction.ToSerialString());
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BatchIPRule>)item).Serialize(writer, options);
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

        internal static BatchEndpointAccessProfile DeserializeBatchEndpointAccessProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchEndpointAccessDefaultAction defaultAction = default;
            Optional<IList<BatchIPRule>> ipRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    defaultAction = property.Value.GetString().ToBatchEndpointAccessDefaultAction();
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchIPRule> array = new List<BatchIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchIPRule.DeserializeBatchIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchEndpointAccessProfile(defaultAction, Optional.ToList(ipRules), rawData);
        }

        BatchEndpointAccessProfile IModelJsonSerializable<BatchEndpointAccessProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchEndpointAccessProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchEndpointAccessProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchEndpointAccessProfile IModelSerializable<BatchEndpointAccessProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchEndpointAccessProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchEndpointAccessProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchEndpointAccessProfile"/> to convert. </param>
        public static implicit operator RequestContent(BatchEndpointAccessProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchEndpointAccessProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchEndpointAccessProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchEndpointAccessProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
