// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerEditionCapability
    {
        internal static MySqlFlexibleServerEditionCapability DeserializeMySqlFlexibleServerEditionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<MySqlFlexibleServerStorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<MySqlFlexibleServerServerVersionCapability>> supportedServerVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerStorageEditionCapability> array = new List<MySqlFlexibleServerStorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerStorageEditionCapability.DeserializeMySqlFlexibleServerStorageEditionCapability(item));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerServerVersionCapability> array = new List<MySqlFlexibleServerServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerServerVersionCapability.DeserializeMySqlFlexibleServerServerVersionCapability(item));
                    }
                    supportedServerVersions = array;
                    continue;
                }
            }
            return new MySqlFlexibleServerEditionCapability(name.Value, Optional.ToList(supportedStorageEditions), Optional.ToList(supportedServerVersions));
        }
    }
}
