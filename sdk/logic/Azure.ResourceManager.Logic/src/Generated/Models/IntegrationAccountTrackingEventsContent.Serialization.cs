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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountTrackingEventsContent : IUtf8JsonSerializable, IJsonModel<IntegrationAccountTrackingEventsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountTrackingEventsContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<IntegrationAccountTrackingEventsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType);
            if (Optional.IsDefined(TrackEventsOptions))
            {
                writer.WritePropertyName("trackEventsOptions"u8);
                writer.WriteStringValue(TrackEventsOptions.Value.ToString());
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        IntegrationAccountTrackingEventsContent IJsonModel<IntegrationAccountTrackingEventsContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountTrackingEventsContent(document.RootElement, options);
        }

        internal static IntegrationAccountTrackingEventsContent DeserializeIntegrationAccountTrackingEventsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceType = default;
            Optional<IntegrationAccountTrackEventOperationOption> trackEventsOptions = default;
            IList<IntegrationAccountTrackingEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackEventsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackEventsOptions = new IntegrationAccountTrackEventOperationOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    List<IntegrationAccountTrackingEvent> array = new List<IntegrationAccountTrackingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountTrackingEvent.DeserializeIntegrationAccountTrackingEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationAccountTrackingEventsContent(sourceType, Optional.ToNullable(trackEventsOptions), events, serializedAdditionalRawData);
        }

        BinaryData IModel<IntegrationAccountTrackingEventsContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IntegrationAccountTrackingEventsContent IModel<IntegrationAccountTrackingEventsContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIntegrationAccountTrackingEventsContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<IntegrationAccountTrackingEventsContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
