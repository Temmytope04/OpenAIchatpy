// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class AdhocBasedBackupTaggingCriteria : IUtf8JsonSerializable, IJsonModel<AdhocBasedBackupTaggingCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBasedBackupTaggingCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdhocBasedBackupTaggingCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBasedBackupTaggingCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TagInfo != null)
            {
                writer.WritePropertyName("tagInfo"u8);
                writer.WriteObjectValue(TagInfo);
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

        AdhocBasedBackupTaggingCriteria IJsonModel<AdhocBasedBackupTaggingCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBasedBackupTaggingCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBasedBackupTaggingCriteria(document.RootElement, options);
        }

        internal static AdhocBasedBackupTaggingCriteria DeserializeAdhocBasedBackupTaggingCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupRetentionTag tagInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tagInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagInfo = DataProtectionBackupRetentionTag.DeserializeDataProtectionBackupRetentionTag(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdhocBasedBackupTaggingCriteria(tagInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdhocBasedBackupTaggingCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBasedBackupTaggingCriteria)} does not support '{options.Format}' format.");
            }
        }

        AdhocBasedBackupTaggingCriteria IPersistableModel<AdhocBasedBackupTaggingCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBasedBackupTaggingCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdhocBasedBackupTaggingCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBasedBackupTaggingCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBasedBackupTaggingCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
