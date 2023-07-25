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
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
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
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("performanceLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
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
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedAutoPauseDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedAutoPauseDelay = AutoPauseDelayTimeRange.DeserializeAutoPauseDelayTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedMinCapacities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("computeModel"u8))
                {
                    computeModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
            return new ServiceObjectiveCapability(Optional.ToNullable(id), name.Value, Optional.ToList(supportedMaxSizes), performanceLevel.Value, sku.Value, Optional.ToList(supportedLicenseTypes), includedMaxSize.Value, Optional.ToNullable(zoneRedundant), supportedAutoPauseDelay.Value, Optional.ToList(supportedMinCapacities), computeModel.Value, Optional.ToList(supportedMaintenanceConfigurations), Optional.ToNullable(status), reason.Value);
        }
    }
}
