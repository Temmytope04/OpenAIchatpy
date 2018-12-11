// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VisualFeatureTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VisualFeatureTypes
    {
        [EnumMember(Value = "ImageType")]
        ImageType,
        [EnumMember(Value = "Faces")]
        Faces,
        [EnumMember(Value = "Adult")]
        Adult,
        [EnumMember(Value = "Categories")]
        Categories,
        [EnumMember(Value = "Color")]
        Color,
        [EnumMember(Value = "Tags")]
        Tags,
        [EnumMember(Value = "Description")]
        Description,
        [EnumMember(Value = "Objects")]
        Objects
    }
    internal static class VisualFeatureTypesEnumExtension
    {
        internal static string ToSerializedValue(this VisualFeatureTypes? value)
        {
            return value == null ? null : ((VisualFeatureTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VisualFeatureTypes value)
        {
            switch( value )
            {
                case VisualFeatureTypes.ImageType:
                    return "ImageType";
                case VisualFeatureTypes.Faces:
                    return "Faces";
                case VisualFeatureTypes.Adult:
                    return "Adult";
                case VisualFeatureTypes.Categories:
                    return "Categories";
                case VisualFeatureTypes.Color:
                    return "Color";
                case VisualFeatureTypes.Tags:
                    return "Tags";
                case VisualFeatureTypes.Description:
                    return "Description";
                case VisualFeatureTypes.Objects:
                    return "Objects";
            }
            return null;
        }

        internal static VisualFeatureTypes? ParseVisualFeatureTypes(this string value)
        {
            switch( value )
            {
                case "ImageType":
                    return VisualFeatureTypes.ImageType;
                case "Faces":
                    return VisualFeatureTypes.Faces;
                case "Adult":
                    return VisualFeatureTypes.Adult;
                case "Categories":
                    return VisualFeatureTypes.Categories;
                case "Color":
                    return VisualFeatureTypes.Color;
                case "Tags":
                    return VisualFeatureTypes.Tags;
                case "Description":
                    return VisualFeatureTypes.Description;
                case "Objects":
                    return VisualFeatureTypes.Objects;
            }
            return null;
        }
    }
}
