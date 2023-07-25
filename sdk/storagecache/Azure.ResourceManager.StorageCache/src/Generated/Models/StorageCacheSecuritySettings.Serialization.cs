// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    internal partial class StorageCacheSecuritySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("accessPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AccessPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StorageCacheSecuritySettings DeserializeStorageCacheSecuritySettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<NfsAccessPolicy>> accessPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NfsAccessPolicy> array = new List<NfsAccessPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NfsAccessPolicy.DeserializeNfsAccessPolicy(item));
                    }
                    accessPolicies = array;
                    continue;
                }
            }
            return new StorageCacheSecuritySettings(Optional.ToList(accessPolicies));
        }
    }
}
