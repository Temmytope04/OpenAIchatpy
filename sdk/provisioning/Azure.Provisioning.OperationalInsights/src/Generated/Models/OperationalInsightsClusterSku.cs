// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The cluster sku definition.
/// </summary>
public partial class OperationalInsightsClusterSku : ProvisioningConstruct
{
    /// <summary>
    /// The capacity value.
    /// </summary>
    public BicepValue<OperationalInsightsClusterCapacity> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<OperationalInsightsClusterCapacity> _capacity;

    /// <summary>
    /// The name of the SKU.
    /// </summary>
    public BicepValue<OperationalInsightsClusterSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<OperationalInsightsClusterSkuName> _name;

    /// <summary>
    /// Creates a new OperationalInsightsClusterSku.
    /// </summary>
    public OperationalInsightsClusterSku()
    {
        _capacity = BicepValue<OperationalInsightsClusterCapacity>.DefineProperty(this, "Capacity", ["capacity"]);
        _name = BicepValue<OperationalInsightsClusterSkuName>.DefineProperty(this, "Name", ["name"]);
    }
}
