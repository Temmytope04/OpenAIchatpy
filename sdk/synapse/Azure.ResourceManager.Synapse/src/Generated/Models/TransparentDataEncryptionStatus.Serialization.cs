// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class TransparentDataEncryptionStatusExtensions
    {
        public static string ToSerialString(this TransparentDataEncryptionStatus value) => value switch
        {
            TransparentDataEncryptionStatus.Enabled => "Enabled",
            TransparentDataEncryptionStatus.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TransparentDataEncryptionStatus value.")
        };

        public static TransparentDataEncryptionStatus ToTransparentDataEncryptionStatus(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return TransparentDataEncryptionStatus.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return TransparentDataEncryptionStatus.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TransparentDataEncryptionStatus value.");
        }
    }
}
