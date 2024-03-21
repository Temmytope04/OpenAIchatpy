// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class CalculateExchangeContentProperties : IUtf8JsonSerializable, IJsonModel<CalculateExchangeContentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CalculateExchangeContentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CalculateExchangeContentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculateExchangeContentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
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

        CalculateExchangeContentProperties IJsonModel<CalculateExchangeContentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculateExchangeContentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculateExchangeContentProperties(document.RootElement, options);
        }

        internal static CalculateExchangeContentProperties DeserializeCalculateExchangeContentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ReservationPurchaseContent> reservationsToPurchase = default;
            IList<SavingsPlanPurchase> savingsPlansToPurchase = default;
            IList<ReservationToReturn> reservationsToExchange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationPurchaseContent> array = new List<ReservationPurchaseContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationPurchaseContent.DeserializeReservationPurchaseContent(item, options));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanPurchase> array = new List<SavingsPlanPurchase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanPurchase.DeserializeSavingsPlanPurchase(item, options));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToReturn> array = new List<ReservationToReturn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToReturn.DeserializeReservationToReturn(item, options));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CalculateExchangeContentProperties(reservationsToPurchase ?? new ChangeTrackingList<ReservationPurchaseContent>(), savingsPlansToPurchase ?? new ChangeTrackingList<SavingsPlanPurchase>(), reservationsToExchange ?? new ChangeTrackingList<ReservationToReturn>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CalculateExchangeContentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CalculateExchangeContentProperties)} does not support '{options.Format}' format.");
            }
        }

        CalculateExchangeContentProperties IPersistableModel<CalculateExchangeContentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCalculateExchangeContentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CalculateExchangeContentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CalculateExchangeContentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
