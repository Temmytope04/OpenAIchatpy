// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal partial class UnknownMigrateSqlServerSqlMISyncTaskOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resultType");
            writer.WriteStringValue(ResultType);
            writer.WriteEndObject();
        }

        internal static UnknownMigrateSqlServerSqlMISyncTaskOutput DeserializeUnknownMigrateSqlServerSqlMISyncTaskOutput(JsonElement element)
        {
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownMigrateSqlServerSqlMISyncTaskOutput(id.Value, resultType);
        }
    }
}
