// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServicePlacementNonPartiallyPlaceServicePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ServicePlacementPolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static ServicePlacementNonPartiallyPlaceServicePolicy DeserializeServicePlacementNonPartiallyPlaceServicePolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServicePlacementPolicyType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new ServicePlacementNonPartiallyPlaceServicePolicy(type);
        }
    }
}
