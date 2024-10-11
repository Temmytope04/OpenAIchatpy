// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class TrafficRegionRolloutConfiguration : IUtf8JsonSerializable, IJsonModel<TrafficRegionRolloutConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficRegionRolloutConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrafficRegionRolloutConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficRegionRolloutConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(WaitDuration))
            {
                writer.WritePropertyName("waitDuration"u8);
                writer.WriteStringValue(WaitDuration.Value, "P");
            }
        }

        TrafficRegionRolloutConfiguration IJsonModel<TrafficRegionRolloutConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficRegionRolloutConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficRegionRolloutConfiguration(document.RootElement, options);
        }

        internal static TrafficRegionRolloutConfiguration DeserializeTrafficRegionRolloutConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? waitDuration = default;
            IList<AzureLocation> regions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("waitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    regions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrafficRegionRolloutConfiguration(regions ?? new ChangeTrackingList<AzureLocation>(), serializedAdditionalRawData, waitDuration);
        }

        BinaryData IPersistableModel<TrafficRegionRolloutConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficRegionRolloutConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        TrafficRegionRolloutConfiguration IPersistableModel<TrafficRegionRolloutConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficRegionRolloutConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficRegionRolloutConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficRegionRolloutConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficRegionRolloutConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
