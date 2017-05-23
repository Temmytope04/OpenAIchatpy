// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.DocumentDB.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.DocumentDB;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DefaultConsistencyLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultConsistencyLevel
    {
        [EnumMember(Value = "Eventual")]
        Eventual,
        [EnumMember(Value = "Session")]
        Session,
        [EnumMember(Value = "BoundedStaleness")]
        BoundedStaleness,
        [EnumMember(Value = "Strong")]
        Strong,
        [EnumMember(Value = "ConsistentPrefix")]
        ConsistentPrefix
    }
}
