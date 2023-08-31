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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ResourceHealthSummary : IUtf8JsonSerializable, IModelJsonSerializable<ResourceHealthSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceHealthSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceHealthSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceCount))
            {
                writer.WritePropertyName("resourceCount"u8);
                writer.WriteNumberValue(ResourceCount.Value);
            }
            if (Optional.IsCollectionDefined(Issues))
            {
                writer.WritePropertyName("issues"u8);
                writer.WriteStartArray();
                foreach (var item in Issues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CategorizedResourceCounts))
            {
                writer.WritePropertyName("categorizedResourceCounts"u8);
                writer.WriteStartObject();
                foreach (var item in CategorizedResourceCounts)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static ResourceHealthSummary DeserializeResourceHealthSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> resourceCount = default;
            Optional<IReadOnlyList<HealthErrorSummary>> issues = default;
            Optional<IReadOnlyDictionary<string, int>> categorizedResourceCounts = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("issues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthErrorSummary> array = new List<HealthErrorSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthErrorSummary.DeserializeHealthErrorSummary(item));
                    }
                    issues = array;
                    continue;
                }
                if (property.NameEquals("categorizedResourceCounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    categorizedResourceCounts = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceHealthSummary(Optional.ToNullable(resourceCount), Optional.ToList(issues), Optional.ToDictionary(categorizedResourceCounts), rawData);
        }

        ResourceHealthSummary IModelJsonSerializable<ResourceHealthSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceHealthSummary>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceHealthSummary IModelSerializable<ResourceHealthSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceHealthSummary(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ResourceHealthSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ResourceHealthSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceHealthSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
