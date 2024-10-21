// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The GitHub action container configuration.
/// </summary>
public partial class GitHubActionContainerConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// The server URL for the container registry where the build will be
    /// hosted.
    /// </summary>
    public BicepValue<Uri> ServerUri { get => _serverUri; set => _serverUri.Assign(value); }
    private readonly BicepValue<Uri> _serverUri;

    /// <summary>
    /// The image name for the build.
    /// </summary>
    public BicepValue<string> ImageName { get => _imageName; set => _imageName.Assign(value); }
    private readonly BicepValue<string> _imageName;

    /// <summary>
    /// The username used to upload the image to the container registry.
    /// </summary>
    public BicepValue<string> Username { get => _username; set => _username.Assign(value); }
    private readonly BicepValue<string> _username;

    /// <summary>
    /// The password used to upload the image to the container registry.
    /// </summary>
    public BicepValue<string> Password { get => _password; set => _password.Assign(value); }
    private readonly BicepValue<string> _password;

    /// <summary>
    /// Creates a new GitHubActionContainerConfiguration.
    /// </summary>
    public GitHubActionContainerConfiguration()
    {
        _serverUri = BicepValue<Uri>.DefineProperty(this, "ServerUri", ["serverUrl"]);
        _imageName = BicepValue<string>.DefineProperty(this, "ImageName", ["imageName"]);
        _username = BicepValue<string>.DefineProperty(this, "Username", ["username"]);
        _password = BicepValue<string>.DefineProperty(this, "Password", ["password"]);
    }
}
