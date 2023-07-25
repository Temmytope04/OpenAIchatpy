// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class AppServiceUsageStateExtensions
    {
        public static string ToSerialString(this AppServiceUsageState value) => value switch
        {
            AppServiceUsageState.Normal => "Normal",
            AppServiceUsageState.Exceeded => "Exceeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceUsageState value.")
        };

        public static AppServiceUsageState ToAppServiceUsageState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Normal")) return AppServiceUsageState.Normal;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Exceeded")) return AppServiceUsageState.Exceeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceUsageState value.");
        }
    }
}
