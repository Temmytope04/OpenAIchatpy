// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResourceSkuCapacityScaleType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceSkuCapacityScaleType
    {
        [EnumMember(Value = "Automatic")]
        Automatic,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "None")]
        None
    }
    internal static class ResourceSkuCapacityScaleTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResourceSkuCapacityScaleType? value)  =>
            value == null ? null : ((ResourceSkuCapacityScaleType)value).ToSerializedValue();

        internal static string ToSerializedValue(this ResourceSkuCapacityScaleType value)
        {
            switch( value )
            {
                case ResourceSkuCapacityScaleType.Automatic:
                    return "Automatic";
                case ResourceSkuCapacityScaleType.Manual:
                    return "Manual";
                case ResourceSkuCapacityScaleType.None:
                    return "None";
            }
            return null;
        }

        internal static ResourceSkuCapacityScaleType? ParseResourceSkuCapacityScaleType(this string value)
        {
            switch( value )
            {
                case "Automatic":
                    return ResourceSkuCapacityScaleType.Automatic;
                case "Manual":
                    return ResourceSkuCapacityScaleType.Manual;
                case "None":
                    return ResourceSkuCapacityScaleType.None;
            }
            return null;
        }
    }
}
