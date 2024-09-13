// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Pairs of Managed Instances in the failover group.
/// </summary>
public partial class ManagedInstancePairInfo : ProvisioningConstruct
{
    /// <summary>
    /// Id of Primary Managed Instance in pair.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrimaryManagedInstanceId { get => _primaryManagedInstanceId; set => _primaryManagedInstanceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _primaryManagedInstanceId;

    /// <summary>
    /// Id of Partner Managed Instance in pair.
    /// </summary>
    public BicepValue<ResourceIdentifier> PartnerManagedInstanceId { get => _partnerManagedInstanceId; set => _partnerManagedInstanceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _partnerManagedInstanceId;

    /// <summary>
    /// Creates a new ManagedInstancePairInfo.
    /// </summary>
    public ManagedInstancePairInfo()
    {
        _primaryManagedInstanceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrimaryManagedInstanceId", ["primaryManagedInstanceId"]);
        _partnerManagedInstanceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PartnerManagedInstanceId", ["partnerManagedInstanceId"]);
    }
}
