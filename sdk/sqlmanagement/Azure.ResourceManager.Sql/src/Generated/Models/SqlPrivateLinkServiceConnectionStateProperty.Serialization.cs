// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlPrivateLinkServiceConnectionStateProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("description");
            writer.WriteStringValue(Description);
            writer.WriteEndObject();
        }

        internal static SqlPrivateLinkServiceConnectionStateProperty DeserializeSqlPrivateLinkServiceConnectionStateProperty(JsonElement element)
        {
            SqlPrivateLinkServiceConnectionStatus status = default;
            string description = default;
            Optional<SqlPrivateLinkServiceConnectionActionsRequired> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new SqlPrivateLinkServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionsRequired = new SqlPrivateLinkServiceConnectionActionsRequired(property.Value.GetString());
                    continue;
                }
            }
            return new SqlPrivateLinkServiceConnectionStateProperty(status, description, Optional.ToNullable(actionsRequired));
        }
    }
}
