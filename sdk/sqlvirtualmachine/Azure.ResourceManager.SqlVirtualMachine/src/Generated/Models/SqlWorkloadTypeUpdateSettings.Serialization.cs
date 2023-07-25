// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    internal partial class SqlWorkloadTypeUpdateSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlWorkloadType))
            {
                writer.WritePropertyName("sqlWorkloadType"u8);
                writer.WriteStringValue(SqlWorkloadType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SqlWorkloadTypeUpdateSettings DeserializeSqlWorkloadTypeUpdateSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlWorkloadType> sqlWorkloadType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlWorkloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWorkloadType = new SqlWorkloadType(property.Value.GetString());
                    continue;
                }
            }
            return new SqlWorkloadTypeUpdateSettings(Optional.ToNullable(sqlWorkloadType));
        }
    }
}
