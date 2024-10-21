// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// Connection state of the private endpoint connection.
/// </summary>
public partial class SignalRPrivateLinkServiceConnectionState : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether the connection has been Approved/Rejected/Removed by
    /// the owner of the service.
    /// </summary>
    public BicepValue<PrivateLinkServiceConnectionStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<PrivateLinkServiceConnectionStatus> _status;

    /// <summary>
    /// The reason for approval/rejection of the connection.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// A message indicating if changes on the service provider require any
    /// updates on the consumer.
    /// </summary>
    public BicepValue<string> ActionsRequired { get => _actionsRequired; set => _actionsRequired.Assign(value); }
    private readonly BicepValue<string> _actionsRequired;

    /// <summary>
    /// Creates a new SignalRPrivateLinkServiceConnectionState.
    /// </summary>
    public SignalRPrivateLinkServiceConnectionState()
    {
        _status = BicepValue<PrivateLinkServiceConnectionStatus>.DefineProperty(this, "Status", ["status"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _actionsRequired = BicepValue<string>.DefineProperty(this, "ActionsRequired", ["actionsRequired"]);
    }
}
