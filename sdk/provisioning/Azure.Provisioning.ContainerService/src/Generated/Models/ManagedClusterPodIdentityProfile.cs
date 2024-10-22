// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// See [use AAD pod
/// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity)
/// for more details on pod identity integration.
/// </summary>
public partial class ManagedClusterPodIdentityProfile : ProvisionableConstruct
{
    /// <summary>
    /// Whether the pod identity addon is enabled.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Running in Kubenet is disabled by default due to the security related
    /// nature of AAD Pod Identity and the risks of IP spoofing. See [using
    /// Kubenet network plugin with AAD Pod
    /// Identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity#using-kubenet-network-plugin-with-azure-active-directory-pod-managed-identities)
    /// for more information.
    /// </summary>
    public BicepValue<bool> AllowNetworkPluginKubenet { get => _allowNetworkPluginKubenet; set => _allowNetworkPluginKubenet.Assign(value); }
    private readonly BicepValue<bool> _allowNetworkPluginKubenet;

    /// <summary>
    /// The pod identities to use in the cluster.
    /// </summary>
    public BicepList<ManagedClusterPodIdentity> UserAssignedIdentities { get => _userAssignedIdentities; set => _userAssignedIdentities.Assign(value); }
    private readonly BicepList<ManagedClusterPodIdentity> _userAssignedIdentities;

    /// <summary>
    /// The pod identity exceptions to allow.
    /// </summary>
    public BicepList<ManagedClusterPodIdentityException> UserAssignedIdentityExceptions { get => _userAssignedIdentityExceptions; set => _userAssignedIdentityExceptions.Assign(value); }
    private readonly BicepList<ManagedClusterPodIdentityException> _userAssignedIdentityExceptions;

    /// <summary>
    /// Creates a new ManagedClusterPodIdentityProfile.
    /// </summary>
    public ManagedClusterPodIdentityProfile()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _allowNetworkPluginKubenet = BicepValue<bool>.DefineProperty(this, "AllowNetworkPluginKubenet", ["allowNetworkPluginKubenet"]);
        _userAssignedIdentities = BicepList<ManagedClusterPodIdentity>.DefineProperty(this, "UserAssignedIdentities", ["userAssignedIdentities"]);
        _userAssignedIdentityExceptions = BicepList<ManagedClusterPodIdentityException>.DefineProperty(this, "UserAssignedIdentityExceptions", ["userAssignedIdentityExceptions"]);
    }
}
