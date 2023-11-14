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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactFramingSettings : IUtf8JsonSerializable, IJsonModel<EdifactFramingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactFramingSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<EdifactFramingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EdifactFramingSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EdifactFramingSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceCodeListDirectoryVersion))
            {
                writer.WritePropertyName("serviceCodeListDirectoryVersion"u8);
                writer.WriteStringValue(ServiceCodeListDirectoryVersion);
            }
            if (Optional.IsDefined(CharacterEncoding))
            {
                writer.WritePropertyName("characterEncoding"u8);
                writer.WriteStringValue(CharacterEncoding);
            }
            writer.WritePropertyName("protocolVersion"u8);
            writer.WriteNumberValue(ProtocolVersion);
            writer.WritePropertyName("dataElementSeparator"u8);
            writer.WriteNumberValue(DataElementSeparator);
            writer.WritePropertyName("componentSeparator"u8);
            writer.WriteNumberValue(ComponentSeparator);
            writer.WritePropertyName("segmentTerminator"u8);
            writer.WriteNumberValue(SegmentTerminator);
            writer.WritePropertyName("releaseIndicator"u8);
            writer.WriteNumberValue(ReleaseIndicator);
            writer.WritePropertyName("repetitionSeparator"u8);
            writer.WriteNumberValue(RepetitionSeparator);
            writer.WritePropertyName("characterSet"u8);
            writer.WriteStringValue(CharacterSet.ToString());
            writer.WritePropertyName("decimalPointIndicator"u8);
            writer.WriteStringValue(DecimalPointIndicator.ToSerialString());
            writer.WritePropertyName("segmentTerminatorSuffix"u8);
            writer.WriteStringValue(SegmentTerminatorSuffix.ToSerialString());
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

        EdifactFramingSettings IJsonModel<EdifactFramingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdifactFramingSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactFramingSettings(document.RootElement, options);
        }

        internal static EdifactFramingSettings DeserializeEdifactFramingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceCodeListDirectoryVersion = default;
            Optional<string> characterEncoding = default;
            int protocolVersion = default;
            int dataElementSeparator = default;
            int componentSeparator = default;
            int segmentTerminator = default;
            int releaseIndicator = default;
            int repetitionSeparator = default;
            EdifactCharacterSet characterSet = default;
            EdifactDecimalIndicator decimalPointIndicator = default;
            SegmentTerminatorSuffix segmentTerminatorSuffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceCodeListDirectoryVersion"u8))
                {
                    serviceCodeListDirectoryVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("characterEncoding"u8))
                {
                    characterEncoding = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocolVersion"u8))
                {
                    protocolVersion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataElementSeparator"u8))
                {
                    dataElementSeparator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("componentSeparator"u8))
                {
                    componentSeparator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("segmentTerminator"u8))
                {
                    segmentTerminator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("releaseIndicator"u8))
                {
                    releaseIndicator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("repetitionSeparator"u8))
                {
                    repetitionSeparator = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("characterSet"u8))
                {
                    characterSet = new EdifactCharacterSet(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("decimalPointIndicator"u8))
                {
                    decimalPointIndicator = property.Value.GetString().ToEdifactDecimalIndicator();
                    continue;
                }
                if (property.NameEquals("segmentTerminatorSuffix"u8))
                {
                    segmentTerminatorSuffix = property.Value.GetString().ToSegmentTerminatorSuffix();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdifactFramingSettings(serviceCodeListDirectoryVersion.Value, characterEncoding.Value, protocolVersion, dataElementSeparator, componentSeparator, segmentTerminator, releaseIndicator, repetitionSeparator, characterSet, decimalPointIndicator, segmentTerminatorSuffix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactFramingSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdifactFramingSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EdifactFramingSettings IPersistableModel<EdifactFramingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EdifactFramingSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEdifactFramingSettings(document.RootElement, options);
        }

        string IPersistableModel<EdifactFramingSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
