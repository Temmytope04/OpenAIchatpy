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
    public partial class BatchAccountRegenerateKeyContent : IUtf8JsonSerializable, IModelJsonSerializable<BatchAccountRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchAccountRegenerateKeyContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchAccountRegenerateKeyContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyType.ToSerialString());
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

        internal static BatchAccountRegenerateKeyContent DeserializeBatchAccountRegenerateKeyContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchAccountKeyType keyName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString().ToBatchAccountKeyType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchAccountRegenerateKeyContent(keyName, rawData);
        }

        BatchAccountRegenerateKeyContent IModelJsonSerializable<BatchAccountRegenerateKeyContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountRegenerateKeyContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchAccountRegenerateKeyContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchAccountRegenerateKeyContent IModelSerializable<BatchAccountRegenerateKeyContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchAccountRegenerateKeyContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchAccountRegenerateKeyContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchAccountRegenerateKeyContent"/> to convert. </param>
        public static implicit operator RequestContent(BatchAccountRegenerateKeyContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchAccountRegenerateKeyContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchAccountRegenerateKeyContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchAccountRegenerateKeyContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
