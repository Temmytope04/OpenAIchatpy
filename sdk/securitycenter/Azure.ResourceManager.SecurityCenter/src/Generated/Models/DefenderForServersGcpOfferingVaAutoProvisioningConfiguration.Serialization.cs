// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderForServersGcpOfferingVaAutoProvisioningConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VAAutoProvisioningType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(VAAutoProvisioningType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DefenderForServersGcpOfferingVaAutoProvisioningConfiguration DeserializeDefenderForServersGcpOfferingVaAutoProvisioningConfiguration(JsonElement element)
        {
            Optional<VAAutoProvisioningType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new VAAutoProvisioningType(property.Value.GetString());
                    continue;
                }
            }
            return new DefenderForServersGcpOfferingVaAutoProvisioningConfiguration(Optional.ToNullable(type));
        }
    }
}
