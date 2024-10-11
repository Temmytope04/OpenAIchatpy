// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class DailyHistoricalRecords
    {
        internal static DailyHistoricalRecords DeserializeDailyHistoricalRecords(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? date = default;
            WeatherValueYearMaxMinAvg temperature = default;
            WeatherValueYearMax precipitation = default;
            WeatherValueYearMax snowfall = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = WeatherValueYearMaxMinAvg.DeserializeWeatherValueYearMaxMinAvg(property.Value);
                    continue;
                }
                if (property.NameEquals("precipitation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    precipitation = WeatherValueYearMax.DeserializeWeatherValueYearMax(property.Value);
                    continue;
                }
                if (property.NameEquals("snowfall"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snowfall = WeatherValueYearMax.DeserializeWeatherValueYearMax(property.Value);
                    continue;
                }
            }
            return new DailyHistoricalRecords(date, temperature, precipitation, snowfall);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DailyHistoricalRecords FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDailyHistoricalRecords(document.RootElement);
        }
    }
}
