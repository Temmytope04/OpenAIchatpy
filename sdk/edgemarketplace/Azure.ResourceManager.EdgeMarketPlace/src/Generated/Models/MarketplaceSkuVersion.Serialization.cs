// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeMarketplace.Models
{
    public partial class MarketplaceSkuVersion
    {
        internal static MarketplaceSkuVersion DeserializeMarketplaceSkuVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<int> sizeOnDiskInMb = default;
            Optional<int> minimumDownloadSizeInMb = default;
            Optional<string> stageName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeOnDiskInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeOnDiskInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minimumDownloadSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumDownloadSizeInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stageName"u8))
                {
                    stageName = property.Value.GetString();
                    continue;
                }
            }
            return new MarketplaceSkuVersion(name, Optional.ToNullable(sizeOnDiskInMb), Optional.ToNullable(minimumDownloadSizeInMb), stageName.Value);
        }
    }
}
