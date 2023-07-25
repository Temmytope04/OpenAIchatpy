// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityCvss
    {
        internal static SecurityCvss DeserializeSecurityCvss(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> @base = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("base"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @base = property.Value.GetSingle();
                    continue;
                }
            }
            return new SecurityCvss(Optional.ToNullable(@base));
        }
    }
}
