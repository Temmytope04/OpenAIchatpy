// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    internal static partial class SwapSlotTypeExtensions
    {
        public static string ToSerialString(this SwapSlotType value) => value switch
        {
            SwapSlotType.Production => "Production",
            SwapSlotType.Staging => "Staging",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SwapSlotType value.")
        };

        public static SwapSlotType ToSwapSlotType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Production")) return SwapSlotType.Production;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Staging")) return SwapSlotType.Staging;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SwapSlotType value.");
        }
    }
}
