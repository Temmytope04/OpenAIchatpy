// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHsmGeoReplicatedRegion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedHsmGeoReplicatedRegion DeserializeManagedHsmGeoReplicatedRegion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ManagedHsmGeoReplicatedRegionProvisioningState> provisioningState = default;
            Optional<bool> isPrimary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedHsmGeoReplicatedRegionProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ManagedHsmGeoReplicatedRegion(name.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isPrimary));
        }
    }
}
