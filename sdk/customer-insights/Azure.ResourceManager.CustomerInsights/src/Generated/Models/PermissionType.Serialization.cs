// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    internal static partial class PermissionTypeExtensions
    {
        public static string ToSerialString(this PermissionType value) => value switch
        {
            PermissionType.Read => "Read",
            PermissionType.Write => "Write",
            PermissionType.Manage => "Manage",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PermissionType value.")
        };

        public static PermissionType ToPermissionType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Read")) return PermissionType.Read;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Write")) return PermissionType.Write;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Manage")) return PermissionType.Manage;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PermissionType value.");
        }
    }
}
