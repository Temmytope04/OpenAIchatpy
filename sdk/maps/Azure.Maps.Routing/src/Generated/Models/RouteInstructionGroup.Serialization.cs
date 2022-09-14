// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteInstructionGroup
    {
        internal static RouteInstructionGroup DeserializeRouteInstructionGroup(JsonElement element)
        {
            Optional<int> firstInstructionIndex = default;
            Optional<int> lastInstructionIndex = default;
            Optional<int> groupLengthInMeters = default;
            Optional<string> groupMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstInstructionIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    firstInstructionIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastInstructionIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastInstructionIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("groupLengthInMeters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    groupLengthInMeters = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("groupMessage"))
                {
                    groupMessage = property.Value.GetString();
                    continue;
                }
            }
            return new RouteInstructionGroup(Optional.ToNullable(firstInstructionIndex), Optional.ToNullable(lastInstructionIndex), Optional.ToNullable(groupLengthInMeters), groupMessage.Value);
        }
    }
}
