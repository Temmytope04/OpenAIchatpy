// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// The PostgreSqlServerPrivateLinkServiceConnectionStateProperty.
/// </summary>
public partial class PostgreSqlServerPrivateLinkServiceConnectionStateProperty : ProvisionableConstruct
{
    /// <summary>
    /// The private link service connection status.
    /// </summary>
    public BicepValue<PostgreSqlPrivateLinkServiceConnectionStateStatus> Status { get => _status; }
    private readonly BicepValue<PostgreSqlPrivateLinkServiceConnectionStateStatus> _status;

    /// <summary>
    /// The private link service connection description.
    /// </summary>
    public BicepValue<string> Description { get => _description; }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// The actions required for private link service connection.
    /// </summary>
    public BicepValue<PostgreSqlPrivateLinkServiceConnectionStateRequiredAction> ActionsRequired { get => _actionsRequired; }
    private readonly BicepValue<PostgreSqlPrivateLinkServiceConnectionStateRequiredAction> _actionsRequired;

    /// <summary>
    /// Creates a new PostgreSqlServerPrivateLinkServiceConnectionStateProperty.
    /// </summary>
    public PostgreSqlServerPrivateLinkServiceConnectionStateProperty()
    {
        _status = BicepValue<PostgreSqlPrivateLinkServiceConnectionStateStatus>.DefineProperty(this, "Status", ["status"], isOutput: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"], isOutput: true);
        _actionsRequired = BicepValue<PostgreSqlPrivateLinkServiceConnectionStateRequiredAction>.DefineProperty(this, "ActionsRequired", ["actionsRequired"], isOutput: true);
    }
}
