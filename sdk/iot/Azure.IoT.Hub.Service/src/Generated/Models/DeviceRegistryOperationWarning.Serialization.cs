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
    public partial class DeviceRegistryOperationWarning : IUtf8JsonSerializable, IJsonModel<DeviceRegistryOperationWarning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceRegistryOperationWarning>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DeviceRegistryOperationWarning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DeviceRegistryOperationWarning>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DeviceRegistryOperationWarning>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(WarningCode))
            {
                writer.WritePropertyName("warningCode"u8);
                writer.WriteStringValue(WarningCode.Value.ToString());
            }
            if (Optional.IsDefined(WarningStatus))
            {
                writer.WritePropertyName("warningStatus"u8);
                writer.WriteStringValue(WarningStatus);
            }
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

        DeviceRegistryOperationWarning IJsonModel<DeviceRegistryOperationWarning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeviceRegistryOperationWarning)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceRegistryOperationWarning(document.RootElement, options);
        }

        internal static DeviceRegistryOperationWarning DeserializeDeviceRegistryOperationWarning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<DeviceRegistryOperationWarningCode> warningCode = default;
            Optional<string> warningStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCode = new DeviceRegistryOperationWarningCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("warningStatus"u8))
                {
                    warningStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceRegistryOperationWarning(deviceId.Value, Optional.ToNullable(warningCode), warningStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceRegistryOperationWarning>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeviceRegistryOperationWarning)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DeviceRegistryOperationWarning IPersistableModel<DeviceRegistryOperationWarning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DeviceRegistryOperationWarning)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDeviceRegistryOperationWarning(document.RootElement, options);
        }

        string IPersistableModel<DeviceRegistryOperationWarning>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
