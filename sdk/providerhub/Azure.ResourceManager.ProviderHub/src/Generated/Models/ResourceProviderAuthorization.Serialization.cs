// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceProviderAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId");
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId");
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(ManagedByRoleDefinitionId))
            {
                writer.WritePropertyName("managedByRoleDefinitionId");
                writer.WriteStringValue(ManagedByRoleDefinitionId);
            }
            writer.WriteEndObject();
        }

        internal static ResourceProviderAuthorization DeserializeResourceProviderAuthorization(JsonElement element)
        {
            Optional<string> applicationId = default;
            Optional<string> roleDefinitionId = default;
            Optional<string> managedByRoleDefinitionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByRoleDefinitionId"))
                {
                    managedByRoleDefinitionId = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceProviderAuthorization(applicationId.Value, roleDefinitionId.Value, managedByRoleDefinitionId.Value);
        }
    }
}
