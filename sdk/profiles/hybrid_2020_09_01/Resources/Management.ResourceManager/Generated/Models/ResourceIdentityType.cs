// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.ResourceManager.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResourceIdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceIdentityType
    {
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        [EnumMember(Value = "UserAssigned")]
        UserAssigned,
        [EnumMember(Value = "SystemAssigned, UserAssigned")]
        SystemAssignedUserAssigned,
        [EnumMember(Value = "None")]
        None
    }
    internal static class ResourceIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResourceIdentityType? value)
        {
            return value == null ? null : ((ResourceIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResourceIdentityType value)
        {
            switch( value )
            {
                case ResourceIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ResourceIdentityType.UserAssigned:
                    return "UserAssigned";
                case ResourceIdentityType.SystemAssignedUserAssigned:
                    return "SystemAssigned, UserAssigned";
                case ResourceIdentityType.None:
                    return "None";
            }
            return null;
        }

        internal static ResourceIdentityType? ParseResourceIdentityType(this string value)
        {
            switch( value )
            {
                case "SystemAssigned":
                    return ResourceIdentityType.SystemAssigned;
                case "UserAssigned":
                    return ResourceIdentityType.UserAssigned;
                case "SystemAssigned, UserAssigned":
                    return ResourceIdentityType.SystemAssignedUserAssigned;
                case "None":
                    return ResourceIdentityType.None;
            }
            return null;
        }
    }
}
