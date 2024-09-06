// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// An Azure Blob Storage data source/sink.
/// </summary>
public partial class AzureBlobDataTransferDataSourceSink : DataTransferDataSourceSink
{
    /// <summary>
    /// Gets or sets the container name.
    /// </summary>
    public BicepValue<string> ContainerName { get => _containerName; set => _containerName.Assign(value); }
    private readonly BicepValue<string> _containerName;

    /// <summary>
    /// Gets or sets the endpoint uri.
    /// </summary>
    public BicepValue<Uri> EndpointUri { get => _endpointUri; set => _endpointUri.Assign(value); }
    private readonly BicepValue<Uri> _endpointUri;

    /// <summary>
    /// Creates a new AzureBlobDataTransferDataSourceSink.
    /// </summary>
    public AzureBlobDataTransferDataSourceSink() : base()
    {
        BicepValue<string>.DefineProperty(this, "component", ["component"], defaultValue: "AzureBlobStorage");
        _containerName = BicepValue<string>.DefineProperty(this, "ContainerName", ["containerName"]);
        _endpointUri = BicepValue<Uri>.DefineProperty(this, "EndpointUri", ["endpointUrl"]);
    }
}
