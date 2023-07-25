// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class SubscriptionStateExtensions
    {
        public static string ToSerialString(this SubscriptionState value) => value switch
        {
            SubscriptionState.Enabled => "Enabled",
            SubscriptionState.Warned => "Warned",
            SubscriptionState.PastDue => "PastDue",
            SubscriptionState.Disabled => "Disabled",
            SubscriptionState.Deleted => "Deleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubscriptionState value.")
        };

        public static SubscriptionState ToSubscriptionState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Enabled")) return SubscriptionState.Enabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Warned")) return SubscriptionState.Warned;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PastDue")) return SubscriptionState.PastDue;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Disabled")) return SubscriptionState.Disabled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Deleted")) return SubscriptionState.Deleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubscriptionState value.");
        }
    }
}
