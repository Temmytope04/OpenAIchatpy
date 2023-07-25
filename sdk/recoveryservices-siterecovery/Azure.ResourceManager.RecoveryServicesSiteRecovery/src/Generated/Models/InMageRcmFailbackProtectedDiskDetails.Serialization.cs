// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackProtectedDiskDetails
    {
        internal static InMageRcmFailbackProtectedDiskDetails DeserializeInMageRcmFailbackProtectedDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<string> isOSDisk = default;
            Optional<long> capacityInBytes = default;
            Optional<string> diskUuid = default;
            Optional<double> dataPendingInLogDataStoreInMB = default;
            Optional<double> dataPendingAtSourceAgentInMB = default;
            Optional<string> isInitialReplicationComplete = default;
            Optional<InMageRcmFailbackSyncDetails> irDetails = default;
            Optional<InMageRcmFailbackSyncDetails> resyncDetails = default;
            Optional<DateTimeOffset> lastSyncTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskUuid"u8))
                {
                    diskUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInLogDataStoreInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInLogDataStoreInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isInitialReplicationComplete"u8))
                {
                    isInitialReplicationComplete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("irDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    irDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("resyncDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new InMageRcmFailbackProtectedDiskDetails(diskId.Value, diskName.Value, isOSDisk.Value, Optional.ToNullable(capacityInBytes), diskUuid.Value, Optional.ToNullable(dataPendingInLogDataStoreInMB), Optional.ToNullable(dataPendingAtSourceAgentInMB), isInitialReplicationComplete.Value, irDetails.Value, resyncDetails.Value, Optional.ToNullable(lastSyncTime));
        }
    }
}
