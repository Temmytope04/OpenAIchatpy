// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchDiskCachingTypeExtensions
    {
        public static string ToSerialString(this BatchDiskCachingType value) => value switch
        {
            BatchDiskCachingType.None => "None",
            BatchDiskCachingType.ReadOnly => "ReadOnly",
            BatchDiskCachingType.ReadWrite => "ReadWrite",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskCachingType value.")
        };

        public static BatchDiskCachingType ToBatchDiskCachingType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return BatchDiskCachingType.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadOnly")) return BatchDiskCachingType.ReadOnly;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWrite")) return BatchDiskCachingType.ReadWrite;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchDiskCachingType value.");
        }
    }
}
