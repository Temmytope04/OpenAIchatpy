// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    public partial class PageViewPerfData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration");
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(PerfTotal))
            {
                writer.WritePropertyName("perfTotal");
                writer.WriteStringValue(PerfTotal);
            }
            if (Optional.IsDefined(NetworkConnect))
            {
                writer.WritePropertyName("networkConnect");
                writer.WriteStringValue(NetworkConnect);
            }
            if (Optional.IsDefined(SentRequest))
            {
                writer.WritePropertyName("sentRequest");
                writer.WriteStringValue(SentRequest);
            }
            if (Optional.IsDefined(ReceivedResponse))
            {
                writer.WritePropertyName("receivedResponse");
                writer.WriteStringValue(ReceivedResponse);
            }
            if (Optional.IsDefined(DomProcessing))
            {
                writer.WritePropertyName("domProcessing");
                writer.WriteStringValue(DomProcessing);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements");
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver");
            writer.WriteNumberValue(Version);
            writer.WriteEndObject();
        }
    }
}
