// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB SQL storedProcedure resource object.
/// </summary>
public partial class CosmosDBSqlStoredProcedureResourceInfo : ProvisioningConstruct
{
    /// <summary>
    /// Name of the Cosmos DB SQL storedProcedure.
    /// </summary>
    public BicepValue<string> StoredProcedureName { get => _storedProcedureName; set => _storedProcedureName.Assign(value); }
    private readonly BicepValue<string> _storedProcedureName;

    /// <summary>
    /// Body of the Stored Procedure.
    /// </summary>
    public BicepValue<string> Body { get => _body; set => _body.Assign(value); }
    private readonly BicepValue<string> _body;

    /// <summary>
    /// Creates a new CosmosDBSqlStoredProcedureResourceInfo.
    /// </summary>
    public CosmosDBSqlStoredProcedureResourceInfo()
    {
        _storedProcedureName = BicepValue<string>.DefineProperty(this, "StoredProcedureName", ["id"]);
        _body = BicepValue<string>.DefineProperty(this, "Body", ["body"]);
    }
}
