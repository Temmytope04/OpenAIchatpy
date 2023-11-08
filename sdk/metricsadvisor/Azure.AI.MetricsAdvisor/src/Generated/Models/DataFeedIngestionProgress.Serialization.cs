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

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataFeedIngestionProgress : IUtf8JsonSerializable, IJsonModel<DataFeedIngestionProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFeedIngestionProgress>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataFeedIngestionProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LatestSuccessTimestamp))
                {
                    if (LatestSuccessTimestamp != null)
                    {
                        writer.WritePropertyName("latestSuccessTimestamp"u8);
                        writer.WriteStringValue(LatestSuccessTimestamp.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("latestSuccessTimestamp");
                    }
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LatestActiveTimestamp))
                {
                    if (LatestActiveTimestamp != null)
                    {
                        writer.WritePropertyName("latestActiveTimestamp"u8);
                        writer.WriteStringValue(LatestActiveTimestamp.Value, "O");
                    }
                    else
                    {
                        writer.WriteNull("latestActiveTimestamp");
                    }
                }
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

        DataFeedIngestionProgress IJsonModel<DataFeedIngestionProgress>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedIngestionProgress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFeedIngestionProgress(document.RootElement, options);
        }

        internal static DataFeedIngestionProgress DeserializeDataFeedIngestionProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> latestSuccessTimestamp = default;
            Optional<DateTimeOffset?> latestActiveTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestSuccessTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latestSuccessTimestamp = null;
                        continue;
                    }
                    latestSuccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("latestActiveTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latestActiveTimestamp = null;
                        continue;
                    }
                    latestActiveTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFeedIngestionProgress(Optional.ToNullable(latestSuccessTimestamp), Optional.ToNullable(latestActiveTimestamp), serializedAdditionalRawData);
        }

        BinaryData IModel<DataFeedIngestionProgress>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedIngestionProgress)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataFeedIngestionProgress IModel<DataFeedIngestionProgress>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFeedIngestionProgress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataFeedIngestionProgress(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataFeedIngestionProgress>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
