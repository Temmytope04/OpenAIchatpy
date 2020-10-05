// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceEncryptionProtector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerKeyName))
            {
                writer.WritePropertyName("serverKeyName");
                writer.WriteStringValue(ServerKeyName);
            }
            if (Optional.IsDefined(ServerKeyType))
            {
                writer.WritePropertyName("serverKeyType");
                writer.WriteStringValue(ServerKeyType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceEncryptionProtector DeserializeManagedInstanceEncryptionProtector(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> serverKeyName = default;
            Optional<ServerKeyType> serverKeyType = default;
            Optional<string> uri = default;
            Optional<string> thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverKeyName"))
                        {
                            serverKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyType"))
                        {
                            serverKeyType = new ServerKeyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"))
                        {
                            uri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceEncryptionProtector(id.Value, name.Value, type.Value, kind.Value, serverKeyName.Value, Optional.ToNullable(serverKeyType), uri.Value, thumbprint.Value);
        }
    }
}
