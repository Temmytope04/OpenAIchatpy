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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class SingletonPartitionScheme : IUtf8JsonSerializable, IModelJsonSerializable<SingletonPartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SingletonPartitionScheme>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SingletonPartitionScheme>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SingletonPartitionScheme>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        internal static SingletonPartitionScheme DeserializeSingletonPartitionScheme(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartitionScheme partitionScheme = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SingletonPartitionScheme(partitionScheme, rawData);
        }

        SingletonPartitionScheme IModelJsonSerializable<SingletonPartitionScheme>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SingletonPartitionScheme>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSingletonPartitionScheme(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SingletonPartitionScheme>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SingletonPartitionScheme>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SingletonPartitionScheme IModelSerializable<SingletonPartitionScheme>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SingletonPartitionScheme>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSingletonPartitionScheme(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SingletonPartitionScheme model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SingletonPartitionScheme(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSingletonPartitionScheme(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
