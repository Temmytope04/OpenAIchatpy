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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ScaleStreamingJobContent : IUtf8JsonSerializable, IModelJsonSerializable<ScaleStreamingJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScaleStreamingJobContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScaleStreamingJobContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleStreamingJobContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StreamingUnits))
            {
                writer.WritePropertyName("streamingUnits"u8);
                writer.WriteNumberValue(StreamingUnits.Value);
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

        internal static ScaleStreamingJobContent DeserializeScaleStreamingJobContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> streamingUnits = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamingUnits = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScaleStreamingJobContent(Optional.ToNullable(streamingUnits), rawData);
        }

        ScaleStreamingJobContent IModelJsonSerializable<ScaleStreamingJobContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleStreamingJobContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScaleStreamingJobContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScaleStreamingJobContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleStreamingJobContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScaleStreamingJobContent IModelSerializable<ScaleStreamingJobContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScaleStreamingJobContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScaleStreamingJobContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScaleStreamingJobContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScaleStreamingJobContent"/> to convert. </param>
        public static implicit operator RequestContent(ScaleStreamingJobContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScaleStreamingJobContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScaleStreamingJobContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScaleStreamingJobContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
