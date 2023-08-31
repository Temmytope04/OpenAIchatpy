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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSecuritySolutionPatch : IUtf8JsonSerializable, IModelJsonSerializable<IotSecuritySolutionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecuritySolutionPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecuritySolutionPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotSecuritySolutionPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UserDefinedResources))
            {
                writer.WritePropertyName("userDefinedResources"u8);
                writer.WriteObjectValue(UserDefinedResources);
            }
            if (Optional.IsCollectionDefined(RecommendationsConfiguration))
            {
                writer.WritePropertyName("recommendationsConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendationsConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static IotSecuritySolutionPatch DeserializeIotSecuritySolutionPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<UserDefinedResourcesProperties> userDefinedResources = default;
            Optional<IList<RecommendationConfigurationProperties>> recommendationsConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("userDefinedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userDefinedResources = UserDefinedResourcesProperties.DeserializeUserDefinedResourcesProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recommendationsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendationConfigurationProperties> array = new List<RecommendationConfigurationProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendationConfigurationProperties.DeserializeRecommendationConfigurationProperties(item));
                            }
                            recommendationsConfiguration = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotSecuritySolutionPatch(Optional.ToDictionary(tags), userDefinedResources.Value, Optional.ToList(recommendationsConfiguration), rawData);
        }

        IotSecuritySolutionPatch IModelJsonSerializable<IotSecuritySolutionPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotSecuritySolutionPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecuritySolutionPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecuritySolutionPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotSecuritySolutionPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecuritySolutionPatch IModelSerializable<IotSecuritySolutionPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotSecuritySolutionPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecuritySolutionPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IotSecuritySolutionPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IotSecuritySolutionPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecuritySolutionPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
