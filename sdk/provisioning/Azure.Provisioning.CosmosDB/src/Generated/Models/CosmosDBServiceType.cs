// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// ServiceType for the service.
/// </summary>
public enum CosmosDBServiceType
{
    /// <summary>
    /// SqlDedicatedGateway.
    /// </summary>
    SqlDedicatedGateway,

    /// <summary>
    /// DataTransfer.
    /// </summary>
    DataTransfer,

    /// <summary>
    /// GraphAPICompute.
    /// </summary>
    [DataMember(Name = "GraphAPICompute")]
    GraphApiCompute,

    /// <summary>
    /// MaterializedViewsBuilder.
    /// </summary>
    MaterializedViewsBuilder,
}
