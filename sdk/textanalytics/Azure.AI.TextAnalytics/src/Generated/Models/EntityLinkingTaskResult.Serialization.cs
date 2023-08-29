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

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class EntityLinkingTaskResult : IUtf8JsonSerializable, IModelJsonSerializable<EntityLinkingTaskResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EntityLinkingTaskResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EntityLinkingTaskResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingTaskResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static EntityLinkingTaskResult DeserializeEntityLinkingTaskResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityLinkingResult results = default;
            AnalyzeTextTaskResultsKind kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = EntityLinkingResult.DeserializeEntityLinkingResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EntityLinkingTaskResult(kind, results, rawData);
        }

        EntityLinkingTaskResult IModelJsonSerializable<EntityLinkingTaskResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingTaskResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityLinkingTaskResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EntityLinkingTaskResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingTaskResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EntityLinkingTaskResult IModelSerializable<EntityLinkingTaskResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingTaskResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEntityLinkingTaskResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EntityLinkingTaskResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EntityLinkingTaskResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEntityLinkingTaskResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
