// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityHop
    {
        internal static ConnectivityHop DeserializeConnectivityHop(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<string> address = default;
            Optional<string> resourceId = default;
            Optional<IReadOnlyList<string>> nextHopIds = default;
            Optional<IReadOnlyList<ConnectivityIssue>> issues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHopIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nextHopIds = array;
                    continue;
                }
                if (property.NameEquals("issues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectivityIssue> array = new List<ConnectivityIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityIssue.DeserializeConnectivityIssue(item));
                    }
                    issues = array;
                    continue;
                }
            }
            return new ConnectivityHop(type.Value, id.Value, address.Value, resourceId.Value, Optional.ToList(nextHopIds), Optional.ToList(issues));
        }
    }
}
