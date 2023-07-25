// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    public partial class AnalysisGatewayDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GatewayResourceId))
            {
                writer.WritePropertyName("gatewayResourceId"u8);
                writer.WriteStringValue(GatewayResourceId);
            }
            writer.WriteEndObject();
        }

        internal static AnalysisGatewayDetails DeserializeAnalysisGatewayDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> gatewayResourceId = default;
            Optional<string> gatewayObjectId = default;
            Optional<Uri> dmtsClusterUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gatewayResourceId"u8))
                {
                    gatewayResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gatewayObjectId"u8))
                {
                    gatewayObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dmtsClusterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dmtsClusterUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new AnalysisGatewayDetails(gatewayResourceId.Value, gatewayObjectId.Value, dmtsClusterUri.Value);
        }
    }
}
