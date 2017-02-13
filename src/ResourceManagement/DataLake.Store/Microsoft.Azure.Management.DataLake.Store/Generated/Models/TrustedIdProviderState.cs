// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TrustedIdProviderState.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TrustedIdProviderState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
}


