// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSkuRestrictions
    {
        internal static AppPlatformSkuRestrictions DeserializeAppPlatformSkuRestrictions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformSkuRestrictionsType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<AppPlatformSkuRestrictionInfo> restrictionInfo = default;
            Optional<AppPlatformSkuRestrictionsReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AppPlatformSkuRestrictionsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictionInfo = AppPlatformSkuRestrictionInfo.DeserializeAppPlatformSkuRestrictionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = new AppPlatformSkuRestrictionsReasonCode(property.Value.GetString());
                    continue;
                }
            }
            return new AppPlatformSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), restrictionInfo.Value, Optional.ToNullable(reasonCode));
        }
    }
}
