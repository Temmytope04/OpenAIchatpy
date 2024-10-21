// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Statuses of objects deployed by the user-specified kustomizations from the
/// git repository.
/// </summary>
public partial class KubernetesObjectStatus : ProvisionableConstruct
{
    /// <summary>
    /// Name of the applied object.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Namespace of the applied object.
    /// </summary>
    public BicepValue<string> Namespace { get => _namespace; }
    private readonly BicepValue<string> _namespace;

    /// <summary>
    /// Kind of the applied object.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Compliance state of the applied object showing whether the applied
    /// object has come into a ready state on the cluster.
    /// </summary>
    public BicepValue<KubernetesFluxComplianceState> ComplianceState { get => _complianceState; }
    private readonly BicepValue<KubernetesFluxComplianceState> _complianceState;

    /// <summary>
    /// Object reference to the Kustomization that applied this object.
    /// </summary>
    public BicepValue<KubernetesObjectReference> AppliedBy { get => _appliedBy; }
    private readonly BicepValue<KubernetesObjectReference> _appliedBy;

    /// <summary>
    /// List of Kubernetes object status conditions present on the cluster.
    /// </summary>
    public BicepList<KubernetesObjectStatusCondition> StatusConditions { get => _statusConditions; }
    private readonly BicepList<KubernetesObjectStatusCondition> _statusConditions;

    /// <summary>
    /// Additional properties that are provided from objects of the HelmRelease
    /// kind.
    /// </summary>
    public BicepValue<HelmReleaseProperties> HelmReleaseProperties { get => _helmReleaseProperties; }
    private readonly BicepValue<HelmReleaseProperties> _helmReleaseProperties;

    /// <summary>
    /// Creates a new KubernetesObjectStatus.
    /// </summary>
    public KubernetesObjectStatus()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _namespace = BicepValue<string>.DefineProperty(this, "Namespace", ["namespace"], isOutput: true);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"], isOutput: true);
        _complianceState = BicepValue<KubernetesFluxComplianceState>.DefineProperty(this, "ComplianceState", ["complianceState"], isOutput: true);
        _appliedBy = BicepValue<KubernetesObjectReference>.DefineProperty(this, "AppliedBy", ["appliedBy"], isOutput: true);
        _statusConditions = BicepList<KubernetesObjectStatusCondition>.DefineProperty(this, "StatusConditions", ["statusConditions"], isOutput: true);
        _helmReleaseProperties = BicepValue<HelmReleaseProperties>.DefineProperty(this, "HelmReleaseProperties", ["helmReleaseProperties"], isOutput: true);
    }
}
