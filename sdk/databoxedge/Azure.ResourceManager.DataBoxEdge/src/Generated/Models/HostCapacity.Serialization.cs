// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class HostCapacity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(EffectiveAvailableMemoryInMBOnHost))
            {
                writer.WritePropertyName("effectiveAvailableMemoryMbOnHost");
                writer.WriteNumberValue(EffectiveAvailableMemoryInMBOnHost.Value);
            }
            if (Optional.IsDefined(AvailableGpuCount))
            {
                writer.WritePropertyName("availableGpuCount");
                writer.WriteNumberValue(AvailableGpuCount.Value);
            }
            if (Optional.IsCollectionDefined(VmUsedMemory))
            {
                writer.WritePropertyName("vmUsedMemory");
                writer.WriteStartObject();
                foreach (var item in VmUsedMemory)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(GpuType))
            {
                writer.WritePropertyName("gpuType");
                writer.WriteStringValue(GpuType);
            }
            if (Optional.IsCollectionDefined(NumaNodesData))
            {
                writer.WritePropertyName("numaNodesData");
                writer.WriteStartArray();
                foreach (var item in NumaNodesData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static HostCapacity DeserializeHostCapacity(JsonElement element)
        {
            Optional<string> hostName = default;
            Optional<long> effectiveAvailableMemoryMbOnHost = default;
            Optional<int> availableGpuCount = default;
            Optional<IDictionary<string, DataBoxEdgeVmMemory>> vmUsedMemory = default;
            Optional<string> gpuType = default;
            Optional<IList<NumaNodeInfo>> numaNodesData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveAvailableMemoryMbOnHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    effectiveAvailableMemoryMbOnHost = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableGpuCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableGpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmUsedMemory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, DataBoxEdgeVmMemory> dictionary = new Dictionary<string, DataBoxEdgeVmMemory>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DataBoxEdgeVmMemory.DeserializeDataBoxEdgeVmMemory(property0.Value));
                    }
                    vmUsedMemory = dictionary;
                    continue;
                }
                if (property.NameEquals("gpuType"))
                {
                    gpuType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numaNodesData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NumaNodeInfo> array = new List<NumaNodeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NumaNodeInfo.DeserializeNumaNodeInfo(item));
                    }
                    numaNodesData = array;
                    continue;
                }
            }
            return new HostCapacity(hostName.Value, Optional.ToNullable(effectiveAvailableMemoryMbOnHost), Optional.ToNullable(availableGpuCount), Optional.ToDictionary(vmUsedMemory), gpuType.Value, Optional.ToList(numaNodesData));
        }
    }
}
