// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Resources;

/// <summary>
/// SubResource.
/// </summary>
public partial class SubResource : ProvisionableConstruct
{
    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Creates a new SubResource.
    /// </summary>
    public SubResource()
    {
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
    }
}
