// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class SqlReferenceInputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server");
                writer.WriteStringValue(Server);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database");
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user");
                writer.WriteStringValue(User);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(RefreshType))
            {
                writer.WritePropertyName("refreshType");
                writer.WriteStringValue(RefreshType.Value.ToString());
            }
            if (Optional.IsDefined(RefreshRate))
            {
                writer.WritePropertyName("refreshRate");
                writer.WriteStringValue(RefreshRate.Value);
            }
            if (Optional.IsDefined(FullSnapshotQuery))
            {
                writer.WritePropertyName("fullSnapshotQuery");
                writer.WriteStringValue(FullSnapshotQuery);
            }
            if (Optional.IsDefined(DeltaSnapshotQuery))
            {
                writer.WritePropertyName("deltaSnapshotQuery");
                writer.WriteStringValue(DeltaSnapshotQuery);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlReferenceInputDataSource DeserializeSqlReferenceInputDataSource(JsonElement element)
        {
            string type = default;
            Optional<string> server = default;
            Optional<string> database = default;
            Optional<string> user = default;
            Optional<string> password = default;
            Optional<DataRefreshType> refreshType = default;
            Optional<DateTimeOffset> refreshRate = default;
            Optional<string> fullSnapshotQuery = default;
            Optional<string> deltaSnapshotQuery = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("server"))
                        {
                            server = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user"))
                        {
                            user = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("refreshType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            refreshType = new DataRefreshType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("refreshRate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            refreshRate = property0.Value.GetDateTimeOffset();
                            continue;
                        }
                        if (property0.NameEquals("fullSnapshotQuery"))
                        {
                            fullSnapshotQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deltaSnapshotQuery"))
                        {
                            deltaSnapshotQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlReferenceInputDataSource(type, server.Value, database.Value, user.Value, password.Value, Optional.ToNullable(refreshType), Optional.ToNullable(refreshRate), fullSnapshotQuery.Value, deltaSnapshotQuery.Value, Optional.ToNullable(authenticationMode));
        }
    }
}
