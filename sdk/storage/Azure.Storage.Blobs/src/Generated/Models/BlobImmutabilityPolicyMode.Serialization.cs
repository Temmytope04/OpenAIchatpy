// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    internal static partial class BlobImmutabilityPolicyModeExtensions
    {
        public static string ToSerialString(this BlobImmutabilityPolicyMode value) => value switch
        {
            BlobImmutabilityPolicyMode.Mutable => "Mutable",
            BlobImmutabilityPolicyMode.Unlocked => "Unlocked",
            BlobImmutabilityPolicyMode.Locked => "Locked",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobImmutabilityPolicyMode value.")
        };

        public static BlobImmutabilityPolicyMode ToBlobImmutabilityPolicyMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Mutable")) return BlobImmutabilityPolicyMode.Mutable;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unlocked")) return BlobImmutabilityPolicyMode.Unlocked;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Locked")) return BlobImmutabilityPolicyMode.Locked;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobImmutabilityPolicyMode value.");
        }
    }
}
