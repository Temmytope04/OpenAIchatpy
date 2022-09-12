// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Route.Models
{
    public partial class RouteGuidance
    {
        internal static RouteGuidance DeserializeRouteGuidance(JsonElement element)
        {
            Optional<IReadOnlyList<RouteInstruction>> instructions = default;
            Optional<IReadOnlyList<RouteInstructionGroup>> instructionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instructions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("instructionGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
            return new RouteGuidance(Optional.ToList(instructions), Optional.ToList(instructionGroups));
        }
    }
}
