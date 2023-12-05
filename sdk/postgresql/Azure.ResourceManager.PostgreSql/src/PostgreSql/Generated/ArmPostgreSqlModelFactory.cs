// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPostgreSqlModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The Azure Active Directory identity of the server. Current supported identity types: SystemAssigned. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="version"> Server version. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="byokEnforcement"> Status showing whether the server data encryption is enabled with customer-managed keys. </param>
        /// <param name="infrastructureEncryption"> Status showing whether the server enabled infrastructure encryption. </param>
        /// <param name="userVisibleState"> A state of a server that is visible to user. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="earliestRestoreOn"> Earliest restore point creation time (ISO8601 format). </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="replicationRole"> The replication role of the server. </param>
        /// <param name="masterServerId"> The master server id of a replica server. </param>
        /// <param name="replicaCapacity"> The maximum number of replicas that a master server can have. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a server. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlServerData"/> instance for mocking. </returns>
        public static PostgreSqlServerData PostgreSqlServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, PostgreSqlSku sku = null, string administratorLogin = null, PostgreSqlServerVersion? version = null, PostgreSqlSslEnforcementEnum? sslEnforcement = null, PostgreSqlMinimalTlsVersionEnum? minimalTlsVersion = null, string byokEnforcement = null, PostgreSqlInfrastructureEncryption? infrastructureEncryption = null, PostgreSqlServerState? userVisibleState = null, string fullyQualifiedDomainName = null, DateTimeOffset? earliestRestoreOn = null, PostgreSqlStorageProfile storageProfile = null, string replicationRole = null, ResourceIdentifier masterServerId = null, int? replicaCapacity = null, PostgreSqlPublicNetworkAccessEnum? publicNetworkAccess = null, IEnumerable<PostgreSqlServerPrivateEndpointConnection> privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<PostgreSqlServerPrivateEndpointConnection>();

            return new PostgreSqlServerData(id, name, resourceType, systemData, tags, location, identity, sku, administratorLogin, version, sslEnforcement, minimalTlsVersion, byokEnforcement, infrastructureEncryption, userVisibleState, fullyQualifiedDomainName, earliestRestoreOn, storageProfile, replicationRole, masterServerId, replicaCapacity, publicNetworkAccess, privateEndpointConnections?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlServerPrivateEndpointConnection"/>. </summary>
        /// <param name="id"> Resource ID of the Private Endpoint Connection. </param>
        /// <param name="properties"> Private endpoint connection properties. </param>
        /// <returns> A new <see cref="Models.PostgreSqlServerPrivateEndpointConnection"/> instance for mocking. </returns>
        public static PostgreSqlServerPrivateEndpointConnection PostgreSqlServerPrivateEndpointConnection(ResourceIdentifier id = null, PostgreSqlServerPrivateEndpointConnectionProperties properties = null)
        {
            return new PostgreSqlServerPrivateEndpointConnection(id, properties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlServerPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <returns> A new <see cref="Models.PostgreSqlServerPrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static PostgreSqlServerPrivateEndpointConnectionProperties PostgreSqlServerPrivateEndpointConnectionProperties(ResourceIdentifier privateEndpointId = null, PostgreSqlServerPrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState = null, PostgreSqlPrivateEndpointProvisioningState? provisioningState = null)
        {
            return new PostgreSqlServerPrivateEndpointConnectionProperties(privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, privateLinkServiceConnectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlServerPrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        /// <returns> A new <see cref="Models.PostgreSqlServerPrivateLinkServiceConnectionStateProperty"/> instance for mocking. </returns>
        public static PostgreSqlServerPrivateLinkServiceConnectionStateProperty PostgreSqlServerPrivateLinkServiceConnectionStateProperty(PostgreSqlPrivateLinkServiceConnectionStateStatus status = default, string description = null, PostgreSqlPrivateLinkServiceConnectionStateRequiredAction? actionsRequired = null)
        {
            return new PostgreSqlServerPrivateLinkServiceConnectionStateProperty(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlFirewallRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlFirewallRuleData"/> instance for mocking. </returns>
        public static PostgreSqlFirewallRuleData PostgreSqlFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new PostgreSqlFirewallRuleData(id, name, resourceType, systemData, startIPAddress, endIPAddress);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlVirtualNetworkRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkSubnetId"> The ARM resource id of the virtual network subnet. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Create firewall rule before the virtual network has vnet service endpoint enabled. </param>
        /// <param name="state"> Virtual Network Rule State. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlVirtualNetworkRuleData"/> instance for mocking. </returns>
        public static PostgreSqlVirtualNetworkRuleData PostgreSqlVirtualNetworkRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier virtualNetworkSubnetId = null, bool? ignoreMissingVnetServiceEndpoint = null, PostgreSqlVirtualNetworkRuleState? state = null)
        {
            return new PostgreSqlVirtualNetworkRuleData(id, name, resourceType, systemData, virtualNetworkSubnetId, ignoreMissingVnetServiceEndpoint, state);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlDatabaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlDatabaseData"/> instance for mocking. </returns>
        public static PostgreSqlDatabaseData PostgreSqlDatabaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string charset = null, string collation = null)
        {
            return new PostgreSqlDatabaseData(id, name, resourceType, systemData, charset, collation);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlConfigurationData"/> instance for mocking. </returns>
        public static PostgreSqlConfigurationData PostgreSqlConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string value = null, string description = null, string defaultValue = null, string dataType = null, string allowedValues = null, string source = null)
        {
            return new PostgreSqlConfigurationData(id, name, resourceType, systemData, value, description, defaultValue, dataType, allowedValues, source);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlLogFile"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInKB"> Size of the log file. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="logFileType"> Type of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        /// <returns> A new <see cref="Models.PostgreSqlLogFile"/> instance for mocking. </returns>
        public static PostgreSqlLogFile PostgreSqlLogFile(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? sizeInKB = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string logFileType = null, Uri uri = null)
        {
            return new PostgreSqlLogFile(id, name, resourceType, systemData, sizeInKB, createdOn, lastModifiedOn, logFileType, uri);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlServerAdministratorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> The type of administrator. </param>
        /// <param name="loginAccountName"> The server administrator login account name. </param>
        /// <param name="secureId"> The server administrator Sid (Secure ID). </param>
        /// <param name="tenantId"> The server Active Directory Administrator tenant id. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlServerAdministratorData"/> instance for mocking. </returns>
        public static PostgreSqlServerAdministratorData PostgreSqlServerAdministratorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PostgreSqlAdministratorType? administratorType = null, string loginAccountName = null, Guid? secureId = null, Guid? tenantId = null)
        {
            return new PostgreSqlServerAdministratorData(id, name, resourceType, systemData, administratorType, loginAccountName, secureId, tenantId);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlRecoverableServerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastAvailableBackupOn"> The last available backup date time. </param>
        /// <param name="serviceLevelObjective"> The service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="version"> The PostgreSQL version. </param>
        /// <returns> A new <see cref="Models.PostgreSqlRecoverableServerResourceData"/> instance for mocking. </returns>
        public static PostgreSqlRecoverableServerResourceData PostgreSqlRecoverableServerResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? lastAvailableBackupOn = null, string serviceLevelObjective = null, string edition = null, int? vCores = null, string hardwareGeneration = null, string version = null)
        {
            return new PostgreSqlRecoverableServerResourceData(id, name, resourceType, systemData, lastAvailableBackupOn, serviceLevelObjective, edition, vCores, hardwareGeneration, version);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlPerformanceTierProperties"/>. </summary>
        /// <param name="id"> ID of the performance tier. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minLargeStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="maxLargeStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="serviceLevelObjectives"> Service level objectives associated with the performance tier. </param>
        /// <returns> A new <see cref="Models.PostgreSqlPerformanceTierProperties"/> instance for mocking. </returns>
        public static PostgreSqlPerformanceTierProperties PostgreSqlPerformanceTierProperties(string id = null, int? maxBackupRetentionDays = null, int? minBackupRetentionDays = null, int? maxStorageInMB = null, int? minLargeStorageInMB = null, int? maxLargeStorageInMB = null, int? minStorageInMB = null, IEnumerable<PostgreSqlPerformanceTierServiceLevelObjectives> serviceLevelObjectives = null)
        {
            serviceLevelObjectives ??= new List<PostgreSqlPerformanceTierServiceLevelObjectives>();

            return new PostgreSqlPerformanceTierProperties(id, maxBackupRetentionDays, minBackupRetentionDays, maxStorageInMB, minLargeStorageInMB, maxLargeStorageInMB, minStorageInMB, serviceLevelObjectives?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlPerformanceTierServiceLevelObjectives"/>. </summary>
        /// <param name="id"> ID for the service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <returns> A new <see cref="Models.PostgreSqlPerformanceTierServiceLevelObjectives"/> instance for mocking. </returns>
        public static PostgreSqlPerformanceTierServiceLevelObjectives PostgreSqlPerformanceTierServiceLevelObjectives(string id = null, string edition = null, int? vCores = null, string hardwareGeneration = null, int? maxBackupRetentionDays = null, int? minBackupRetentionDays = null, int? maxStorageInMB = null, int? minStorageInMB = null)
        {
            return new PostgreSqlPerformanceTierServiceLevelObjectives(id, edition, vCores, hardwareGeneration, maxBackupRetentionDays, minBackupRetentionDays, maxStorageInMB, minStorageInMB);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlNameAvailabilityResult"/>. </summary>
        /// <param name="message"> Error Message. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="reason"> Reason for name being unavailable. </param>
        /// <returns> A new <see cref="Models.PostgreSqlNameAvailabilityResult"/> instance for mocking. </returns>
        public static PostgreSqlNameAvailabilityResult PostgreSqlNameAvailabilityResult(string message = null, bool? isNameAvailable = null, string reason = null)
        {
            return new PostgreSqlNameAvailabilityResult(message, isNameAvailable, reason);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlServerSecurityAlertPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="sendToEmailAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlServerSecurityAlertPolicyData"/> instance for mocking. </returns>
        public static PostgreSqlServerSecurityAlertPolicyData PostgreSqlServerSecurityAlertPolicyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PostgreSqlServerSecurityAlertPolicyState? state = null, IEnumerable<string> disabledAlerts = null, IEnumerable<string> emailAddresses = null, bool? sendToEmailAccountAdmins = null, string storageEndpoint = null, string storageAccountAccessKey = null, int? retentionDays = null)
        {
            disabledAlerts ??= new List<string>();
            emailAddresses ??= new List<string>();

            return new PostgreSqlServerSecurityAlertPolicyData(id, name, resourceType, systemData, state, disabledAlerts?.ToList(), emailAddresses?.ToList(), sendToEmailAccountAdmins, storageEndpoint, storageAccountAccessKey, retentionDays);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static PostgreSqlPrivateEndpointConnectionData PostgreSqlPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, PostgreSqlPrivateLinkServiceConnectionStateProperty connectionState = null, string provisioningState = null)
        {
            return new PostgreSqlPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlPrivateLinkServiceConnectionStateProperty"/>. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        /// <returns> A new <see cref="Models.PostgreSqlPrivateLinkServiceConnectionStateProperty"/> instance for mocking. </returns>
        public static PostgreSqlPrivateLinkServiceConnectionStateProperty PostgreSqlPrivateLinkServiceConnectionStateProperty(string status = null, string description = null, string actionsRequired = null)
        {
            return new PostgreSqlPrivateLinkServiceConnectionStateProperty(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource group id. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlPrivateLinkResourceData"/> instance for mocking. </returns>
        public static PostgreSqlPrivateLinkResourceData PostgreSqlPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, PostgreSqlPrivateLinkResourceProperties properties = null)
        {
            return new PostgreSqlPrivateLinkResourceData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PostgreSqlPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <returns> A new <see cref="Models.PostgreSqlPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static PostgreSqlPrivateLinkResourceProperties PostgreSqlPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null)
        {
            requiredMembers ??= new List<string>();

            return new PostgreSqlPrivateLinkResourceProperties(groupId, requiredMembers?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSql.PostgreSqlServerKeyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector used to protect the key. </param>
        /// <param name="serverKeyType"> The key type like 'AzureKeyVault'. </param>
        /// <param name="uri"> The URI of the key. </param>
        /// <param name="createdOn"> The key creation date. </param>
        /// <returns> A new <see cref="PostgreSql.PostgreSqlServerKeyData"/> instance for mocking. </returns>
        public static PostgreSqlServerKeyData PostgreSqlServerKeyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string kind = null, PostgreSqlServerKeyType? serverKeyType = null, Uri uri = null, DateTimeOffset? createdOn = null)
        {
            return new PostgreSqlServerKeyData(id, name, resourceType, systemData, kind, serverKeyType, uri, createdOn);
        }
    }
}
