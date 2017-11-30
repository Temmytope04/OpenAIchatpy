// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExposureLevels.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExposureLevels
    {
        [EnumMember(Value = "UnderExposure")]
        UnderExposure,
        [EnumMember(Value = "GoodExposure")]
        GoodExposure,
        [EnumMember(Value = "OverExposure")]
        OverExposure
    }
    internal static class ExposureLevelsEnumExtension
    {
        internal static string ToSerializedValue(this ExposureLevels? value)
        {
            return value == null ? null : ((ExposureLevels)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ExposureLevels value)
        {
            switch( value )
            {
                case ExposureLevels.UnderExposure:
                    return "UnderExposure";
                case ExposureLevels.GoodExposure:
                    return "GoodExposure";
                case ExposureLevels.OverExposure:
                    return "OverExposure";
            }
            return null;
        }

        internal static ExposureLevels? ParseExposureLevels(this string value)
        {
            switch( value )
            {
                case "UnderExposure":
                    return ExposureLevels.UnderExposure;
                case "GoodExposure":
                    return ExposureLevels.GoodExposure;
                case "OverExposure":
                    return ExposureLevels.OverExposure;
            }
            return null;
        }
    }
}
