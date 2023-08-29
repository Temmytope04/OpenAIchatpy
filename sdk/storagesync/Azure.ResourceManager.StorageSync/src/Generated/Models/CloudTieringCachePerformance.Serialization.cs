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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringCachePerformance : IUtf8JsonSerializable, IModelJsonSerializable<CloudTieringCachePerformance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudTieringCachePerformance>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudTieringCachePerformance>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static CloudTieringCachePerformance DeserializeCloudTieringCachePerformance(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<long> cacheHitBytes = default;
            Optional<long> cacheMissBytes = default;
            Optional<int> cacheHitBytesPercent = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cacheHitBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheMissBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheMissBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheHitBytesPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitBytesPercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudTieringCachePerformance(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(cacheHitBytes), Optional.ToNullable(cacheMissBytes), Optional.ToNullable(cacheHitBytesPercent), rawData);
        }

        CloudTieringCachePerformance IModelJsonSerializable<CloudTieringCachePerformance>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringCachePerformance(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudTieringCachePerformance>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudTieringCachePerformance IModelSerializable<CloudTieringCachePerformance>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudTieringCachePerformance(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CloudTieringCachePerformance model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CloudTieringCachePerformance(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudTieringCachePerformance(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
