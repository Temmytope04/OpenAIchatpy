// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RegistrationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistrationState
    {
        /// <summary>
        /// User has not yet registered with the lab.
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered,
        /// <summary>
        /// User has registered with the lab.
        /// </summary>
        [EnumMember(Value = "NotRegistered")]
        NotRegistered
    }
    internal static class RegistrationStateEnumExtension
    {
        internal static string ToSerializedValue(this RegistrationState? value)
        {
            return value == null ? null : ((RegistrationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RegistrationState value)
        {
            switch( value )
            {
                case RegistrationState.Registered:
                    return "Registered";
                case RegistrationState.NotRegistered:
                    return "NotRegistered";
            }
            return null;
        }

        internal static RegistrationState? ParseRegistrationState(this string value)
        {
            switch( value )
            {
                case "Registered":
                    return RegistrationState.Registered;
                case "NotRegistered":
                    return RegistrationState.NotRegistered;
            }
            return null;
        }
    }
}
