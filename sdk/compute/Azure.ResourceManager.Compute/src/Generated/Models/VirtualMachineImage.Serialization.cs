// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Tags != null)
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
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Plan != null)
            {
                writer.WritePropertyName("plan");
                writer.WriteObjectValue(Plan);
            }
            if (OsDiskImage != null)
            {
                writer.WritePropertyName("osDiskImage");
                writer.WriteObjectValue(OsDiskImage);
            }
            if (DataDiskImages != null)
            {
                writer.WritePropertyName("dataDiskImages");
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AutomaticOSUpgradeProperties != null)
            {
                writer.WritePropertyName("automaticOSUpgradeProperties");
                writer.WriteObjectValue(AutomaticOSUpgradeProperties);
            }
            if (HyperVGeneration != null)
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineImage DeserializeVirtualMachineImage(JsonElement element)
        {
            string name = default;
            string location = default;
            IDictionary<string, string> tags = default;
            string id = default;
            PurchasePlan plan = default;
            OSDiskImage osDiskImage = default;
            IList<DataDiskImage> dataDiskImages = default;
            AutomaticOSUpgradeProperties automaticOSUpgradeProperties = default;
            HyperVGenerationTypes? hyperVGeneration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("plan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            plan = PurchasePlan.DeserializePurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osDiskImage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osDiskImage = OSDiskImage.DeserializeOSDiskImage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataDiskImages"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataDiskImage> array = new List<DataDiskImage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(DataDiskImage.DeserializeDataDiskImage(item));
                                }
                            }
                            dataDiskImages = array;
                            continue;
                        }
                        if (property0.NameEquals("automaticOSUpgradeProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticOSUpgradeProperties = AutomaticOSUpgradeProperties.DeserializeAutomaticOSUpgradeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGenerationTypes(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineImage(id, name, location, tags, plan, osDiskImage, dataDiskImages, automaticOSUpgradeProperties, hyperVGeneration);
        }
    }
}
