// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class EnvironmentInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId");
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(IngestionKey))
            {
                writer.WritePropertyName("ingestionKey");
                writer.WriteStringValue(IngestionKey);
            }
            if (Optional.IsDefined(LogsIngestionEndpoint))
            {
                writer.WritePropertyName("logsIngestionEndpoint");
                writer.WriteStringValue(LogsIngestionEndpoint);
            }
            if (Optional.IsDefined(LandingUri))
            {
                writer.WritePropertyName("landingURL");
                writer.WriteStringValue(LandingUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static EnvironmentInfo DeserializeEnvironmentInfo(JsonElement element)
        {
            Optional<string> environmentId = default;
            Optional<string> ingestionKey = default;
            Optional<string> logsIngestionEndpoint = default;
            Optional<Uri> landingUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ingestionKey"))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logsIngestionEndpoint"))
                {
                    logsIngestionEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("landingURL"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        landingUri = null;
                        continue;
                    }
                    landingUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new EnvironmentInfo(environmentId.Value, ingestionKey.Value, logsIngestionEndpoint.Value, landingUri.Value);
        }
    }
}
