// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    internal partial class DataReplicationRecoveryPointListResult
    {
        internal static DataReplicationRecoveryPointListResult DeserializeDataReplicationRecoveryPointListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataReplicationRecoveryPointData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationRecoveryPointData> array = new List<DataReplicationRecoveryPointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationRecoveryPointData.DeserializeDataReplicationRecoveryPointData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DataReplicationRecoveryPointListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
