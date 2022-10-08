// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaBaseReplicationDetails
    {
        internal static HyperVReplicaBaseReplicationDetails DeserializeHyperVReplicaBaseReplicationDetails(JsonElement element)
        {
            Optional<DateTimeOffset> lastReplicatedTime = default;
            Optional<IReadOnlyList<VmNicDetails>> vmNics = default;
            Optional<string> vmId = default;
            Optional<string> vmProtectionState = default;
            Optional<string> vmProtectionStateDescription = default;
            Optional<InitialReplicationDetails> initialReplicationDetails = default;
            Optional<IReadOnlyList<DiskDetails>> vmDiskDetails = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastReplicatedTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastReplicatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmNics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VmNicDetails> array = new List<VmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicDetails.DeserializeVmNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("vmId"))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialReplicationDetails = InitialReplicationDetails.DeserializeInitialReplicationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vMDiskDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DiskDetails> array = new List<DiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskDetails.DeserializeDiskDetails(item));
                    }
                    vmDiskDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new HyperVReplicaBaseReplicationDetails(instanceType, Optional.ToNullable(lastReplicatedTime), Optional.ToList(vmNics), vmId.Value, vmProtectionState.Value, vmProtectionStateDescription.Value, initialReplicationDetails.Value, Optional.ToList(vmDiskDetails));
        }
    }
}
