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

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReportItem : IUtf8JsonSerializable, IJsonModel<AzureReachabilityReportItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureReachabilityReportItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureReachabilityReportItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(AzureLocation))
            {
                writer.WritePropertyName("azureLocation"u8);
                writer.WriteStringValue(AzureLocation.Value);
            }
            if (Optional.IsCollectionDefined(Latencies))
            {
                writer.WritePropertyName("latencies"u8);
                writer.WriteStartArray();
                foreach (var item in Latencies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AzureReachabilityReportItem IJsonModel<AzureReachabilityReportItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureReachabilityReportItem(document.RootElement, options);
        }

        internal static AzureReachabilityReportItem DeserializeAzureReachabilityReportItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provider = default;
            Optional<AzureLocation> azureLocation = default;
            Optional<IReadOnlyList<AzureReachabilityReportLatencyInfo>> latencies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("latencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureReachabilityReportLatencyInfo> array = new List<AzureReachabilityReportLatencyInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureReachabilityReportLatencyInfo.DeserializeAzureReachabilityReportLatencyInfo(item));
                    }
                    latencies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureReachabilityReportItem(provider.Value, Optional.ToNullable(azureLocation), Optional.ToList(latencies), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureReachabilityReportItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportItem)} does not support '{options.Format}' format.");
            }
        }

        AzureReachabilityReportItem IPersistableModel<AzureReachabilityReportItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureReachabilityReportItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureReachabilityReportItem(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureReachabilityReportItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureReachabilityReportItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
