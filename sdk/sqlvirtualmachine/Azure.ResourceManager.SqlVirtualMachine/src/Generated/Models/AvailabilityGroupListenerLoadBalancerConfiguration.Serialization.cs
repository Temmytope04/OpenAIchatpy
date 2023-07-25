// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AvailabilityGroupListenerLoadBalancerConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIpAddress"u8);
                writer.WriteObjectValue(PrivateIPAddress);
            }
            if (Optional.IsDefined(PublicIPAddressResourceId))
            {
                writer.WritePropertyName("publicIpAddressResourceId"u8);
                writer.WriteStringValue(PublicIPAddressResourceId);
            }
            if (Optional.IsDefined(LoadBalancerResourceId))
            {
                writer.WritePropertyName("loadBalancerResourceId"u8);
                writer.WriteStringValue(LoadBalancerResourceId);
            }
            if (Optional.IsDefined(ProbePort))
            {
                writer.WritePropertyName("probePort"u8);
                writer.WriteNumberValue(ProbePort.Value);
            }
            if (Optional.IsCollectionDefined(SqlVmInstances))
            {
                writer.WritePropertyName("sqlVirtualMachineInstances"u8);
                writer.WriteStartArray();
                foreach (var item in SqlVmInstances)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AvailabilityGroupListenerLoadBalancerConfiguration DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvailabilityGroupListenerPrivateIPAddress> privateIPAddress = default;
            Optional<ResourceIdentifier> publicIPAddressResourceId = default;
            Optional<ResourceIdentifier> loadBalancerResourceId = default;
            Optional<int> probePort = default;
            Optional<IList<ResourceIdentifier>> sqlVmInstances = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = AvailabilityGroupListenerPrivateIPAddress.DeserializeAvailabilityGroupListenerPrivateIPAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("publicIpAddressResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPAddressResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancerResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("probePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sqlVirtualMachineInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    sqlVmInstances = array;
                    continue;
                }
            }
            return new AvailabilityGroupListenerLoadBalancerConfiguration(privateIPAddress.Value, publicIPAddressResourceId.Value, loadBalancerResourceId.Value, Optional.ToNullable(probePort), Optional.ToList(sqlVmInstances));
        }
    }
}
