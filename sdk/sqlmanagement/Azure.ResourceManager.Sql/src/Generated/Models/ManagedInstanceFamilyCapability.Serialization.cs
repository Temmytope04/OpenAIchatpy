// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceFamilyCapability
    {
        internal static ManagedInstanceFamilyCapability DeserializeManagedInstanceFamilyCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<IReadOnlyList<ManagedInstanceVcoresCapability>> supportedVcoresValues = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedVcoresValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceVcoresCapability> array = new List<ManagedInstanceVcoresCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceVcoresCapability.DeserializeManagedInstanceVcoresCapability(item));
                    }
                    supportedVcoresValues = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedInstanceFamilyCapability(name.Value, sku.Value, Optional.ToList(supportedLicenseTypes), Optional.ToList(supportedVcoresValues), Optional.ToNullable(status), reason.Value);
        }
    }
}
