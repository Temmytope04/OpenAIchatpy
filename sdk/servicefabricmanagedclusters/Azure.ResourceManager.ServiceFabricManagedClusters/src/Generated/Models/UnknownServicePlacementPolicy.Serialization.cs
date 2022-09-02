// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    internal partial class UnknownServicePlacementPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownServicePlacementPolicy DeserializeUnknownServicePlacementPolicy(JsonElement element)
        {
            ServicePlacementPolicyType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownServicePlacementPolicy(type);
        }
    }
}
