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
    public partial class ExpressRouteCircuitRoutesTableSummary : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitRoutesTableSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitRoutesTableSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRouteCircuitRoutesTableSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExpressRouteCircuitRoutesTableSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Neighbor))
            {
                writer.WritePropertyName("neighbor"u8);
                writer.WriteStringValue(Neighbor);
            }
            if (Optional.IsDefined(V))
            {
                writer.WritePropertyName("v"u8);
                writer.WriteNumberValue(V.Value);
            }
            if (Optional.IsDefined(As))
            {
                writer.WritePropertyName("as"u8);
                writer.WriteNumberValue(As.Value);
            }
            if (Optional.IsDefined(UpDown))
            {
                writer.WritePropertyName("upDown"u8);
                writer.WriteStringValue(UpDown);
            }
            if (Optional.IsDefined(StatePfxRcd))
            {
                writer.WritePropertyName("statePfxRcd"u8);
                writer.WriteStringValue(StatePfxRcd);
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

        ExpressRouteCircuitRoutesTableSummary IJsonModel<ExpressRouteCircuitRoutesTableSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ExpressRouteCircuitRoutesTableSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitRoutesTableSummary(document.RootElement, options);
        }

        internal static ExpressRouteCircuitRoutesTableSummary DeserializeExpressRouteCircuitRoutesTableSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> neighbor = default;
            Optional<int> v = default;
            Optional<int> @as = default;
            Optional<string> upDown = default;
            Optional<string> statePfxRcd = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("neighbor"u8))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("v"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    v = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("as"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @as = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upDown"u8))
                {
                    upDown = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statePfxRcd"u8))
                {
                    statePfxRcd = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteCircuitRoutesTableSummary(neighbor.Value, Optional.ToNullable(v), Optional.ToNullable(@as), upDown.Value, statePfxRcd.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitRoutesTableSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ExpressRouteCircuitRoutesTableSummary)} does not support '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitRoutesTableSummary IPersistableModel<ExpressRouteCircuitRoutesTableSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitRoutesTableSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteCircuitRoutesTableSummary(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ExpressRouteCircuitRoutesTableSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitRoutesTableSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
