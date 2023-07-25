// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Document
{
    internal static partial class StorageInputUriKindExtensions
    {
        public static string ToSerialString(this StorageInputUriKind value) => value switch
        {
            StorageInputUriKind.Folder => "Folder",
            StorageInputUriKind.File => "File",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageInputUriKind value.")
        };

        public static StorageInputUriKind ToStorageInputUriKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Folder")) return StorageInputUriKind.Folder;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "File")) return StorageInputUriKind.File;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageInputUriKind value.");
        }
    }
}
