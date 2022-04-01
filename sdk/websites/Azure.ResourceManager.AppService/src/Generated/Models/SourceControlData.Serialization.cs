// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SourceControlData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token");
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(TokenSecret))
            {
                writer.WritePropertyName("tokenSecret");
                writer.WriteStringValue(TokenSecret);
            }
            if (Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken");
                writer.WriteStringValue(RefreshToken);
            }
            if (Optional.IsDefined(ExpirationOn))
            {
                writer.WritePropertyName("expirationTime");
                writer.WriteStringValue(ExpirationOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SourceControlData DeserializeSourceControlData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> token = default;
            Optional<string> tokenSecret = default;
            Optional<string> refreshToken = default;
            Optional<DateTimeOffset> expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("token"))
                        {
                            token = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tokenSecret"))
                        {
                            tokenSecret = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("refreshToken"))
                        {
                            refreshToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expirationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SourceControlData(id, name, type, systemData, kind.Value, token.Value, tokenSecret.Value, refreshToken.Value, Optional.ToNullable(expirationTime));
        }
    }
}
