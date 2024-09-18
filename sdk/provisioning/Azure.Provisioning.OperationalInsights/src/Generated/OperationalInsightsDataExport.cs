// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// OperationalInsightsDataExport.
/// </summary>
public partial class OperationalInsightsDataExport : Resource
{
    /// <summary>
    /// The data export rule name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The latest data export rule modification time.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; set => _createdOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// The data export rule ID.
    /// </summary>
    public BicepValue<Guid> DataExportId { get => _dataExportId; set => _dataExportId.Assign(value); }
    private readonly BicepValue<Guid> _dataExportId;

    /// <summary>
    /// Optional. Allows to define an Event Hub name. Not applicable when
    /// destination is Storage Account.
    /// </summary>
    public BicepValue<string> EventHubName { get => _eventHubName; set => _eventHubName.Assign(value); }
    private readonly BicepValue<string> _eventHubName;

    /// <summary>
    /// Active when enabled.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// Date and time when the export was last modified.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; set => _lastModifiedOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// The destination resource ID. This can be copied from the Properties
    /// entry of the destination resource in Azure.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; set => _resourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// An array of tables to export, for example: [“Heartbeat, SecurityEvent”].
    /// </summary>
    public BicepList<string> TableNames { get => _tableNames; set => _tableNames.Assign(value); }
    private readonly BicepList<string> _tableNames;

    /// <summary>
    /// The type of the destination resource.
    /// </summary>
    public BicepValue<OperationalInsightsDataExportDestinationType> DestinationType { get => _destinationType; }
    private readonly BicepValue<OperationalInsightsDataExportDestinationType> _destinationType;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent OperationalInsightsWorkspace.
    /// </summary>
    public OperationalInsightsWorkspace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<OperationalInsightsWorkspace> _parent;

    /// <summary>
    /// Creates a new OperationalInsightsDataExport.
    /// </summary>
    /// <param name="resourceName">Name of the OperationalInsightsDataExport.</param>
    /// <param name="resourceVersion">Version of the OperationalInsightsDataExport.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public OperationalInsightsDataExport(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.OperationalInsights/workspaces/dataExports", resourceVersion ?? "2020-08-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdDate"]);
        _dataExportId = BicepValue<Guid>.DefineProperty(this, "DataExportId", ["properties", "dataExportId"]);
        _eventHubName = BicepValue<string>.DefineProperty(this, "EventHubName", ["properties", "eventHubName"]);
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["properties", "enable"]);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModifiedDate"]);
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["properties", "resourceId"]);
        _tableNames = BicepList<string>.DefineProperty(this, "TableNames", ["properties", "tableNames"]);
        _destinationType = BicepValue<OperationalInsightsDataExportDestinationType>.DefineProperty(this, "DestinationType", ["properties", "type"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<OperationalInsightsWorkspace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported OperationalInsightsDataExport resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing OperationalInsightsDataExport.
    /// </summary>
    /// <param name="resourceName">Name of the OperationalInsightsDataExport.</param>
    /// <param name="resourceVersion">Version of the OperationalInsightsDataExport.</param>
    /// <returns>The existing OperationalInsightsDataExport resource.</returns>
    public static OperationalInsightsDataExport FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
