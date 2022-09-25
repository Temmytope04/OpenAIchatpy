// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmToVmmNetworkMappingSettings
    {
        internal static VmmToVmmNetworkMappingSettings DeserializeVmmToVmmNetworkMappingSettings(JsonElement element)
        {
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VmmToVmmNetworkMappingSettings(instanceType);
        }
    }
}
