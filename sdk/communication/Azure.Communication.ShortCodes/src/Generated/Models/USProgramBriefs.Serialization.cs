// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    internal partial class USProgramBriefs
    {
        internal static USProgramBriefs DeserializeUSProgramBriefs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<USProgramBrief> programBriefs = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("programBriefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<USProgramBrief> array = new List<USProgramBrief>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(USProgramBrief.DeserializeUSProgramBrief(item));
                    }
                    programBriefs = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new USProgramBriefs(programBriefs ?? new ChangeTrackingList<USProgramBrief>(), nextLink);
        }
    }
}
