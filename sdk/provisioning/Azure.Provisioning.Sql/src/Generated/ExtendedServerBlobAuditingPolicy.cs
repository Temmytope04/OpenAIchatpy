// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ExtendedServerBlobAuditingPolicy.
/// </summary>
public partial class ExtendedServerBlobAuditingPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Specifies the Actions-Groups and Actions to audit.
    /// The recommended set of action groups to use
    /// is the following combination - this will audit all the queries and
    /// stored procedures executed against the database, as well as successful
    /// and failed logins:                           BATCH_COMPLETED_GROUP,
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
    /// FAILED_DATABASE_AUTHENTICATION_GROUP.
    /// This above combination is also the set that
    /// is configured by default when enabling auditing from the Azure portal.
    /// The supported action groups to audit are
    /// (note: choose only specific groups that cover your auditing needs.
    /// Using unnecessary groups could lead to very large quantities of audit
    /// records):
    /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
    /// BACKUP_RESTORE_GROUP              DATABASE_LOGOUT_GROUP
    /// DATABASE_OBJECT_CHANGE_GROUP
    /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
    /// DATABASE_OPERATION_GROUP
    /// DATABASE_PERMISSION_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
    /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
    /// FAILED_DATABASE_AUTHENTICATION_GROUP
    /// SCHEMA_OBJECT_ACCESS_GROUP
    /// SCHEMA_OBJECT_CHANGE_GROUP
    /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
    /// USER_CHANGE_PASSWORD_GROUP
    /// BATCH_STARTED_GROUP              BATCH_COMPLETED_GROUP
    /// DBCC_GROUP              DATABASE_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_CHANGE_GROUP              LEDGER_OPERATION_GROUP
    /// These are groups that cover all sql
    /// statements and stored procedures executed against the database, and
    /// should not be used in combination with other groups as this will
    /// result in duplicate audit logs.                           For more
    /// information, see [Database-Level Audit Action
    /// Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
    /// For Database auditing policy, specific
    /// Actions can also be specified (note that Actions cannot be specified
    /// for Server auditing policy). The supported actions to audit are:
    /// SELECT              UPDATE              INSERT
    /// DELETE              EXECUTE              RECEIVE
    /// REFERENCES                           The general form for
    /// defining an action to be audited is:              {action} ON {object}
    /// BY {principal}                           Note that &lt;object&gt; in
    /// the above format can refer to an object like a table, view, or stored
    /// procedure, or an entire database or schema. For the latter cases, the
    /// forms DATABASE::{db_name} and SCHEMA::{schema_name} are used,
    /// respectively.                           For example:
    /// SELECT on dbo.myTable by public              SELECT on
    /// DATABASE::myDatabase by public              SELECT on SCHEMA::mySchema
    /// by public                           For more information, see
    /// [Database-Level Audit
    /// Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
    /// </summary>
    public BicepList<string> AuditActionsAndGroups { get => _auditActionsAndGroups; set => _auditActionsAndGroups.Assign(value); }
    private readonly BicepList<string> _auditActionsAndGroups;

    /// <summary>
    /// Specifies whether audit events are sent to Azure Monitor.
    /// In order to send the events to Azure Monitor, specify
    /// &apos;State&apos; as &apos;Enabled&apos; and
    /// &apos;IsAzureMonitorTargetEnabled&apos; as true.
    /// When using REST API to configure auditing,
    /// Diagnostic Settings with &apos;SQLSecurityAuditEvents&apos; diagnostic
    /// logs category on the database should be also created.
    /// Note that for server level audit you should use the
    /// &apos;master&apos; database as {databaseName}.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic
    /// Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings
    /// PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    public BicepValue<bool> IsAzureMonitorTargetEnabled { get => _isAzureMonitorTargetEnabled; set => _isAzureMonitorTargetEnabled.Assign(value); }
    private readonly BicepValue<bool> _isAzureMonitorTargetEnabled;

    /// <summary>
    /// Specifies the state of devops audit. If state is Enabled, devops logs
    /// will be sent to Azure Monitor.              In order to send the
    /// events to Azure Monitor, specify &apos;State&apos; as
    /// &apos;Enabled&apos;, &apos;IsAzureMonitorTargetEnabled&apos; as true
    /// and &apos;IsDevopsAuditEnabled&apos; as true
    /// When using REST API to configure auditing,
    /// Diagnostic Settings with &apos;DevOpsOperationsAudit&apos; diagnostic
    /// logs category on the master database should also be created.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/master/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic
    /// Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings
    /// PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    public BicepValue<bool> IsDevopsAuditEnabled { get => _isDevopsAuditEnabled; set => _isDevopsAuditEnabled.Assign(value); }
    private readonly BicepValue<bool> _isDevopsAuditEnabled;

    /// <summary>
    /// Specifies whether Managed Identity is used to access blob storage.
    /// </summary>
    public BicepValue<bool> IsManagedIdentityInUse { get => _isManagedIdentityInUse; set => _isManagedIdentityInUse.Assign(value); }
    private readonly BicepValue<bool> _isManagedIdentityInUse;

    /// <summary>
    /// Specifies whether storageAccountAccessKey value is the storage&apos;s
    /// secondary key.
    /// </summary>
    public BicepValue<bool> IsStorageSecondaryKeyInUse { get => _isStorageSecondaryKeyInUse; set => _isStorageSecondaryKeyInUse.Assign(value); }
    private readonly BicepValue<bool> _isStorageSecondaryKeyInUse;

    /// <summary>
    /// Specifies condition of where clause when creating an audit.
    /// </summary>
    public BicepValue<string> PredicateExpression { get => _predicateExpression; set => _predicateExpression.Assign(value); }
    private readonly BicepValue<string> _predicateExpression;

    /// <summary>
    /// Specifies the amount of time in milliseconds that can elapse before
    /// audit actions are forced to be processed.             The default
    /// minimum value is 1000 (1 second). The maximum is 2,147,483,647.
    /// </summary>
    public BicepValue<int> QueueDelayMs { get => _queueDelayMs; set => _queueDelayMs.Assign(value); }
    private readonly BicepValue<int> _queueDelayMs;

    /// <summary>
    /// Specifies the number of days to keep in the audit logs in the storage
    /// account.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

    /// <summary>
    /// Specifies the state of the audit. If state is Enabled, storageEndpoint
    /// or isAzureMonitorTargetEnabled are required.
    /// </summary>
    public BicepValue<BlobAuditingPolicyState> State { get => _state; set => _state.Assign(value); }
    private readonly BicepValue<BlobAuditingPolicyState> _state;

    /// <summary>
    /// Specifies the identifier key of the auditing storage account.
    /// If state is Enabled and storageEndpoint is specified, not
    /// specifying the storageAccountAccessKey will use SQL server
    /// system-assigned managed identity to access the storage.
    /// Prerequisites for using managed identity authentication:
    /// 1. Assign SQL Server a system-assigned managed identity in
    /// Azure Active Directory (AAD).             2. Grant SQL Server identity
    /// access to the storage account by adding &apos;Storage Blob Data
    /// Contributor&apos; RBAC role to the server identity.             For
    /// more information, see [Auditing to storage using Managed Identity
    /// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
    /// </summary>
    public BicepValue<string> StorageAccountAccessKey { get => _storageAccountAccessKey; set => _storageAccountAccessKey.Assign(value); }
    private readonly BicepValue<string> _storageAccountAccessKey;

    /// <summary>
    /// Specifies the blob storage subscription Id.
    /// </summary>
    public BicepValue<Guid> StorageAccountSubscriptionId { get => _storageAccountSubscriptionId; set => _storageAccountSubscriptionId.Assign(value); }
    private readonly BicepValue<Guid> _storageAccountSubscriptionId;

    /// <summary>
    /// Specifies the blob storage endpoint (e.g.
    /// https://MyAccount.blob.core.windows.net). If state is Enabled,
    /// storageEndpoint or isAzureMonitorTargetEnabled is required.
    /// </summary>
    public BicepValue<string> StorageEndpoint { get => _storageEndpoint; set => _storageEndpoint.Assign(value); }
    private readonly BicepValue<string> _storageEndpoint;

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
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServer> _parent;

    /// <summary>
    /// Creates a new ExtendedServerBlobAuditingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ExtendedServerBlobAuditingPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ExtendedServerBlobAuditingPolicy.</param>
    public ExtendedServerBlobAuditingPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/extendedAuditingSettings", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _auditActionsAndGroups = BicepList<string>.DefineProperty(this, "AuditActionsAndGroups", ["properties", "auditActionsAndGroups"]);
        _isAzureMonitorTargetEnabled = BicepValue<bool>.DefineProperty(this, "IsAzureMonitorTargetEnabled", ["properties", "isAzureMonitorTargetEnabled"]);
        _isDevopsAuditEnabled = BicepValue<bool>.DefineProperty(this, "IsDevopsAuditEnabled", ["properties", "isDevopsAuditEnabled"]);
        _isManagedIdentityInUse = BicepValue<bool>.DefineProperty(this, "IsManagedIdentityInUse", ["properties", "isManagedIdentityInUse"]);
        _isStorageSecondaryKeyInUse = BicepValue<bool>.DefineProperty(this, "IsStorageSecondaryKeyInUse", ["properties", "isStorageSecondaryKeyInUse"]);
        _predicateExpression = BicepValue<string>.DefineProperty(this, "PredicateExpression", ["properties", "predicateExpression"]);
        _queueDelayMs = BicepValue<int>.DefineProperty(this, "QueueDelayMs", ["properties", "queueDelayMs"]);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _state = BicepValue<BlobAuditingPolicyState>.DefineProperty(this, "State", ["properties", "state"]);
        _storageAccountAccessKey = BicepValue<string>.DefineProperty(this, "StorageAccountAccessKey", ["properties", "storageAccountAccessKey"]);
        _storageAccountSubscriptionId = BicepValue<Guid>.DefineProperty(this, "StorageAccountSubscriptionId", ["properties", "storageAccountSubscriptionId"]);
        _storageEndpoint = BicepValue<string>.DefineProperty(this, "StorageEndpoint", ["properties", "storageEndpoint"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ExtendedServerBlobAuditingPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing ExtendedServerBlobAuditingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ExtendedServerBlobAuditingPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ExtendedServerBlobAuditingPolicy.</param>
    /// <returns>The existing ExtendedServerBlobAuditingPolicy resource.</returns>
    public static ExtendedServerBlobAuditingPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
