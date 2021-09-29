// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HealthProbe))
            {
                writer.WritePropertyName("healthProbe");
                writer.WriteObjectValue(HealthProbe);
            }
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations))
            {
                writer.WritePropertyName("networkInterfaceConfigurations");
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkApiVersion))
            {
                writer.WritePropertyName("networkApiVersion");
                writer.WriteStringValue(NetworkApiVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetNetworkProfile DeserializeVirtualMachineScaleSetNetworkProfile(JsonElement element)
        {
            Optional<ApiEntityReference> healthProbe = default;
            Optional<IList<VirtualMachineScaleSetNetworkConfiguration>> networkInterfaceConfigurations = default;
            Optional<NetworkApiVersion> networkApiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthProbe"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    healthProbe = ApiEntityReference.DeserializeApiEntityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("networkInterfaceConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualMachineScaleSetNetworkConfiguration> array = new List<VirtualMachineScaleSetNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineScaleSetNetworkConfiguration.DeserializeVirtualMachineScaleSetNetworkConfiguration(item));
                    }
                    networkInterfaceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("networkApiVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkApiVersion = new NetworkApiVersion(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachineScaleSetNetworkProfile(healthProbe.Value, Optional.ToList(networkInterfaceConfigurations), Optional.ToNullable(networkApiVersion));
        }
    }
}
