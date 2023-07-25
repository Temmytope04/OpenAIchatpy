// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridData.Models
{
    internal static partial class SupportedEncryptionAlgorithmExtensions
    {
        public static string ToSerialString(this SupportedEncryptionAlgorithm value) => value switch
        {
            SupportedEncryptionAlgorithm.None => "None",
            SupportedEncryptionAlgorithm.Rsa1_5 => "RSA1_5",
            SupportedEncryptionAlgorithm.Rsa_Oaep => "RSA_OAEP",
            SupportedEncryptionAlgorithm.PlainText => "PlainText",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SupportedEncryptionAlgorithm value.")
        };

        public static SupportedEncryptionAlgorithm ToSupportedEncryptionAlgorithm(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return SupportedEncryptionAlgorithm.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RSA1_5")) return SupportedEncryptionAlgorithm.Rsa1_5;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RSA_OAEP")) return SupportedEncryptionAlgorithm.Rsa_Oaep;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PlainText")) return SupportedEncryptionAlgorithm.PlainText;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SupportedEncryptionAlgorithm value.");
        }
    }
}
