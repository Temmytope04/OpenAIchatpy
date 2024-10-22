// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB resource throughput object. Either throughput is required or
/// autoscaleSettings is required, but not both.
/// </summary>
public partial class ThroughputSettingsResourceInfo : ProvisionableConstruct
{
    /// <summary>
    /// Value of the Cosmos DB resource throughput. Either throughput is
    /// required or autoscaleSettings is required, but not both.
    /// </summary>
    public BicepValue<int> Throughput { get => _throughput; set => _throughput.Assign(value); }
    private readonly BicepValue<int> _throughput;

    /// <summary>
    /// Cosmos DB resource for autoscale settings. Either throughput is
    /// required or autoscaleSettings is required, but not both.
    /// </summary>
    public BicepValue<AutoscaleSettingsResourceInfo> AutoscaleSettings { get => _autoscaleSettings; set => _autoscaleSettings.Assign(value); }
    private readonly BicepValue<AutoscaleSettingsResourceInfo> _autoscaleSettings;

    /// <summary>
    /// The minimum throughput of the resource.
    /// </summary>
    public BicepValue<string> MinimumThroughput { get => _minimumThroughput; }
    private readonly BicepValue<string> _minimumThroughput;

    /// <summary>
    /// The throughput replace is pending.
    /// </summary>
    public BicepValue<string> OfferReplacePending { get => _offerReplacePending; }
    private readonly BicepValue<string> _offerReplacePending;

    /// <summary>
    /// The offer throughput value to instantly scale up without triggering
    /// splits.
    /// </summary>
    public BicepValue<string> InstantMaximumThroughput { get => _instantMaximumThroughput; }
    private readonly BicepValue<string> _instantMaximumThroughput;

    /// <summary>
    /// The maximum throughput value or the maximum maxThroughput value (for
    /// autoscale) that can be specified.
    /// </summary>
    public BicepValue<string> SoftAllowedMaximumThroughput { get => _softAllowedMaximumThroughput; }
    private readonly BicepValue<string> _softAllowedMaximumThroughput;

    /// <summary>
    /// Creates a new ThroughputSettingsResourceInfo.
    /// </summary>
    public ThroughputSettingsResourceInfo()
    {
        _throughput = BicepValue<int>.DefineProperty(this, "Throughput", ["throughput"]);
        _autoscaleSettings = BicepValue<AutoscaleSettingsResourceInfo>.DefineProperty(this, "AutoscaleSettings", ["autoscaleSettings"]);
        _minimumThroughput = BicepValue<string>.DefineProperty(this, "MinimumThroughput", ["minimumThroughput"], isOutput: true);
        _offerReplacePending = BicepValue<string>.DefineProperty(this, "OfferReplacePending", ["offerReplacePending"], isOutput: true);
        _instantMaximumThroughput = BicepValue<string>.DefineProperty(this, "InstantMaximumThroughput", ["instantMaximumThroughput"], isOutput: true);
        _softAllowedMaximumThroughput = BicepValue<string>.DefineProperty(this, "SoftAllowedMaximumThroughput", ["softAllowedMaximumThroughput"], isOutput: true);
    }
}
