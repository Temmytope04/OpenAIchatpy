// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class UpdateReplicationProtectedItemInputProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryAzureVmName))
            {
                writer.WritePropertyName("recoveryAzureVMName");
                writer.WriteStringValue(RecoveryAzureVmName);
            }
            if (Optional.IsDefined(RecoveryAzureVmSize))
            {
                writer.WritePropertyName("recoveryAzureVMSize");
                writer.WriteStringValue(RecoveryAzureVmSize);
            }
            if (Optional.IsDefined(SelectedRecoveryAzureNetworkId))
            {
                writer.WritePropertyName("selectedRecoveryAzureNetworkId");
                writer.WriteStringValue(SelectedRecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedTfoAzureNetworkId))
            {
                writer.WritePropertyName("selectedTfoAzureNetworkId");
                writer.WriteStringValue(SelectedTfoAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedSourceNicId))
            {
                writer.WritePropertyName("selectedSourceNicId");
                writer.WriteStringValue(SelectedSourceNicId);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption");
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics");
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId");
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails");
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            writer.WriteEndObject();
        }
    }
}
