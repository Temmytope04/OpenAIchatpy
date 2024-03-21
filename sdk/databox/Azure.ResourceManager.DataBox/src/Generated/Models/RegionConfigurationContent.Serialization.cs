// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class RegionConfigurationContent : IUtf8JsonSerializable, IJsonModel<RegionConfigurationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegionConfigurationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegionConfigurationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionConfigurationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleAvailabilityRequest))
            {
                writer.WritePropertyName("scheduleAvailabilityRequest"u8);
                writer.WriteObjectValue(ScheduleAvailabilityRequest);
            }
            if (Optional.IsDefined(TransportAvailabilityRequest))
            {
                writer.WritePropertyName("transportAvailabilityRequest"u8);
                writer.WriteObjectValue(TransportAvailabilityRequest);
            }
            if (Optional.IsDefined(DataCenterAddressRequest))
            {
                writer.WritePropertyName("datacenterAddressRequest"u8);
                writer.WriteObjectValue(DataCenterAddressRequest);
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

        RegionConfigurationContent IJsonModel<RegionConfigurationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegionConfigurationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegionConfigurationContent(document.RootElement, options);
        }

        internal static RegionConfigurationContent DeserializeRegionConfigurationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScheduleAvailabilityContent scheduleAvailabilityRequest = default;
            TransportAvailabilityRequest transportAvailabilityRequest = default;
            DataCenterAddressContent dataCenterAddressRequest = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleAvailabilityRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleAvailabilityRequest = ScheduleAvailabilityContent.DeserializeScheduleAvailabilityContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("transportAvailabilityRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportAvailabilityRequest = TransportAvailabilityRequest.DeserializeTransportAvailabilityRequest(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datacenterAddressRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAddressRequest = DataCenterAddressContent.DeserializeDataCenterAddressContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegionConfigurationContent(scheduleAvailabilityRequest, transportAvailabilityRequest, dataCenterAddressRequest, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegionConfigurationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegionConfigurationContent)} does not support '{options.Format}' format.");
            }
        }

        RegionConfigurationContent IPersistableModel<RegionConfigurationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegionConfigurationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegionConfigurationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegionConfigurationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegionConfigurationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
