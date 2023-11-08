// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class PngImage : IUtf8JsonSerializable, IJsonModel<PngImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PngImage>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<PngImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start);
            if (Optional.IsDefined(Step))
            {
                writer.WritePropertyName("step"u8);
                writer.WriteStringValue(Step);
            }
            if (Optional.IsDefined(Range))
            {
                writer.WritePropertyName("range"u8);
                writer.WriteStringValue(Range);
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                writer.WritePropertyName("keyFrameInterval"u8);
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (Optional.IsDefined(StretchMode))
            {
                writer.WritePropertyName("stretchMode"u8);
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (Optional.IsDefined(SyncMode))
            {
                writer.WritePropertyName("syncMode"u8);
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
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

        PngImage IJsonModel<PngImage>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PngImage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePngImage(document.RootElement, options);
        }

        internal static PngImage DeserializePngImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PngLayer>> layers = default;
            string start = default;
            Optional<string> step = default;
            Optional<string> range = default;
            Optional<TimeSpan> keyFrameInterval = default;
            Optional<InputVideoStretchMode> stretchMode = default;
            Optional<VideoSyncMode> syncMode = default;
            string odataType = default;
            Optional<string> label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PngLayer> array = new List<PngLayer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PngLayer.DeserializePngLayer(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("step"u8))
                {
                    step = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("range"u8))
                {
                    range = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PngImage(odataType, label.Value, serializedAdditionalRawData, Optional.ToNullable(keyFrameInterval), Optional.ToNullable(stretchMode), Optional.ToNullable(syncMode), start, step.Value, range.Value, Optional.ToList(layers));
        }

        BinaryData IModel<PngImage>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PngImage)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PngImage IModel<PngImage>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PngImage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePngImage(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<PngImage>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
