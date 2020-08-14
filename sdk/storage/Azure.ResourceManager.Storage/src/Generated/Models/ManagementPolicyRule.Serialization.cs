// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("definition");
            writer.WriteObjectValue(Definition);
            writer.WriteEndObject();
        }

        internal static ManagementPolicyRule DeserializeManagementPolicyRule(JsonElement element)
        {
            Optional<bool> enabled = default;
            string name = default;
            RuleType type = default;
            ManagementPolicyDefinition definition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new RuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("definition"))
                {
                    definition = ManagementPolicyDefinition.DeserializeManagementPolicyDefinition(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyRule(Optional.ToNullable(enabled), name, type, definition);
        }
    }
}
