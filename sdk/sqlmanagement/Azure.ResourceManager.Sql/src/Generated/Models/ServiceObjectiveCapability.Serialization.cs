// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServiceObjectiveCapability
    {
        internal static ServiceObjectiveCapability DeserializeServiceObjectiveCapability(JsonElement element)
        {
            Optional<Guid> id = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedMaxSizes = default;
            Optional<PerformanceLevelCapability> performanceLevel = default;
            Optional<SqlSku> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<bool> zoneRedundant = default;
            Optional<AutoPauseDelayTimeRange> supportedAutoPauseDelay = default;
            Optional<IReadOnlyList<MinCapacityCapability>> supportedMinCapacities = default;
            Optional<string> computeModel = default;
            Optional<IReadOnlyList<MaintenanceConfigurationCapability>> supportedMaintenanceConfigurations = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("performanceLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("includedMaxSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedAutoPauseDelay"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportedAutoPauseDelay = AutoPauseDelayTimeRange.DeserializeAutoPauseDelayTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedMinCapacities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MinCapacityCapability> array = new List<MinCapacityCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MinCapacityCapability.DeserializeMinCapacityCapability(item));
                    }
                    supportedMinCapacities = array;
                    continue;
                }
                if (property.NameEquals("computeModel"))
                {
                    computeModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaintenanceConfigurationCapability> array = new List<MaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceConfigurationCapability.DeserializeMaintenanceConfigurationCapability(item));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceObjectiveCapability(Optional.ToNullable(id), name.Value, Optional.ToList(supportedMaxSizes), performanceLevel.Value, sku.Value, Optional.ToList(supportedLicenseTypes), includedMaxSize.Value, Optional.ToNullable(zoneRedundant), supportedAutoPauseDelay.Value, Optional.ToList(supportedMinCapacities), computeModel.Value, Optional.ToList(supportedMaintenanceConfigurations), Optional.ToNullable(status), reason.Value);
        }
    }
}
