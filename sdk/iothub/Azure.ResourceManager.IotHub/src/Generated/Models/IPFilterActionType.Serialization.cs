// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    internal static partial class IPFilterActionTypeExtensions
    {
        public static string ToSerialString(this IPFilterActionType value) => value switch
        {
            IPFilterActionType.Accept => "Accept",
            IPFilterActionType.Reject => "Reject",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPFilterActionType value.")
        };

        public static IPFilterActionType ToIPFilterActionType(this string value)
        {
            if (string.Equals(value, "Accept", StringComparison.InvariantCultureIgnoreCase)) return IPFilterActionType.Accept;
            if (string.Equals(value, "Reject", StringComparison.InvariantCultureIgnoreCase)) return IPFilterActionType.Reject;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPFilterActionType value.");
        }
    }
}
