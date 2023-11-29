// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EdgeMarketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeMarketplace
{
    public partial class OfferData
    {
        internal static OfferData DeserializeOfferData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> contentVersion = default;
            Optional<Uri> contentUrl = default;
            Optional<OfferContent> offerContent = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<MarketplaceSku>> marketplaceSkus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("contentVersion"u8))
                        {
                            contentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contentUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offerContent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offerContent = OfferContent.DeserializeOfferContent(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceSkus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MarketplaceSku> array = new List<MarketplaceSku>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MarketplaceSku.DeserializeMarketplaceSku(item));
                            }
                            marketplaceSkus = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new OfferData(id, name, type, systemData.Value, contentVersion.Value, contentUrl.Value, offerContent.Value, Optional.ToNullable(provisioningState), Optional.ToList(marketplaceSkus));
        }
    }
}
