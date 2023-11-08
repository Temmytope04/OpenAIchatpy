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
    [ModelReaderProxy(typeof(UnknownPreset))]
    public partial class MediaTransformPreset : IUtf8JsonSerializable, IJsonModel<MediaTransformPreset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaTransformPreset>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MediaTransformPreset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MediaTransformPreset IJsonModel<MediaTransformPreset>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaTransformPreset)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaTransformPreset(document.RootElement, options);
        }

        internal static MediaTransformPreset DeserializeMediaTransformPreset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioAnalyzerPreset": return AudioAnalyzerPreset.DeserializeAudioAnalyzerPreset(element);
                    case "#Microsoft.Media.BuiltInStandardEncoderPreset": return BuiltInStandardEncoderPreset.DeserializeBuiltInStandardEncoderPreset(element);
                    case "#Microsoft.Media.StandardEncoderPreset": return StandardEncoderPreset.DeserializeStandardEncoderPreset(element);
                    case "#Microsoft.Media.VideoAnalyzerPreset": return VideoAnalyzerPreset.DeserializeVideoAnalyzerPreset(element);
                }
            }
            return UnknownPreset.DeserializeUnknownPreset(element);
        }

        BinaryData IModel<MediaTransformPreset>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaTransformPreset)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MediaTransformPreset IModel<MediaTransformPreset>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaTransformPreset)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMediaTransformPreset(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MediaTransformPreset>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
