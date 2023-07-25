// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryReplicationAppliance
    {
        internal static SiteRecoveryReplicationAppliance DeserializeSiteRecoveryReplicationAppliance(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryReplicationApplianceProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SiteRecoveryReplicationApplianceProperties.DeserializeSiteRecoveryReplicationApplianceProperties(property.Value);
                    continue;
                }
            }
            return new SiteRecoveryReplicationAppliance(properties.Value);
        }
    }
}
