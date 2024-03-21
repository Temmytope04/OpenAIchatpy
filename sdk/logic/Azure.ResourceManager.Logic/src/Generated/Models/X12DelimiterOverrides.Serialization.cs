// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12DelimiterOverrides : IUtf8JsonSerializable, IJsonModel<X12DelimiterOverrides>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12DelimiterOverrides>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<X12DelimiterOverrides>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12DelimiterOverrides>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{format}' format.");
            }

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
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        X12DelimiterOverrides IJsonModel<X12DelimiterOverrides>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12DelimiterOverrides>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12DelimiterOverrides(document.RootElement, options);
        }

        internal static X12DelimiterOverrides DeserializeX12DelimiterOverrides(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string protocolVersion = default;
            string messageId = default;
            int dataElementSeparator = default;
            int componentSeparator = default;
            int segmentTerminator = default;
            SegmentTerminatorSuffix segmentTerminatorSuffix = default;
            int replaceCharacter = default;
            bool replaceSeparatorsInPayload = default;
            string targetNamespace = default;
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new X12DelimiterOverrides(
                protocolVersion,
                messageId,
                dataElementSeparator,
                componentSeparator,
                segmentTerminator,
                segmentTerminatorSuffix,
                replaceCharacter,
                replaceSeparatorsInPayload,
                targetNamespace,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12DelimiterOverrides>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12DelimiterOverrides>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{options.Format}' format.");
            }
        }

        X12DelimiterOverrides IPersistableModel<X12DelimiterOverrides>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12DelimiterOverrides>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12DelimiterOverrides(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12DelimiterOverrides)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12DelimiterOverrides>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
