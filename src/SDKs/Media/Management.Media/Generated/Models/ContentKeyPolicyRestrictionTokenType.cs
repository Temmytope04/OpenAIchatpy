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
    /// Defines values for ContentKeyPolicyRestrictionTokenType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentKeyPolicyRestrictionTokenType
    {
        /// <summary>
        /// Represents a ContentKeyPolicyRestrictionTokenType that is
        /// unavailable in current API version.
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        /// <summary>
        /// Simple Web Token.
        /// </summary>
        [EnumMember(Value = "Swt")]
        Swt,
        /// <summary>
        /// JSON Web Token.
        /// </summary>
        [EnumMember(Value = "Jwt")]
        Jwt
    }
    internal static class ContentKeyPolicyRestrictionTokenTypeEnumExtension
    {
        internal static string ToSerializedValue(this ContentKeyPolicyRestrictionTokenType? value)
        {
            return value == null ? null : ((ContentKeyPolicyRestrictionTokenType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ContentKeyPolicyRestrictionTokenType value)
        {
            switch( value )
            {
                case ContentKeyPolicyRestrictionTokenType.Unknown:
                    return "Unknown";
                case ContentKeyPolicyRestrictionTokenType.Swt:
                    return "Swt";
                case ContentKeyPolicyRestrictionTokenType.Jwt:
                    return "Jwt";
            }
            return null;
        }

        internal static ContentKeyPolicyRestrictionTokenType? ParseContentKeyPolicyRestrictionTokenType(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return ContentKeyPolicyRestrictionTokenType.Unknown;
                case "Swt":
                    return ContentKeyPolicyRestrictionTokenType.Swt;
                case "Jwt":
                    return ContentKeyPolicyRestrictionTokenType.Jwt;
            }
            return null;
        }
    }
}
