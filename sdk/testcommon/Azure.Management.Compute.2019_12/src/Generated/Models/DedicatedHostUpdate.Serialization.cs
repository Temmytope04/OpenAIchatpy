// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DedicatedHostUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PlatformFaultDomain))
            {
                writer.WritePropertyName("platformFaultDomain");
                writer.WriteNumberValue(PlatformFaultDomain.Value);
            }
            if (Optional.IsDefined(AutoReplaceOnFailure))
            {
                writer.WritePropertyName("autoReplaceOnFailure");
                writer.WriteBooleanValue(AutoReplaceOnFailure.Value);
            }
            if (Optional.IsDefined(HostId))
            {
                writer.WritePropertyName("hostId");
                writer.WriteStringValue(HostId);
            }
            if (Optional.IsCollectionDefined(VirtualMachines))
            {
                writer.WritePropertyName("virtualMachines");
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProvisioningTime))
            {
                writer.WritePropertyName("provisioningTime");
                writer.WriteStringValue(ProvisioningTime.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView");
                writer.WriteObjectValue(InstanceView);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
