// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHostName
    {
        internal static AppServiceHostName DeserializeAppServiceHostName(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<string>> siteNames = default;
            Optional<string> azureResourceName = default;
            Optional<AppServiceResourceType> azureResourceType = default;
            Optional<CustomHostNameDnsRecordType> customHostNameDnsRecordType = default;
            Optional<AppServiceHostNameType> hostNameType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteNames"u8))
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
                    siteNames = array;
                    continue;
                }
                if (property.NameEquals("azureResourceName"u8))
                {
                    azureResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureResourceType = property.Value.GetString().ToAppServiceResourceType();
                    continue;
                }
                if (property.NameEquals("customHostNameDnsRecordType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customHostNameDnsRecordType = property.Value.GetString().ToCustomHostNameDnsRecordType();
                    continue;
                }
                if (property.NameEquals("hostNameType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostNameType = property.Value.GetString().ToAppServiceHostNameType();
                    continue;
                }
            }
            return new AppServiceHostName(name.Value, Optional.ToList(siteNames), azureResourceName.Value, Optional.ToNullable(azureResourceType), Optional.ToNullable(customHostNameDnsRecordType), Optional.ToNullable(hostNameType));
        }
    }
}
