// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceSqlServerTaskOutputAgentJobLevel
    {
        internal static ConnectToSourceSqlServerTaskOutputAgentJobLevel DeserializeConnectToSourceSqlServerTaskOutputAgentJobLevel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> jobCategory = default;
            Optional<bool> isEnabled = default;
            Optional<string> jobOwner = default;
            Optional<DateTimeOffset> lastExecutedOn = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            Optional<MigrationEligibilityInfo> migrationEligibility = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCategory"u8))
                {
                    jobCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobOwner"u8))
                {
                    jobOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastExecutedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastExecutedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("migrationEligibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationEligibility = MigrationEligibilityInfo.DeserializeMigrationEligibilityInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectToSourceSqlServerTaskOutputAgentJobLevel(id.Value, resultType, name.Value, jobCategory.Value, Optional.ToNullable(isEnabled), jobOwner.Value, Optional.ToNullable(lastExecutedOn), Optional.ToList(validationErrors), migrationEligibility.Value);
        }
    }
}
