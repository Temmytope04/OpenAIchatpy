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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DataCollectionConfiguration : IUtf8JsonSerializable, IJsonModel<DataCollectionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataCollectionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(DataCollectionMode))
            {
                writer.WritePropertyName("dataCollectionMode"u8);
                writer.WriteStringValue(DataCollectionMode.Value.ToString());
            }
            if (Optional.IsDefined(DataId))
            {
                if (DataId != null)
                {
                    writer.WritePropertyName("dataId"u8);
                    writer.WriteStringValue(DataId);
                }
                else
                {
                    writer.WriteNull("dataId");
                }
            }
            if (Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate"u8);
                writer.WriteNumberValue(SamplingRate.Value);
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

        DataCollectionConfiguration IJsonModel<DataCollectionConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionConfiguration(document.RootElement, options);
        }

        internal static DataCollectionConfiguration DeserializeDataCollectionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<DataCollectionMode> dataCollectionMode = default;
            Optional<string> dataId = default;
            Optional<double> samplingRate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataCollectionMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCollectionMode = new DataCollectionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataId = null;
                        continue;
                    }
                    dataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingRate = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionConfiguration(clientId.Value, Optional.ToNullable(dataCollectionMode), dataId.Value, Optional.ToNullable(samplingRate), serializedAdditionalRawData);
        }

        BinaryData IModel<DataCollectionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataCollectionConfiguration IModel<DataCollectionConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataCollectionConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataCollectionConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataCollectionConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
