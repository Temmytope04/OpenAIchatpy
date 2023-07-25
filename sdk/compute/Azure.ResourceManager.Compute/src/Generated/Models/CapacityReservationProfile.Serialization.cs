// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class CapacityReservationProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CapacityReservationGroup))
            {
                writer.WritePropertyName("capacityReservationGroup"u8);
                JsonSerializer.Serialize(writer, CapacityReservationGroup);
            }
            writer.WriteEndObject();
        }

        internal static CapacityReservationProfile DeserializeCapacityReservationProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> capacityReservationGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacityReservationGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservationGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new CapacityReservationProfile(capacityReservationGroup);
        }
    }
}
