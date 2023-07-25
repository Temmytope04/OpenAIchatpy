// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Chaos.Models
{
    internal static partial class SelectorTypeExtensions
    {
        public static string ToSerialString(this SelectorType value) => value switch
        {
            SelectorType.Percent => "Percent",
            SelectorType.Random => "Random",
            SelectorType.Tag => "Tag",
            SelectorType.List => "List",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SelectorType value.")
        };

        public static SelectorType ToSelectorType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Percent")) return SelectorType.Percent;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Random")) return SelectorType.Random;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tag")) return SelectorType.Tag;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "List")) return SelectorType.List;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SelectorType value.");
        }
    }
}
