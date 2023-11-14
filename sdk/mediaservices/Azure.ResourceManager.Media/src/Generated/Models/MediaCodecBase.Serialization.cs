// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    [PersistableModelProxy(typeof(UnknownCodec))]
    public partial class MediaCodecBase : IUtf8JsonSerializable, IJsonModel<MediaCodecBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaCodecBase>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MediaCodecBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MediaCodecBase>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MediaCodecBase>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaCodecBase IJsonModel<MediaCodecBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaCodecBase(document.RootElement, options);
        }

        internal static MediaCodecBase DeserializeMediaCodecBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AacAudio": return AacAudio.DeserializeAacAudio(element);
                    case "#Microsoft.Media.Audio": return MediaAudioBase.DeserializeMediaAudioBase(element);
                    case "#Microsoft.Media.CopyAudio": return CodecCopyAudio.DeserializeCodecCopyAudio(element);
                    case "#Microsoft.Media.CopyVideo": return CodecCopyVideo.DeserializeCodecCopyVideo(element);
                    case "#Microsoft.Media.DDAudio": return DDAudio.DeserializeDDAudio(element);
                    case "#Microsoft.Media.H264Video": return H264Video.DeserializeH264Video(element);
                    case "#Microsoft.Media.H265Video": return H265Video.DeserializeH265Video(element);
                    case "#Microsoft.Media.Image": return MediaImageBase.DeserializeMediaImageBase(element);
                    case "#Microsoft.Media.JpgImage": return JpgImage.DeserializeJpgImage(element);
                    case "#Microsoft.Media.PngImage": return PngImage.DeserializePngImage(element);
                    case "#Microsoft.Media.Video": return MediaVideoBase.DeserializeMediaVideoBase(element);
                }
            }
            return UnknownCodec.DeserializeUnknownCodec(element);
        }

        BinaryData IPersistableModel<MediaCodecBase>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MediaCodecBase IPersistableModel<MediaCodecBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaCodecBase)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMediaCodecBase(document.RootElement, options);
        }

        string IPersistableModel<MediaCodecBase>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
