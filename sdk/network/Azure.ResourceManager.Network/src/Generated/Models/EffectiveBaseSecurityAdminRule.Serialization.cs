// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveBaseSecurityAdminRule
    {
        internal static EffectiveBaseSecurityAdminRule DeserializeEffectiveBaseSecurityAdminRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return EffectiveSecurityAdminRule.DeserializeEffectiveSecurityAdminRule(element);
                    case "Default": return EffectiveDefaultSecurityAdminRule.DeserializeEffectiveDefaultSecurityAdminRule(element);
                }
            }
            return UnknownEffectiveBaseSecurityAdminRule.DeserializeUnknownEffectiveBaseSecurityAdminRule(element);
        }
    }
}
