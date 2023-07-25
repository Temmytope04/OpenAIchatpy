// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal static partial class HealthcareApisKindExtensions
    {
        public static string ToSerialString(this HealthcareApisKind value) => value switch
        {
            HealthcareApisKind.Fhir => "fhir",
            HealthcareApisKind.FhirStu3 => "fhir-Stu3",
            HealthcareApisKind.FhirR4 => "fhir-R4",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HealthcareApisKind value.")
        };

        public static HealthcareApisKind ToHealthcareApisKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fhir")) return HealthcareApisKind.Fhir;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fhir-Stu3")) return HealthcareApisKind.FhirStu3;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "fhir-R4")) return HealthcareApisKind.FhirR4;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HealthcareApisKind value.");
        }
    }
}
