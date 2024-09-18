// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Log Analytics configuration, must only be provided when destination is
/// configured as &apos;log-analytics&apos;.
/// </summary>
public partial class ContainerAppLogAnalyticsConfiguration : ProvisioningConstruct
{
    /// <summary>
    /// Log analytics customer id.
    /// </summary>
    public BicepValue<string> CustomerId { get => _customerId; set => _customerId.Assign(value); }
    private readonly BicepValue<string> _customerId;

    /// <summary>
    /// Log analytics customer key.
    /// </summary>
    public BicepValue<string> SharedKey { get => _sharedKey; set => _sharedKey.Assign(value); }
    private readonly BicepValue<string> _sharedKey;

    /// <summary>
    /// Creates a new ContainerAppLogAnalyticsConfiguration.
    /// </summary>
    public ContainerAppLogAnalyticsConfiguration()
    {
        _customerId = BicepValue<string>.DefineProperty(this, "CustomerId", ["customerId"]);
        _sharedKey = BicepValue<string>.DefineProperty(this, "SharedKey", ["sharedKey"]);
    }
}
