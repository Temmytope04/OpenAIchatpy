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
    public partial class AS2EnvelopeSettings : IUtf8JsonSerializable, IJsonModel<AS2EnvelopeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2EnvelopeSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AS2EnvelopeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("messageContentType"u8);
            writer.WriteStringValue(MessageContentType.ToString());
            writer.WritePropertyName("transmitFileNameInMimeHeader"u8);
            writer.WriteBooleanValue(TransmitFileNameInMimeHeader);
            writer.WritePropertyName("fileNameTemplate"u8);
            writer.WriteStringValue(FileNameTemplate);
            writer.WritePropertyName("suspendMessageOnFileNameGenerationError"u8);
            writer.WriteBooleanValue(SuspendMessageOnFileNameGenerationError);
            writer.WritePropertyName("autogenerateFileName"u8);
            writer.WriteBooleanValue(AutoGenerateFileName);
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

        AS2EnvelopeSettings IJsonModel<AS2EnvelopeSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2EnvelopeSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2EnvelopeSettings(document.RootElement, options);
        }

        internal static AS2EnvelopeSettings DeserializeAS2EnvelopeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContentType messageContentType = default;
            bool transmitFileNameInMimeHeader = default;
            string fileNameTemplate = default;
            bool suspendMessageOnFileNameGenerationError = default;
            bool autogenerateFileName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageContentType"u8))
                {
                    messageContentType = new ContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transmitFileNameInMimeHeader"u8))
                {
                    transmitFileNameInMimeHeader = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fileNameTemplate"u8))
                {
                    fileNameTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suspendMessageOnFileNameGenerationError"u8))
                {
                    suspendMessageOnFileNameGenerationError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autogenerateFileName"u8))
                {
                    autogenerateFileName = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2EnvelopeSettings(messageContentType, transmitFileNameInMimeHeader, fileNameTemplate, suspendMessageOnFileNameGenerationError, autogenerateFileName, serializedAdditionalRawData);
        }

        BinaryData IModel<AS2EnvelopeSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2EnvelopeSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AS2EnvelopeSettings IModel<AS2EnvelopeSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2EnvelopeSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAS2EnvelopeSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AS2EnvelopeSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
