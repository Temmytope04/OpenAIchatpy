// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    internal static partial class ManagementGroupNameUnavailableReasonExtensions
    {
        public static string ToSerialString(this ManagementGroupNameUnavailableReason value) => value switch
        {
            ManagementGroupNameUnavailableReason.Invalid => "Invalid",
            ManagementGroupNameUnavailableReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagementGroupNameUnavailableReason value.")
        };

        public static ManagementGroupNameUnavailableReason ToManagementGroupNameUnavailableReason(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Invalid")) return ManagementGroupNameUnavailableReason.Invalid;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AlreadyExists")) return ManagementGroupNameUnavailableReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ManagementGroupNameUnavailableReason value.");
        }
    }
}
