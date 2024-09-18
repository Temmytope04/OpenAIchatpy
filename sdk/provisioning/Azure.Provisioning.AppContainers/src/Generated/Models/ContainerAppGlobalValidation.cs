// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings that determines the validation flow of users
/// using ContainerApp Service Authentication/Authorization.
/// </summary>
public partial class ContainerAppGlobalValidation : ProvisioningConstruct
{
    /// <summary>
    /// The action to take when an unauthenticated client attempts to access
    /// the app.
    /// </summary>
    public BicepValue<ContainerAppUnauthenticatedClientActionV2> UnauthenticatedClientAction { get => _unauthenticatedClientAction; set => _unauthenticatedClientAction.Assign(value); }
    private readonly BicepValue<ContainerAppUnauthenticatedClientActionV2> _unauthenticatedClientAction;

    /// <summary>
    /// The default authentication provider to use when multiple providers are
    /// configured.             This setting is only needed if multiple
    /// providers are configured and the unauthenticated client
    /// action is set to &quot;RedirectToLoginPage&quot;.
    /// </summary>
    public BicepValue<string> RedirectToProvider { get => _redirectToProvider; set => _redirectToProvider.Assign(value); }
    private readonly BicepValue<string> _redirectToProvider;

    /// <summary>
    /// The paths for which unauthenticated flow would not be redirected to the
    /// login page.
    /// </summary>
    public BicepList<string> ExcludedPaths { get => _excludedPaths; set => _excludedPaths.Assign(value); }
    private readonly BicepList<string> _excludedPaths;

    /// <summary>
    /// Creates a new ContainerAppGlobalValidation.
    /// </summary>
    public ContainerAppGlobalValidation()
    {
        _unauthenticatedClientAction = BicepValue<ContainerAppUnauthenticatedClientActionV2>.DefineProperty(this, "UnauthenticatedClientAction", ["unauthenticatedClientAction"]);
        _redirectToProvider = BicepValue<string>.DefineProperty(this, "RedirectToProvider", ["redirectToProvider"]);
        _excludedPaths = BicepList<string>.DefineProperty(this, "ExcludedPaths", ["excludedPaths"]);
    }
}
