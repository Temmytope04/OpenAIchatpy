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
    /// Defines values for WorkerSizeOptions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkerSizeOptions
    {
        [EnumMember(Value = "Small")]
        Small,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Large")]
        Large,
        [EnumMember(Value = "D1")]
        D1,
        [EnumMember(Value = "D2")]
        D2,
        [EnumMember(Value = "D3")]
        D3,
        [EnumMember(Value = "Default")]
        Default
    }
    internal static class WorkerSizeOptionsEnumExtension
    {
        internal static string ToSerializedValue(this WorkerSizeOptions? value)
        {
            return value == null ? null : ((WorkerSizeOptions)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WorkerSizeOptions value)
        {
            switch( value )
            {
                case WorkerSizeOptions.Small:
                    return "Small";
                case WorkerSizeOptions.Medium:
                    return "Medium";
                case WorkerSizeOptions.Large:
                    return "Large";
                case WorkerSizeOptions.D1:
                    return "D1";
                case WorkerSizeOptions.D2:
                    return "D2";
                case WorkerSizeOptions.D3:
                    return "D3";
                case WorkerSizeOptions.Default:
                    return "Default";
            }
            return null;
        }

        internal static WorkerSizeOptions? ParseWorkerSizeOptions(this string value)
        {
            switch( value )
            {
                case "Small":
                    return WorkerSizeOptions.Small;
                case "Medium":
                    return WorkerSizeOptions.Medium;
                case "Large":
                    return WorkerSizeOptions.Large;
                case "D1":
                    return WorkerSizeOptions.D1;
                case "D2":
                    return WorkerSizeOptions.D2;
                case "D3":
                    return WorkerSizeOptions.D3;
                case "Default":
                    return WorkerSizeOptions.Default;
            }
            return null;
        }
    }
}
