// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerAzureADAdministrator : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorType))
            {
                writer.WritePropertyName("administratorType");
                writer.WriteStringValue(AdministratorType.Value.ToString());
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login");
                writer.WriteStringValue(Login);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid");
                writer.WriteStringValue(Sid.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerAzureADAdministrator DeserializeServerAzureADAdministrator(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<AdministratorType> administratorType = default;
            Optional<string> login = default;
            Optional<Guid> sid = default;
            Optional<Guid> tenantId = default;
            Optional<bool> azureADOnlyAuthentication = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("administratorType"))
                        {
                            administratorType = new AdministratorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("login"))
                        {
                            login = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sid"))
                        {
                            sid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("azureADOnlyAuthentication"))
                        {
                            azureADOnlyAuthentication = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerAzureADAdministrator(id.Value, name.Value, type.Value, Optional.ToNullable(administratorType), login.Value, Optional.ToNullable(sid), Optional.ToNullable(tenantId), Optional.ToNullable(azureADOnlyAuthentication));
        }
    }
}
