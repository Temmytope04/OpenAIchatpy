// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for H264Complexity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum H264Complexity
    {
        /// <summary>
        /// Tells the encoder to use settings that are optimized for faster
        /// encoding. Quality is sacrificed to decrease encoding time.
        /// </summary>
        [EnumMember(Value = "Speed")]
        Speed,
        /// <summary>
        /// Tells the encoder to use settings that achieve a balance between
        /// speed and quality.
        /// </summary>
        [EnumMember(Value = "Balanced")]
        Balanced,
        /// <summary>
        /// Tells the encoder to use settings that are optimized to produce
        /// higher quality output at the expense of slower overall encode time.
        /// </summary>
        [EnumMember(Value = "Quality")]
        Quality
    }
    internal static class H264ComplexityEnumExtension
    {
        internal static string ToSerializedValue(this H264Complexity? value)
        {
            return value == null ? null : ((H264Complexity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this H264Complexity value)
        {
            switch( value )
            {
                case H264Complexity.Speed:
                    return "Speed";
                case H264Complexity.Balanced:
                    return "Balanced";
                case H264Complexity.Quality:
                    return "Quality";
            }
            return null;
        }

        internal static H264Complexity? ParseH264Complexity(this string value)
        {
            switch( value )
            {
                case "Speed":
                    return H264Complexity.Speed;
                case "Balanced":
                    return H264Complexity.Balanced;
                case "Quality":
                    return H264Complexity.Quality;
            }
            return null;
        }
    }
}
