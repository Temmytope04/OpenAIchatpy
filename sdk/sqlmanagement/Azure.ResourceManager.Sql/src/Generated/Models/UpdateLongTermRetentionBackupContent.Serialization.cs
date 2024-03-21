// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class UpdateLongTermRetentionBackupContent : IUtf8JsonSerializable, IJsonModel<UpdateLongTermRetentionBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateLongTermRetentionBackupContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateLongTermRetentionBackupContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateLongTermRetentionBackupContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            writer.WriteEndObject();
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

        UpdateLongTermRetentionBackupContent IJsonModel<UpdateLongTermRetentionBackupContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateLongTermRetentionBackupContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateLongTermRetentionBackupContent(document.RootElement, options);
        }

        internal static UpdateLongTermRetentionBackupContent DeserializeUpdateLongTermRetentionBackupContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlBackupStorageRedundancy? requestedBackupStorageRedundancy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("requestedBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateLongTermRetentionBackupContent(requestedBackupStorageRedundancy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateLongTermRetentionBackupContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateLongTermRetentionBackupContent)} does not support '{options.Format}' format.");
            }
        }

        UpdateLongTermRetentionBackupContent IPersistableModel<UpdateLongTermRetentionBackupContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateLongTermRetentionBackupContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateLongTermRetentionBackupContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateLongTermRetentionBackupContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
