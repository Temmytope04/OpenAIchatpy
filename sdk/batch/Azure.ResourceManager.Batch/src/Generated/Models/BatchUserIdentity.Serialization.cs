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
    public partial class BatchUserIdentity : IUtf8JsonSerializable, IModelJsonSerializable<BatchUserIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BatchUserIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BatchUserIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(AutoUser))
            {
                writer.WritePropertyName("autoUser"u8);
                if (AutoUser is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BatchAutoUserSpecification>)AutoUser).Serialize(writer, options);
                }
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

        internal static BatchUserIdentity DeserializeBatchUserIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> userName = default;
            Optional<BatchAutoUserSpecification> autoUser = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUser = BatchAutoUserSpecification.DeserializeBatchAutoUserSpecification(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BatchUserIdentity(userName.Value, autoUser.Value, rawData);
        }

        BatchUserIdentity IModelJsonSerializable<BatchUserIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchUserIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BatchUserIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BatchUserIdentity IModelSerializable<BatchUserIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBatchUserIdentity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BatchUserIdentity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BatchUserIdentity"/> to convert. </param>
        public static implicit operator RequestContent(BatchUserIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BatchUserIdentity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BatchUserIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBatchUserIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
