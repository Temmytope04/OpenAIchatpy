// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeMarketplace.Models
{
    public partial class DiskAccessToken
    {
        internal static DiskAccessToken DeserializeDiskAccessToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> status = default;
            string accessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
            }
            return new DiskAccessToken(diskId.Value, status.Value, accessToken);
        }
    }
}
