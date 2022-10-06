// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class AppServiceDomainStatusExtensions
    {
        public static string ToSerialString(this AppServiceDomainStatus value) => value switch
        {
            AppServiceDomainStatus.Unknown => "Unknown",
            AppServiceDomainStatus.Active => "Active",
            AppServiceDomainStatus.Awaiting => "Awaiting",
            AppServiceDomainStatus.Cancelled => "Cancelled",
            AppServiceDomainStatus.Confiscated => "Confiscated",
            AppServiceDomainStatus.Disabled => "Disabled",
            AppServiceDomainStatus.Excluded => "Excluded",
            AppServiceDomainStatus.Expired => "Expired",
            AppServiceDomainStatus.Failed => "Failed",
            AppServiceDomainStatus.Held => "Held",
            AppServiceDomainStatus.Locked => "Locked",
            AppServiceDomainStatus.Parked => "Parked",
            AppServiceDomainStatus.Pending => "Pending",
            AppServiceDomainStatus.Reserved => "Reserved",
            AppServiceDomainStatus.Reverted => "Reverted",
            AppServiceDomainStatus.Suspended => "Suspended",
            AppServiceDomainStatus.Transferred => "Transferred",
            AppServiceDomainStatus.Unlocked => "Unlocked",
            AppServiceDomainStatus.Unparked => "Unparked",
            AppServiceDomainStatus.Updated => "Updated",
            AppServiceDomainStatus.JsonConverterFailed => "JsonConverterFailed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceDomainStatus value.")
        };

        public static AppServiceDomainStatus ToAppServiceDomainStatus(this string value)
        {
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Unknown;
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Active;
            if (string.Equals(value, "Awaiting", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Awaiting;
            if (string.Equals(value, "Cancelled", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Cancelled;
            if (string.Equals(value, "Confiscated", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Confiscated;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Disabled;
            if (string.Equals(value, "Excluded", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Excluded;
            if (string.Equals(value, "Expired", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Expired;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Failed;
            if (string.Equals(value, "Held", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Held;
            if (string.Equals(value, "Locked", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Locked;
            if (string.Equals(value, "Parked", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Parked;
            if (string.Equals(value, "Pending", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Pending;
            if (string.Equals(value, "Reserved", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Reserved;
            if (string.Equals(value, "Reverted", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Reverted;
            if (string.Equals(value, "Suspended", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Suspended;
            if (string.Equals(value, "Transferred", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Transferred;
            if (string.Equals(value, "Unlocked", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Unlocked;
            if (string.Equals(value, "Unparked", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Unparked;
            if (string.Equals(value, "Updated", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.Updated;
            if (string.Equals(value, "JsonConverterFailed", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainStatus.JsonConverterFailed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceDomainStatus value.");
        }
    }
}
