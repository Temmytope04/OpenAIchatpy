// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RecordSet
    {
        internal static RecordSet DeserializeRecordSet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recordType = default;
            Optional<string> recordSetName = default;
            Optional<string> fqdn = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<int> ttl = default;
            Optional<IReadOnlyList<string>> ipAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordType"u8))
                {
                    recordType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordSetName"u8))
                {
                    recordSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NetworkProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ttl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipAddresses = array;
                    continue;
                }
            }
            return new RecordSet(recordType.Value, recordSetName.Value, fqdn.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(ttl), Optional.ToList(ipAddresses));
        }
    }
}
