// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ArmApplicationManagedIdentity DeserializeArmApplicationManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<ArmApplicationManagedIdentityType> type = default;
            Optional<IDictionary<string, ArmApplicationUserAssignedIdentity>> userAssignedIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToArmApplicationManagedIdentityType();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ArmApplicationUserAssignedIdentity> dictionary = new Dictionary<string, ArmApplicationUserAssignedIdentity>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ArmApplicationUserAssignedIdentity.DeserializeArmApplicationUserAssignedIdentity(property0.Value));
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
            }
            return new ArmApplicationManagedIdentity(Optional.ToNullable(principalId), Optional.ToNullable(tenantId), Optional.ToNullable(type), Optional.ToDictionary(userAssignedIdentities));
        }
    }
}
