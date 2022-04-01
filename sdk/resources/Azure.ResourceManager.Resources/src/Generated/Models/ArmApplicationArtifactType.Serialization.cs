// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources.Models
{
    internal static partial class ArmApplicationArtifactTypeExtensions
    {
        public static string ToSerialString(this ArmApplicationArtifactType value) => value switch
        {
            ArmApplicationArtifactType.NotSpecified => "NotSpecified",
            ArmApplicationArtifactType.Template => "Template",
            ArmApplicationArtifactType.Custom => "Custom",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmApplicationArtifactType value.")
        };

        public static ArmApplicationArtifactType ToArmApplicationArtifactType(this string value)
        {
            if (string.Equals(value, "NotSpecified", StringComparison.InvariantCultureIgnoreCase)) return ArmApplicationArtifactType.NotSpecified;
            if (string.Equals(value, "Template", StringComparison.InvariantCultureIgnoreCase)) return ArmApplicationArtifactType.Template;
            if (string.Equals(value, "Custom", StringComparison.InvariantCultureIgnoreCase)) return ArmApplicationArtifactType.Custom;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ArmApplicationArtifactType value.");
        }
    }
}
