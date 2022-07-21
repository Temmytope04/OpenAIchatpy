// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class SqlAdvisorStatusExtensions
    {
        public static string ToSerialString(this SqlAdvisorStatus value) => value switch
        {
            SqlAdvisorStatus.GA => "GA",
            SqlAdvisorStatus.PublicPreview => "PublicPreview",
            SqlAdvisorStatus.LimitedPublicPreview => "LimitedPublicPreview",
            SqlAdvisorStatus.PrivatePreview => "PrivatePreview",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SqlAdvisorStatus value.")
        };

        public static SqlAdvisorStatus ToSqlAdvisorStatus(this string value)
        {
            if (string.Equals(value, "GA", StringComparison.InvariantCultureIgnoreCase)) return SqlAdvisorStatus.GA;
            if (string.Equals(value, "PublicPreview", StringComparison.InvariantCultureIgnoreCase)) return SqlAdvisorStatus.PublicPreview;
            if (string.Equals(value, "LimitedPublicPreview", StringComparison.InvariantCultureIgnoreCase)) return SqlAdvisorStatus.LimitedPublicPreview;
            if (string.Equals(value, "PrivatePreview", StringComparison.InvariantCultureIgnoreCase)) return SqlAdvisorStatus.PrivatePreview;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SqlAdvisorStatus value.");
        }
    }
}
