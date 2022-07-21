// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class VcoreCapability
    {
        internal static VcoreCapability DeserializeVcoreCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<long> vCores = default;
            Optional<long> supportedIops = default;
            Optional<long> supportedMemoryPerVcoreMB = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCores"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vCores = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedIops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportedIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedMemoryPerVcoreMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportedMemoryPerVcoreMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new VcoreCapability(name.Value, Optional.ToNullable(vCores), Optional.ToNullable(supportedIops), Optional.ToNullable(supportedMemoryPerVcoreMB), status.Value);
        }
    }
}
