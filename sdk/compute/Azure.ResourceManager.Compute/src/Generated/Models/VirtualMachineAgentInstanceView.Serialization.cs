// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineAgentInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (VmAgentVersion != null)
            {
                writer.WritePropertyName("vmAgentVersion");
                writer.WriteStringValue(VmAgentVersion);
            }
            if (ExtensionHandlers != null)
            {
                writer.WritePropertyName("extensionHandlers");
                writer.WriteStartArray();
                foreach (var item in ExtensionHandlers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Statuses != null)
            {
                writer.WritePropertyName("statuses");
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineAgentInstanceView DeserializeVirtualMachineAgentInstanceView(JsonElement element)
        {
            string vmAgentVersion = default;
            IList<VirtualMachineExtensionHandlerInstanceView> extensionHandlers = default;
            IList<InstanceViewStatus> statuses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmAgentVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionHandlers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineExtensionHandlerInstanceView> array = new List<VirtualMachineExtensionHandlerInstanceView>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineExtensionHandlerInstanceView.DeserializeVirtualMachineExtensionHandlerInstanceView(item));
                        }
                    }
                    extensionHandlers = array;
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                        }
                    }
                    statuses = array;
                    continue;
                }
            }
            return new VirtualMachineAgentInstanceView(vmAgentVersion, extensionHandlers, statuses);
        }
    }
}
