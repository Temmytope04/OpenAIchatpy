// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class AssociatedWorkspace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static AssociatedWorkspace DeserializeAssociatedWorkspace(JsonElement element)
        {
            Optional<string> workspaceId = default;
            Optional<string> workspaceName = default;
            Optional<string> resourceId = default;
            Optional<string> associateDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("associateDate"))
                {
                    associateDate = property.Value.GetString();
                    continue;
                }
            }
            return new AssociatedWorkspace(workspaceId.Value, workspaceName.Value, resourceId.Value, associateDate.Value);
        }
    }
}
