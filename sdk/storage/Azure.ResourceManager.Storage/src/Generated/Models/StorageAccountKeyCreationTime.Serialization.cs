// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountKeyCreationTime
    {
        internal static StorageAccountKeyCreationTime DeserializeStorageAccountKeyCreationTime(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> key1 = default;
            Optional<DateTimeOffset> key2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key1 = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    key2 = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new StorageAccountKeyCreationTime(Optional.ToNullable(key1), Optional.ToNullable(key2));
        }
    }
}
