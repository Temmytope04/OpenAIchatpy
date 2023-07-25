// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    internal partial class VirtualMachineTemplateListResult
    {
        internal static VirtualMachineTemplateListResult DeserializeVirtualMachineTemplateListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ScVmmVirtualMachineTemplateData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScVmmVirtualMachineTemplateData> array = new List<ScVmmVirtualMachineTemplateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScVmmVirtualMachineTemplateData.DeserializeScVmmVirtualMachineTemplateData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineTemplateListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
