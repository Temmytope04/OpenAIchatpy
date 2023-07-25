// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlTopQueryStatisticsInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("numberOfTopQueries"u8);
            writer.WriteNumberValue(NumberOfTopQueries);
            writer.WritePropertyName("aggregationFunction"u8);
            writer.WriteStringValue(AggregationFunction);
            writer.WritePropertyName("observedMetric"u8);
            writer.WriteStringValue(ObservedMetric);
            writer.WritePropertyName("observationStartTime"u8);
            writer.WriteStringValue(ObservationStartOn, "O");
            writer.WritePropertyName("observationEndTime"u8);
            writer.WriteStringValue(ObservationEndOn, "O");
            writer.WritePropertyName("aggregationWindow"u8);
            writer.WriteStringValue(AggregationWindow);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
