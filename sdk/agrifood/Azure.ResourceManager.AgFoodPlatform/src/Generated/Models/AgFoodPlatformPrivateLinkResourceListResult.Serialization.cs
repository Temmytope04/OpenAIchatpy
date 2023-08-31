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
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    internal partial class AgFoodPlatformPrivateLinkResourceListResult : IUtf8JsonSerializable, IModelJsonSerializable<AgFoodPlatformPrivateLinkResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AgFoodPlatformPrivateLinkResourceListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AgFoodPlatformPrivateLinkResourceListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AgFoodPlatformPrivateLinkResourceData>)item).Serialize(writer, options);
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

        internal static AgFoodPlatformPrivateLinkResourceListResult DeserializeAgFoodPlatformPrivateLinkResourceListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AgFoodPlatformPrivateLinkResourceData>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgFoodPlatformPrivateLinkResourceData> array = new List<AgFoodPlatformPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AgFoodPlatformPrivateLinkResourceData.DeserializeAgFoodPlatformPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AgFoodPlatformPrivateLinkResourceListResult(Optional.ToList(value), rawData);
        }

        AgFoodPlatformPrivateLinkResourceListResult IModelJsonSerializable<AgFoodPlatformPrivateLinkResourceListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAgFoodPlatformPrivateLinkResourceListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AgFoodPlatformPrivateLinkResourceListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AgFoodPlatformPrivateLinkResourceListResult IModelSerializable<AgFoodPlatformPrivateLinkResourceListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAgFoodPlatformPrivateLinkResourceListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AgFoodPlatformPrivateLinkResourceListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AgFoodPlatformPrivateLinkResourceListResult"/> to convert. </param>
        public static implicit operator RequestContent(AgFoodPlatformPrivateLinkResourceListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AgFoodPlatformPrivateLinkResourceListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AgFoodPlatformPrivateLinkResourceListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAgFoodPlatformPrivateLinkResourceListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
