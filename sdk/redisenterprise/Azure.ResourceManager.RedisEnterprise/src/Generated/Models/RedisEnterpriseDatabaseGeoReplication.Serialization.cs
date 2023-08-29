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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseDatabaseGeoReplication : IUtf8JsonSerializable, IModelJsonSerializable<RedisEnterpriseDatabaseGeoReplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedisEnterpriseDatabaseGeoReplication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedisEnterpriseDatabaseGeoReplication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(GroupNickname))
            {
                writer.WritePropertyName("groupNickname"u8);
                writer.WriteStringValue(GroupNickname);
            }
            if (Optional.IsCollectionDefined(LinkedDatabases))
            {
                writer.WritePropertyName("linkedDatabases"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedDatabases)
                {
                    writer.WriteObjectValue(item);
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

        internal static RedisEnterpriseDatabaseGeoReplication DeserializeRedisEnterpriseDatabaseGeoReplication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupNickname = default;
            Optional<IList<RedisEnterpriseLinkedDatabase>> linkedDatabases = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupNickname"u8))
                {
                    groupNickname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedDatabases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RedisEnterpriseLinkedDatabase> array = new List<RedisEnterpriseLinkedDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisEnterpriseLinkedDatabase.DeserializeRedisEnterpriseLinkedDatabase(item));
                    }
                    linkedDatabases = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedisEnterpriseDatabaseGeoReplication(groupNickname.Value, Optional.ToList(linkedDatabases), rawData);
        }

        RedisEnterpriseDatabaseGeoReplication IModelJsonSerializable<RedisEnterpriseDatabaseGeoReplication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseDatabaseGeoReplication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedisEnterpriseDatabaseGeoReplication>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedisEnterpriseDatabaseGeoReplication IModelSerializable<RedisEnterpriseDatabaseGeoReplication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedisEnterpriseDatabaseGeoReplication(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RedisEnterpriseDatabaseGeoReplication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RedisEnterpriseDatabaseGeoReplication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedisEnterpriseDatabaseGeoReplication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
