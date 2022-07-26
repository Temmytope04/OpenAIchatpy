// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class SqlServerJobScheduleTypeExtensions
    {
        public static string ToSerialString(this SqlServerJobScheduleType value) => value switch
        {
            SqlServerJobScheduleType.Once => "Once",
            SqlServerJobScheduleType.Recurring => "Recurring",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SqlServerJobScheduleType value.")
        };

        public static SqlServerJobScheduleType ToSqlServerJobScheduleType(this string value)
        {
            if (string.Equals(value, "Once", StringComparison.InvariantCultureIgnoreCase)) return SqlServerJobScheduleType.Once;
            if (string.Equals(value, "Recurring", StringComparison.InvariantCultureIgnoreCase)) return SqlServerJobScheduleType.Recurring;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SqlServerJobScheduleType value.");
        }
    }
}
