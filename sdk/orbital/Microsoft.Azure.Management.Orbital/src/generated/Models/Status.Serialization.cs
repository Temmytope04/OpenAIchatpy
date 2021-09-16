// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AzureOrbital.Models
{
    internal static partial class StatusExtensions
    {
        public static string ToSerialString(this Status value) => value switch
        {
            Status.Scheduled => "scheduled",
            Status.Cancelled => "cancelled",
            Status.Succeeded => "succeeded",
            Status.Failed => "failed",
            Status.ProviderCancelled => "providerCancelled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Status value.")
        };

        public static Status ToStatus(this string value)
        {
            if (string.Equals(value, "scheduled", StringComparison.InvariantCultureIgnoreCase)) return Status.Scheduled;
            if (string.Equals(value, "cancelled", StringComparison.InvariantCultureIgnoreCase)) return Status.Cancelled;
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return Status.Succeeded;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return Status.Failed;
            if (string.Equals(value, "providerCancelled", StringComparison.InvariantCultureIgnoreCase)) return Status.ProviderCancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Status value.");
        }
    }
}
