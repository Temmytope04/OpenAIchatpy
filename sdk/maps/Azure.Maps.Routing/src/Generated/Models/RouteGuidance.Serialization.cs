// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteGuidance
    {
        internal static RouteGuidance DeserializeRouteGuidance(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RouteInstruction> instructions = default;
            IReadOnlyList<RouteInstructionGroup> instructionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstruction> array = new List<RouteInstruction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstruction.DeserializeRouteInstruction(item));
                    }
                    instructions = array;
                    continue;
                }
                if (property.NameEquals("instructionGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteInstructionGroup> array = new List<RouteInstructionGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteInstructionGroup.DeserializeRouteInstructionGroup(item));
                    }
                    instructionGroups = array;
                    continue;
                }
            }
            return new RouteGuidance(instructions ?? new ChangeTrackingList<RouteInstruction>(), instructionGroups ?? new ChangeTrackingList<RouteInstructionGroup>());
        }
    }
}
