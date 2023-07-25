// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class RecommendedSensitivityLabelUpdateKindExtensions
    {
        public static string ToSerialString(this RecommendedSensitivityLabelUpdateKind value) => value switch
        {
            RecommendedSensitivityLabelUpdateKind.Enable => "enable",
            RecommendedSensitivityLabelUpdateKind.Disable => "disable",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecommendedSensitivityLabelUpdateKind value.")
        };

        public static RecommendedSensitivityLabelUpdateKind ToRecommendedSensitivityLabelUpdateKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "enable")) return RecommendedSensitivityLabelUpdateKind.Enable;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "disable")) return RecommendedSensitivityLabelUpdateKind.Disable;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecommendedSensitivityLabelUpdateKind value.");
        }
    }
}
