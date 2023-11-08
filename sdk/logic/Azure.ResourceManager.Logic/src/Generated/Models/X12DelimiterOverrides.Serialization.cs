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
    public partial class X12DelimiterOverrides : IUtf8JsonSerializable, IJsonModel<X12DelimiterOverrides>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12DelimiterOverrides>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<X12DelimiterOverrides>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolVersion))
            {
                writer.WritePropertyName("protocolVersion"u8);
                writer.WriteStringValue(ProtocolVersion);
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            writer.WritePropertyName("dataElementSeparator"u8);
            writer.WriteNumberValue(DataElementSeparator);
            writer.WritePropertyName("componentSeparator"u8);
            writer.WriteNumberValue(ComponentSeparator);
            writer.WritePropertyName("segmentTerminator"u8);
            writer.WriteNumberValue(SegmentTerminator);
            writer.WritePropertyName("segmentTerminatorSuffix"u8);
            writer.WriteStringValue(SegmentTerminatorSuffix.ToSerialString());
            writer.WritePropertyName("replaceCharacter"u8);
            writer.WriteNumberValue(ReplaceCharacter);
            writer.WritePropertyName("replaceSeparatorsInPayload"u8);
            writer.WriteBooleanValue(ReplaceSeparatorsInPayload);
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace"u8);
                writer.WriteStringValue(TargetNamespace);
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

        X12DelimiterOverrides IJsonModel<X12DelimiterOverrides>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12DelimiterOverrides(document.RootElement, options);
        }

        internal static X12DelimiterOverrides DeserializeX12DelimiterOverrides(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protocolVersion = default;
            Optional<string> messageId = default;
            int dataElementSeparator = default;
            int componentSeparator = default;
            int segmentTerminator = default;
            SegmentTerminatorSuffix segmentTerminatorSuffix = default;
            int replaceCharacter = default;
            bool replaceSeparatorsInPayload = default;
            Optional<string> targetNamespace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolVersion"u8))
                {
                    protocolVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
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
                if (property.NameEquals("segmentTerminatorSuffix"u8))
                {
                    segmentTerminatorSuffix = property.Value.GetString().ToSegmentTerminatorSuffix();
                    continue;
                }
                if (property.NameEquals("replaceCharacter"u8))
                {
                    replaceCharacter = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replaceSeparatorsInPayload"u8))
                {
                    replaceSeparatorsInPayload = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetNamespace"u8))
                {
                    targetNamespace = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new X12DelimiterOverrides(protocolVersion.Value, messageId.Value, dataElementSeparator, componentSeparator, segmentTerminator, segmentTerminatorSuffix, replaceCharacter, replaceSeparatorsInPayload, targetNamespace.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<X12DelimiterOverrides>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        X12DelimiterOverrides IModel<X12DelimiterOverrides>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeX12DelimiterOverrides(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<X12DelimiterOverrides>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
