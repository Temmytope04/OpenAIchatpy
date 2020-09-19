// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CookieExpirationConvention.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CookieExpirationConvention
    {
        [EnumMember(Value = "FixedTime")]
        FixedTime,
        [EnumMember(Value = "IdentityProviderDerived")]
        IdentityProviderDerived
    }
    internal static class CookieExpirationConventionEnumExtension
    {
        internal static string ToSerializedValue(this CookieExpirationConvention? value)
        {
            return value == null ? null : ((CookieExpirationConvention)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CookieExpirationConvention value)
        {
            switch( value )
            {
                case CookieExpirationConvention.FixedTime:
                    return "FixedTime";
                case CookieExpirationConvention.IdentityProviderDerived:
                    return "IdentityProviderDerived";
            }
            return null;
        }

        internal static CookieExpirationConvention? ParseCookieExpirationConvention(this string value)
        {
            switch( value )
            {
                case "FixedTime":
                    return CookieExpirationConvention.FixedTime;
                case "IdentityProviderDerived":
                    return CookieExpirationConvention.IdentityProviderDerived;
            }
            return null;
        }
    }
}
