// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    public partial class ScVmmHardwareProfile : IUtf8JsonSerializable, IJsonModel<ScVmmHardwareProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScVmmHardwareProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScVmmHardwareProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmHardwareProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MemoryMB))
            {
                writer.WritePropertyName("memoryMB"u8);
                writer.WriteNumberValue(MemoryMB.Value);
            }
            if (Optional.IsDefined(CpuCount))
            {
                writer.WritePropertyName("cpuCount"u8);
                writer.WriteNumberValue(CpuCount.Value);
            }
            if (Optional.IsDefined(LimitCpuForMigration))
            {
                writer.WritePropertyName("limitCpuForMigration"u8);
                writer.WriteStringValue(LimitCpuForMigration.Value.ToString());
            }
            if (Optional.IsDefined(DynamicMemoryEnabled))
            {
                writer.WritePropertyName("dynamicMemoryEnabled"u8);
                writer.WriteStringValue(DynamicMemoryEnabled.Value.ToString());
            }
            if (Optional.IsDefined(DynamicMemoryMaxMB))
            {
                writer.WritePropertyName("dynamicMemoryMaxMB"u8);
                writer.WriteNumberValue(DynamicMemoryMaxMB.Value);
            }
            if (Optional.IsDefined(DynamicMemoryMinMB))
            {
                writer.WritePropertyName("dynamicMemoryMinMB"u8);
                writer.WriteNumberValue(DynamicMemoryMinMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHighlyAvailable))
            {
                writer.WritePropertyName("isHighlyAvailable"u8);
                writer.WriteStringValue(IsHighlyAvailable.Value.ToString());
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
        }

        ScVmmHardwareProfile IJsonModel<ScVmmHardwareProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScVmmHardwareProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScVmmHardwareProfile(document.RootElement, options);
        }

        internal static ScVmmHardwareProfile DeserializeScVmmHardwareProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? memoryMB = default;
            int? cpuCount = default;
            LimitCpuForMigration? limitCpuForMigration = default;
            DynamicMemoryEnabled? dynamicMemoryEnabled = default;
            int? dynamicMemoryMaxMB = default;
            int? dynamicMemoryMinMB = default;
            IsHighlyAvailable? isHighlyAvailable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitCpuForMigration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limitCpuForMigration = new LimitCpuForMigration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynamicMemoryEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryEnabled = new DynamicMemoryEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynamicMemoryMaxMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryMaxMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dynamicMemoryMinMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynamicMemoryMinMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isHighlyAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHighlyAvailable = new IsHighlyAvailable(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScVmmHardwareProfile(
                memoryMB,
                cpuCount,
                limitCpuForMigration,
                dynamicMemoryEnabled,
                dynamicMemoryMaxMB,
                dynamicMemoryMinMB,
                isHighlyAvailable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScVmmHardwareProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScVmmHardwareProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ScVmmHardwareProfile IPersistableModel<ScVmmHardwareProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScVmmHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScVmmHardwareProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScVmmHardwareProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScVmmHardwareProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
