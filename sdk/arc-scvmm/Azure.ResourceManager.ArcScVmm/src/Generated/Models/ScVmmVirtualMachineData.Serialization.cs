// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    public partial class ScVmmVirtualMachineData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            JsonSerializer.Serialize(writer, ExtendedLocation); if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (Optional.IsDefined(VmmServerId))
            {
                writer.WritePropertyName("vmmServerId"u8);
                writer.WriteStringValue(VmmServerId);
            }
            if (Optional.IsDefined(CloudId))
            {
                writer.WritePropertyName("cloudId"u8);
                writer.WriteStringValue(CloudId);
            }
            if (Optional.IsDefined(TemplateId))
            {
                writer.WritePropertyName("templateId"u8);
                writer.WriteStringValue(TemplateId);
            }
            if (Optional.IsDefined(CheckpointType))
            {
                writer.WritePropertyName("checkpointType"u8);
                writer.WriteStringValue(CheckpointType);
            }
            if (Optional.IsCollectionDefined(Checkpoints))
            {
                writer.WritePropertyName("checkpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Checkpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AvailabilitySets))
            {
                writer.WritePropertyName("availabilitySets"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilitySets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(Generation))
            {
                writer.WritePropertyName("generation"u8);
                writer.WriteNumberValue(Generation.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScVmmVirtualMachineData DeserializeScVmmVirtualMachineData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> inventoryItemId = default;
            Optional<string> vmmServerId = default;
            Optional<string> cloudId = default;
            Optional<string> templateId = default;
            Optional<string> checkpointType = default;
            Optional<IList<Checkpoint>> checkpoints = default;
            Optional<IList<AvailabilitySetListItem>> availabilitySets = default;
            Optional<OSProfile> osProfile = default;
            Optional<HardwareProfile> hardwareProfile = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<StorageProfile> storageProfile = default;
            Optional<string> vmName = default;
            Optional<string> uuid = default;
            Optional<int> generation = default;
            Optional<string> powerState = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("inventoryItemId"u8))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmmServerId"u8))
                        {
                            vmmServerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudId"u8))
                        {
                            cloudId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateId"u8))
                        {
                            templateId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("checkpointType"u8))
                        {
                            checkpointType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("checkpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Checkpoint> array = new List<Checkpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Checkpoint.DeserializeCheckpoint(item));
                            }
                            checkpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilitySets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AvailabilitySetListItem> array = new List<AvailabilitySetListItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AvailabilitySetListItem.DeserializeAvailabilitySetListItem(item));
                            }
                            availabilitySets = array;
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = OSProfile.DeserializeOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hardwareProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareProfile = HardwareProfile.DeserializeHardwareProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = StorageProfile.DeserializeStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmName"u8))
                        {
                            vmName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("generation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            generation = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            powerState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScVmmVirtualMachineData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, inventoryItemId.Value, vmmServerId.Value, cloudId.Value, templateId.Value, checkpointType.Value, Optional.ToList(checkpoints), Optional.ToList(availabilitySets), osProfile.Value, hardwareProfile.Value, networkProfile.Value, storageProfile.Value, vmName.Value, uuid.Value, Optional.ToNullable(generation), powerState.Value, provisioningState.Value);
        }
    }
}
