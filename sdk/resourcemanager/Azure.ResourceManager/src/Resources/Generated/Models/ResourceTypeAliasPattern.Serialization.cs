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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAliasPattern : IUtf8JsonSerializable, IModelJsonSerializable<ResourceTypeAliasPattern>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceTypeAliasPattern>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceTypeAliasPattern>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Phrase))
            {
                writer.WritePropertyName("phrase"u8);
                writer.WriteStringValue(Phrase);
            }
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
            }
            if (Optional.IsDefined(PatternType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PatternType.Value.ToSerialString());
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

        internal static ResourceTypeAliasPattern DeserializeResourceTypeAliasPattern(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> phrase = default;
            Optional<string> variable = default;
            Optional<ResourceTypeAliasPatternType> type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phrase"u8))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasPatternType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceTypeAliasPattern(phrase.Value, variable.Value, Optional.ToNullable(type), rawData);
        }

        ResourceTypeAliasPattern IModelJsonSerializable<ResourceTypeAliasPattern>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPattern(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceTypeAliasPattern>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceTypeAliasPattern IModelSerializable<ResourceTypeAliasPattern>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPattern(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ResourceTypeAliasPattern model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ResourceTypeAliasPattern(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceTypeAliasPattern(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
