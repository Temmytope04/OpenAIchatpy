// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Static routing enrichment details.             Please note
/// Azure.ResourceManager.EventGrid.Models.StaticRoutingEnrichment is the base
/// class. According to the scenario, a derived class of the base class might
/// need to be assigned here, or this property needs to be casted to one of
/// the possible derived classes.             The available derived classes
/// include
/// Azure.ResourceManager.EventGrid.Models.StaticStringRoutingEnrichment.
/// </summary>
public partial class StaticRoutingEnrichment : ProvisionableConstruct
{
    /// <summary>
    /// Static routing enrichment key.
    /// </summary>
    public BicepValue<string> Key { get => _key; set => _key.Assign(value); }
    private readonly BicepValue<string> _key;

    /// <summary>
    /// Creates a new StaticRoutingEnrichment.
    /// </summary>
    public StaticRoutingEnrichment()
    {
        _key = BicepValue<string>.DefineProperty(this, "Key", ["key"]);
    }
}
