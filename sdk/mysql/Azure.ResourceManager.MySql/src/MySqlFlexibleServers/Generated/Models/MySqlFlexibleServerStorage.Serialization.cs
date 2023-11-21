// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerStorage : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerStorage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerStorage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerStorage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerStorage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerStorage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeGB"u8);
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Iops))
            {
                writer.WritePropertyName("iops"u8);
                writer.WriteNumberValue(Iops.Value);
            }
            if (Optional.IsDefined(AutoGrow))
            {
                writer.WritePropertyName("autoGrow"u8);
                writer.WriteStringValue(AutoGrow.Value.ToString());
            }
            if (Optional.IsDefined(LogOnDisk))
            {
                writer.WritePropertyName("logOnDisk"u8);
                writer.WriteStringValue(LogOnDisk.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StorageSku))
            {
                writer.WritePropertyName("storageSku"u8);
                writer.WriteStringValue(StorageSku);
            }
            if (Optional.IsDefined(AutoIoScaling))
            {
                writer.WritePropertyName("autoIoScaling"u8);
                writer.WriteStringValue(AutoIoScaling.Value.ToString());
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

        MySqlFlexibleServerStorage IJsonModel<MySqlFlexibleServerStorage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerStorage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerStorage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerStorage(document.RootElement, options);
        }

        internal static MySqlFlexibleServerStorage DeserializeMySqlFlexibleServerStorage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> storageSizeGB = default;
            Optional<int> iops = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> autoGrow = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> logOnDisk = default;
            Optional<string> storageSku = default;
            Optional<MySqlFlexibleServerEnableStatusEnum> autoIoScaling = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("iops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iops = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoGrow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoGrow = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logOnDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logOnDisk = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageSku"u8))
                {
                    storageSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoIoScaling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoIoScaling = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerStorage(Optional.ToNullable(storageSizeGB), Optional.ToNullable(iops), Optional.ToNullable(autoGrow), Optional.ToNullable(logOnDisk), storageSku.Value, Optional.ToNullable(autoIoScaling), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerStorage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerStorage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerStorage)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerStorage IPersistableModel<MySqlFlexibleServerStorage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerStorage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerStorage(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerStorage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerStorage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
