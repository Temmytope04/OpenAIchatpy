// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class MarketplaceAdminApprovalRequestList
    {
        internal static MarketplaceAdminApprovalRequestList DeserializeMarketplaceAdminApprovalRequestList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MarketplaceAdminApprovalRequestData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarketplaceAdminApprovalRequestData> array = new List<MarketplaceAdminApprovalRequestData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarketplaceAdminApprovalRequestData.DeserializeMarketplaceAdminApprovalRequestData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MarketplaceAdminApprovalRequestList(Optional.ToList(value), nextLink.Value);
        }
    }
}
