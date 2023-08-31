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

namespace Azure.Communication.CallAutomation
{
    internal partial class MediaStreamingOptionsInternal : IUtf8JsonSerializable, IModelJsonSerializable<MediaStreamingOptionsInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaStreamingOptionsInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaStreamingOptionsInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("transportUrl"u8);
            writer.WriteStringValue(TransportUrl);
            writer.WritePropertyName("transportType"u8);
            writer.WriteStringValue(TransportType.ToString());
            writer.WritePropertyName("contentType"u8);
            writer.WriteStringValue(ContentType.ToString());
            writer.WritePropertyName("audioChannelType"u8);
            writer.WriteStringValue(AudioChannelType.ToString());
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

        internal static MediaStreamingOptionsInternal DeserializeMediaStreamingOptionsInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string transportUrl = default;
            MediaStreamingTransport transportType = default;
            MediaStreamingContent contentType = default;
            MediaStreamingAudioChannel audioChannelType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportUrl"u8))
                {
                    transportUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transportType"u8))
                {
                    transportType = new MediaStreamingTransport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = new MediaStreamingContent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("audioChannelType"u8))
                {
                    audioChannelType = new MediaStreamingAudioChannel(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaStreamingOptionsInternal(transportUrl, transportType, contentType, audioChannelType, rawData);
        }

        MediaStreamingOptionsInternal IModelJsonSerializable<MediaStreamingOptionsInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaStreamingOptionsInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaStreamingOptionsInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaStreamingOptionsInternal IModelSerializable<MediaStreamingOptionsInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaStreamingOptionsInternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaStreamingOptionsInternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaStreamingOptionsInternal"/> to convert. </param>
        public static implicit operator RequestContent(MediaStreamingOptionsInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaStreamingOptionsInternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaStreamingOptionsInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaStreamingOptionsInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
