// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyLogAnalyticsWorkspace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region");
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId");
                writer.WriteObjectValue(WorkspaceId);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyLogAnalyticsWorkspace DeserializeFirewallPolicyLogAnalyticsWorkspace(JsonElement element)
        {
            Optional<string> region = default;
            Optional<SubResource> workspaceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("region"))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workspaceId = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
            }
            return new FirewallPolicyLogAnalyticsWorkspace(region.Value, workspaceId.Value);
        }
    }
}
