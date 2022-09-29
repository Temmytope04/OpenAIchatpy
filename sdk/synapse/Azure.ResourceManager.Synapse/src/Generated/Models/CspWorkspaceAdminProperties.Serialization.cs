// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class CspWorkspaceAdminProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InitialWorkspaceAdminObjectId))
            {
                writer.WritePropertyName("initialWorkspaceAdminObjectId");
                writer.WriteStringValue(InitialWorkspaceAdminObjectId);
            }
            writer.WriteEndObject();
        }

        internal static CspWorkspaceAdminProperties DeserializeCspWorkspaceAdminProperties(JsonElement element)
        {
            Optional<string> initialWorkspaceAdminObjectId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialWorkspaceAdminObjectId"))
                {
                    initialWorkspaceAdminObjectId = property.Value.GetString();
                    continue;
                }
            }
            return new CspWorkspaceAdminProperties(initialWorkspaceAdminObjectId.Value);
        }
    }
}
