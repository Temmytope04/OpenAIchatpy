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
    /// Defines values for ContinuousWebJobStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContinuousWebJobStatus
    {
        [EnumMember(Value = "Initializing")]
        Initializing,
        [EnumMember(Value = "Starting")]
        Starting,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "PendingRestart")]
        PendingRestart,
        [EnumMember(Value = "Stopped")]
        Stopped
    }
    internal static class ContinuousWebJobStatusEnumExtension
    {
        internal static string ToSerializedValue(this ContinuousWebJobStatus? value)
        {
            return value == null ? null : ((ContinuousWebJobStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ContinuousWebJobStatus value)
        {
            switch( value )
            {
                case ContinuousWebJobStatus.Initializing:
                    return "Initializing";
                case ContinuousWebJobStatus.Starting:
                    return "Starting";
                case ContinuousWebJobStatus.Running:
                    return "Running";
                case ContinuousWebJobStatus.PendingRestart:
                    return "PendingRestart";
                case ContinuousWebJobStatus.Stopped:
                    return "Stopped";
            }
            return null;
        }

        internal static ContinuousWebJobStatus? ParseContinuousWebJobStatus(this string value)
        {
            switch( value )
            {
                case "Initializing":
                    return ContinuousWebJobStatus.Initializing;
                case "Starting":
                    return ContinuousWebJobStatus.Starting;
                case "Running":
                    return ContinuousWebJobStatus.Running;
                case "PendingRestart":
                    return ContinuousWebJobStatus.PendingRestart;
                case "Stopped":
                    return ContinuousWebJobStatus.Stopped;
            }
            return null;
        }
    }
}
