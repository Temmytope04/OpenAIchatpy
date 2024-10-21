// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.WebPubSub;

/// <summary>
/// Network ACL.
/// </summary>
public partial class PublicNetworkAcls : ProvisionableConstruct
{
    /// <summary>
    /// Allowed request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<WebPubSubRequestType> Allow { get => _allow; set => _allow.Assign(value); }
    private readonly BicepList<WebPubSubRequestType> _allow;

    /// <summary>
    /// Denied request types. The value can be one or more of:
    /// ClientConnection, ServerConnection, RESTAPI.
    /// </summary>
    public BicepList<WebPubSubRequestType> Deny { get => _deny; set => _deny.Assign(value); }
    private readonly BicepList<WebPubSubRequestType> _deny;

    /// <summary>
    /// Creates a new PublicNetworkAcls.
    /// </summary>
    public PublicNetworkAcls()
    {
        _allow = BicepList<WebPubSubRequestType>.DefineProperty(this, "Allow", ["allow"]);
        _deny = BicepList<WebPubSubRequestType>.DefineProperty(this, "Deny", ["deny"]);
    }
}
