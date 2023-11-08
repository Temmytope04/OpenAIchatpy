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
    public partial class CloudToDeviceMethodRequest : IUtf8JsonSerializable, IJsonModel<CloudToDeviceMethodRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudToDeviceMethodRequest>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<CloudToDeviceMethodRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MethodName))
            {
                writer.WritePropertyName("methodName"u8);
                writer.WriteStringValue(MethodName);
            }
            if (Optional.IsDefined(Payload))
            {
                writer.WritePropertyName("payload"u8);
                writer.WriteObjectValue(Payload);
            }
            if (Optional.IsDefined(ResponseTimeoutInSeconds))
            {
                writer.WritePropertyName("responseTimeoutInSeconds"u8);
                writer.WriteNumberValue(ResponseTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(ConnectTimeoutInSeconds))
            {
                writer.WritePropertyName("connectTimeoutInSeconds"u8);
                writer.WriteNumberValue(ConnectTimeoutInSeconds.Value);
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

        CloudToDeviceMethodRequest IJsonModel<CloudToDeviceMethodRequest>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudToDeviceMethodRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudToDeviceMethodRequest(document.RootElement, options);
        }

        internal static CloudToDeviceMethodRequest DeserializeCloudToDeviceMethodRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> methodName = default;
            Optional<object> payload = default;
            Optional<int> responseTimeoutInSeconds = default;
            Optional<int> connectTimeoutInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("payload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    payload = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("responseTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("connectTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudToDeviceMethodRequest(methodName.Value, payload.Value, Optional.ToNullable(responseTimeoutInSeconds), Optional.ToNullable(connectTimeoutInSeconds), serializedAdditionalRawData);
        }

        BinaryData IModel<CloudToDeviceMethodRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudToDeviceMethodRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CloudToDeviceMethodRequest IModel<CloudToDeviceMethodRequest>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudToDeviceMethodRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCloudToDeviceMethodRequest(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<CloudToDeviceMethodRequest>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
