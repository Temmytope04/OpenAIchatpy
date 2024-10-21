// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// ObjectReplicationPolicy.
/// </summary>
public partial class ObjectReplicationPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Required. Destination account name. It should be full resource id if
    /// allowCrossTenantReplication set to false.
    /// </summary>
    public BicepValue<string> DestinationAccount { get => _destinationAccount; set => _destinationAccount.Assign(value); }
    private readonly BicepValue<string> _destinationAccount;

    /// <summary>
    /// The storage account object replication rules.
    /// </summary>
    public BicepList<ObjectReplicationPolicyRule> Rules { get => _rules; set => _rules.Assign(value); }
    private readonly BicepList<ObjectReplicationPolicyRule> _rules;

    /// <summary>
    /// Required. Source account name. It should be full resource id if
    /// allowCrossTenantReplication set to false.
    /// </summary>
    public BicepValue<string> SourceAccount { get => _sourceAccount; set => _sourceAccount.Assign(value); }
    private readonly BicepValue<string> _sourceAccount;

    /// <summary>
    /// Indicates when the policy is enabled on the source account.
    /// </summary>
    public BicepValue<DateTimeOffset> EnabledOn { get => _enabledOn; }
    private readonly BicepValue<DateTimeOffset> _enabledOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// A unique id for object replication policy.
    /// </summary>
    public BicepValue<string> PolicyId { get => _policyId; }
    private readonly BicepValue<string> _policyId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Creates a new ObjectReplicationPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ObjectReplicationPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ObjectReplicationPolicy.</param>
    public ObjectReplicationPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Storage/storageAccounts/objectReplicationPolicies", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _destinationAccount = BicepValue<string>.DefineProperty(this, "DestinationAccount", ["properties", "destinationAccount"]);
        _rules = BicepList<ObjectReplicationPolicyRule>.DefineProperty(this, "Rules", ["properties", "rules"]);
        _sourceAccount = BicepValue<string>.DefineProperty(this, "SourceAccount", ["properties", "sourceAccount"]);
        _enabledOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EnabledOn", ["properties", "enabledTime"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _policyId = BicepValue<string>.DefineProperty(this, "PolicyId", ["properties", "policyId"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ObjectReplicationPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";

        /// <summary>
        /// 2016-01-01.
        /// </summary>
        public static readonly string V2016_01_01 = "2016-01-01";

        /// <summary>
        /// 2015-06-15.
        /// </summary>
        public static readonly string V2015_06_15 = "2015-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing ObjectReplicationPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ObjectReplicationPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ObjectReplicationPolicy.</param>
    /// <returns>The existing ObjectReplicationPolicy resource.</returns>
    public static ObjectReplicationPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
