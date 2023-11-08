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
    public partial class SelectAudioTrackByAttribute : IUtf8JsonSerializable, IJsonModel<SelectAudioTrackByAttribute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelectAudioTrackByAttribute>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SelectAudioTrackByAttribute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("attribute"u8);
            writer.WriteStringValue(Attribute.ToString());
            writer.WritePropertyName("filter"u8);
            writer.WriteStringValue(Filter.ToString());
            if (Optional.IsDefined(FilterValue))
            {
                writer.WritePropertyName("filterValue"u8);
                writer.WriteStringValue(FilterValue);
            }
            if (Optional.IsDefined(ChannelMapping))
            {
                writer.WritePropertyName("channelMapping"u8);
                writer.WriteStringValue(ChannelMapping.Value.ToString());
            }
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

        SelectAudioTrackByAttribute IJsonModel<SelectAudioTrackByAttribute>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelectAudioTrackByAttribute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelectAudioTrackByAttribute(document.RootElement, options);
        }

        internal static SelectAudioTrackByAttribute DeserializeSelectAudioTrackByAttribute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrackAttribute attribute = default;
            TrackAttributeFilter filter = default;
            Optional<string> filterValue = default;
            Optional<ChannelMapping> channelMapping = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attribute"u8))
                {
                    attribute = new TrackAttribute(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = new TrackAttributeFilter(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filterValue"u8))
                {
                    filterValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channelMapping = new ChannelMapping(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelectAudioTrackByAttribute(odataType, serializedAdditionalRawData, Optional.ToNullable(channelMapping), attribute, filter, filterValue.Value);
        }

        BinaryData IModel<SelectAudioTrackByAttribute>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelectAudioTrackByAttribute)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SelectAudioTrackByAttribute IModel<SelectAudioTrackByAttribute>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelectAudioTrackByAttribute)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSelectAudioTrackByAttribute(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SelectAudioTrackByAttribute>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
