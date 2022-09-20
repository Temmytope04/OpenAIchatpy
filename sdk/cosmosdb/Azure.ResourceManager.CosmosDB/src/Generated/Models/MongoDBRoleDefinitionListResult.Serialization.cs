// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class MongoDBRoleDefinitionListResult
    {
        internal static MongoDBRoleDefinitionListResult DeserializeMongoDBRoleDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MongoDBRoleDefinitionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MongoDBRoleDefinitionData> array = new List<MongoDBRoleDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBRoleDefinitionData.DeserializeMongoDBRoleDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MongoDBRoleDefinitionListResult(Optional.ToList(value));
        }
    }
}
