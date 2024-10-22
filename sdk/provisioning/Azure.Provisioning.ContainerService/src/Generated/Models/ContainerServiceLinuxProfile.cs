// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Profile for Linux VMs in the container service cluster.
/// </summary>
public partial class ContainerServiceLinuxProfile : ProvisionableConstruct
{
    /// <summary>
    /// The administrator username to use for Linux VMs.
    /// </summary>
    public BicepValue<string> AdminUsername { get => _adminUsername; set => _adminUsername.Assign(value); }
    private readonly BicepValue<string> _adminUsername;

    /// <summary>
    /// The list of SSH public keys used to authenticate with Linux-based VMs.
    /// A maximum of 1 key may be specified.
    /// </summary>
    public BicepList<ContainerServiceSshPublicKey> SshPublicKeys { get => _sshPublicKeys; set => _sshPublicKeys.Assign(value); }
    private readonly BicepList<ContainerServiceSshPublicKey> _sshPublicKeys;

    /// <summary>
    /// Creates a new ContainerServiceLinuxProfile.
    /// </summary>
    public ContainerServiceLinuxProfile()
    {
        _adminUsername = BicepValue<string>.DefineProperty(this, "AdminUsername", ["adminUsername"]);
        _sshPublicKeys = BicepList<ContainerServiceSshPublicKey>.DefineProperty(this, "SshPublicKeys", ["ssh", "publicKeys"]);
    }
}
