// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmEnableProtectionInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("fabricDiscoveryMachineId");
            writer.WriteStringValue(FabricDiscoveryMachineId);
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude");
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisksDefault))
            {
                writer.WritePropertyName("disksDefault");
                writer.WriteObjectValue(DisksDefault);
            }
            writer.WritePropertyName("targetResourceGroupId");
            writer.WriteStringValue(TargetResourceGroupId);
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId");
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId");
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName");
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName");
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName");
                writer.WriteStringValue(TargetVmName);
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize");
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId");
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone");
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId");
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(TargetBootDiagnosticsStorageAccountId))
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId");
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId");
                writer.WriteStringValue(RunAsAccountId);
            }
            writer.WritePropertyName("processServerId");
            writer.WriteStringValue(ProcessServerId);
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName");
                writer.WriteStringValue(MultiVmGroupName);
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
