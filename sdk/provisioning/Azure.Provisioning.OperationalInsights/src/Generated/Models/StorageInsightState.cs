// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The state of the storage insight connection to the workspace.
/// </summary>
public enum StorageInsightState
{
    /// <summary>
    /// OK.
    /// </summary>
    OK,

    /// <summary>
    /// ERROR.
    /// </summary>
    [DataMember(Name = "ERROR")]
    Error,
}
