// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class StorageEditionCapability
    {
        internal static StorageEditionCapability DeserializeStorageEditionCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<StorageMBCapability>> supportedStorageMB = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StorageMBCapability> array = new List<StorageMBCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageMBCapability.DeserializeStorageMBCapability(item));
                    }
                    supportedStorageMB = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new StorageEditionCapability(name.Value, Optional.ToList(supportedStorageMB), status.Value);
        }
    }
}
