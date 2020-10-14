// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RadiusServer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("radiusServerAddress");
            writer.WriteStringValue(RadiusServerAddress);
            if (Optional.IsDefined(RadiusServerScore))
            {
                writer.WritePropertyName("radiusServerScore");
                writer.WriteNumberValue(RadiusServerScore.Value);
            }
            if (Optional.IsDefined(RadiusServerSecret))
            {
                writer.WritePropertyName("radiusServerSecret");
                writer.WriteStringValue(RadiusServerSecret);
            }
            writer.WriteEndObject();
        }

        internal static RadiusServer DeserializeRadiusServer(JsonElement element)
        {
            string radiusServerAddress = default;
            Optional<long> radiusServerScore = default;
            Optional<string> radiusServerSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("radiusServerAddress"))
                {
                    radiusServerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServerScore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    radiusServerScore = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("radiusServerSecret"))
                {
                    radiusServerSecret = property.Value.GetString();
                    continue;
                }
            }
            return new RadiusServer(radiusServerAddress, Optional.ToNullable(radiusServerScore), radiusServerSecret.Value);
        }
    }
}
