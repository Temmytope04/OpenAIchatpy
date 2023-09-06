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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class BigDataPoolAutoScaleProperties : IUtf8JsonSerializable, IModelJsonSerializable<BigDataPoolAutoScaleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BigDataPoolAutoScaleProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BigDataPoolAutoScaleProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoScaleProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MinNodeCount))
            {
                writer.WritePropertyName("minNodeCount"u8);
                writer.WriteNumberValue(MinNodeCount.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(MaxNodeCount))
            {
                writer.WritePropertyName("maxNodeCount"u8);
                writer.WriteNumberValue(MaxNodeCount.Value);
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

        internal static BigDataPoolAutoScaleProperties DeserializeBigDataPoolAutoScaleProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minNodeCount = default;
            Optional<bool> enabled = default;
            Optional<int> maxNodeCount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BigDataPoolAutoScaleProperties(Optional.ToNullable(minNodeCount), Optional.ToNullable(enabled), Optional.ToNullable(maxNodeCount), rawData);
        }

        BigDataPoolAutoScaleProperties IModelJsonSerializable<BigDataPoolAutoScaleProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoScaleProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBigDataPoolAutoScaleProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BigDataPoolAutoScaleProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoScaleProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BigDataPoolAutoScaleProperties IModelSerializable<BigDataPoolAutoScaleProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoScaleProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBigDataPoolAutoScaleProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BigDataPoolAutoScaleProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BigDataPoolAutoScaleProperties"/> to convert. </param>
        public static implicit operator RequestContent(BigDataPoolAutoScaleProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BigDataPoolAutoScaleProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BigDataPoolAutoScaleProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBigDataPoolAutoScaleProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
