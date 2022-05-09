// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class VaultCreateModeExtensions
    {
        public static string ToSerialString(this VaultCreateMode value) => value switch
        {
            VaultCreateMode.Default => "default",
            VaultCreateMode.Recover => "recover",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VaultCreateMode value.")
        };

        public static VaultCreateMode ToVaultCreateMode(this string value)
        {
            if (string.Equals(value, "default", StringComparison.InvariantCultureIgnoreCase)) return VaultCreateMode.Default;
            if (string.Equals(value, "recover", StringComparison.InvariantCultureIgnoreCase)) return VaultCreateMode.Recover;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VaultCreateMode value.");
        }
    }
}
