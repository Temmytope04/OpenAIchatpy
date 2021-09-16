// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UnauthenticatedClientAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnauthenticatedClientAction
    {
        [EnumMember(Value = "RedirectToLoginPage")]
        RedirectToLoginPage,
        [EnumMember(Value = "AllowAnonymous")]
        AllowAnonymous
    }
    internal static class UnauthenticatedClientActionEnumExtension
    {
        internal static string ToSerializedValue(this UnauthenticatedClientAction? value)
        {
            return value == null ? null : ((UnauthenticatedClientAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UnauthenticatedClientAction value)
        {
            switch( value )
            {
                case UnauthenticatedClientAction.RedirectToLoginPage:
                    return "RedirectToLoginPage";
                case UnauthenticatedClientAction.AllowAnonymous:
                    return "AllowAnonymous";
            }
            return null;
        }

        internal static UnauthenticatedClientAction? ParseUnauthenticatedClientAction(this string value)
        {
            switch( value )
            {
                case "RedirectToLoginPage":
                    return UnauthenticatedClientAction.RedirectToLoginPage;
                case "AllowAnonymous":
                    return UnauthenticatedClientAction.AllowAnonymous;
            }
            return null;
        }
    }
}
