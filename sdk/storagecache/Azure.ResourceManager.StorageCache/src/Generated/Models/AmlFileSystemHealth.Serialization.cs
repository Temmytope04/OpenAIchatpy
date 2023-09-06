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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemHealth : IUtf8JsonSerializable, IModelJsonSerializable<AmlFileSystemHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmlFileSystemHealth>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmlFileSystemHealth>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemHealth>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteStringValue(StatusCode);
            }
            if (Optional.IsDefined(StatusDescription))
            {
                writer.WritePropertyName("statusDescription"u8);
                writer.WriteStringValue(StatusDescription);
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

        internal static AmlFileSystemHealth DeserializeAmlFileSystemHealth(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AmlFileSystemHealthStateType> state = default;
            Optional<string> statusCode = default;
            Optional<string> statusDescription = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AmlFileSystemHealthStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusDescription"u8))
                {
                    statusDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AmlFileSystemHealth(Optional.ToNullable(state), statusCode.Value, statusDescription.Value, rawData);
        }

        AmlFileSystemHealth IModelJsonSerializable<AmlFileSystemHealth>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemHealth>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemHealth(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmlFileSystemHealth>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemHealth>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmlFileSystemHealth IModelSerializable<AmlFileSystemHealth>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmlFileSystemHealth>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmlFileSystemHealth(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmlFileSystemHealth"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmlFileSystemHealth"/> to convert. </param>
        public static implicit operator RequestContent(AmlFileSystemHealth model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmlFileSystemHealth"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmlFileSystemHealth(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmlFileSystemHealth(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
