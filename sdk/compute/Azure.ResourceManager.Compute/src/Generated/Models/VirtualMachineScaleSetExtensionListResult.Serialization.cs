// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetExtensionListResult
    {
        internal static VirtualMachineScaleSetExtensionListResult DeserializeVirtualMachineScaleSetExtensionListResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachineScaleSetExtension> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VirtualMachineScaleSetExtension> array = new List<VirtualMachineScaleSetExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VirtualMachineScaleSetExtension.DeserializeVirtualMachineScaleSetExtension(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineScaleSetExtensionListResult(value, nextLink);
        }
    }
}
