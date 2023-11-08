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

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DevicesStatistics : IUtf8JsonSerializable, IJsonModel<DevicesStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevicesStatistics>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DevicesStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TotalDeviceCount))
            {
                writer.WritePropertyName("totalDeviceCount"u8);
                writer.WriteNumberValue(TotalDeviceCount.Value);
            }
            if (Optional.IsDefined(EnabledDeviceCount))
            {
                writer.WritePropertyName("enabledDeviceCount"u8);
                writer.WriteNumberValue(EnabledDeviceCount.Value);
            }
            if (Optional.IsDefined(DisabledDeviceCount))
            {
                writer.WritePropertyName("disabledDeviceCount"u8);
                writer.WriteNumberValue(DisabledDeviceCount.Value);
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

        DevicesStatistics IJsonModel<DevicesStatistics>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevicesStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevicesStatistics(document.RootElement, options);
        }

        internal static DevicesStatistics DeserializeDevicesStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalDeviceCount = default;
            Optional<long> enabledDeviceCount = default;
            Optional<long> disabledDeviceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevicesStatistics(Optional.ToNullable(totalDeviceCount), Optional.ToNullable(enabledDeviceCount), Optional.ToNullable(disabledDeviceCount), serializedAdditionalRawData);
        }

        BinaryData IModel<DevicesStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevicesStatistics)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DevicesStatistics IModel<DevicesStatistics>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevicesStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDevicesStatistics(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DevicesStatistics>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
