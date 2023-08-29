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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ImageFormatBmp : IUtf8JsonSerializable, IModelJsonSerializable<ImageFormatBmp>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ImageFormatBmp>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ImageFormatBmp>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ImageFormatBmp>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
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

        internal static ImageFormatBmp DeserializeImageFormatBmp(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ImageFormatBmp(type, rawData);
        }

        ImageFormatBmp IModelJsonSerializable<ImageFormatBmp>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ImageFormatBmp>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeImageFormatBmp(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ImageFormatBmp>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ImageFormatBmp>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ImageFormatBmp IModelSerializable<ImageFormatBmp>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ImageFormatBmp>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeImageFormatBmp(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ImageFormatBmp model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ImageFormatBmp(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeImageFormatBmp(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
