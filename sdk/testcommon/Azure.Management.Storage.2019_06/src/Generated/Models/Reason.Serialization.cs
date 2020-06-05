// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    internal static class ReasonExtensions
    {
        public static string ToSerialString(this Reason value) => value switch
        {
            Reason.AccountNameInvalid => "AccountNameInvalid",
            Reason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Reason value.")
        };

        public static Reason ToReason(this string value)
        {
            if (string.Equals(value, "AccountNameInvalid", StringComparison.InvariantCultureIgnoreCase)) return Reason.AccountNameInvalid;
            if (string.Equals(value, "AlreadyExists", StringComparison.InvariantCultureIgnoreCase)) return Reason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Reason value.");
        }
    }
}
