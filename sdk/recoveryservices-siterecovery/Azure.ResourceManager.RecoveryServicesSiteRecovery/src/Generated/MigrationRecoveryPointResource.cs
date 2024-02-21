// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A Class representing a MigrationRecoveryPoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MigrationRecoveryPointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMigrationRecoveryPointResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteRecoveryMigrationItemResource"/> using the GetMigrationRecoveryPoint method.
    /// </summary>
    public partial class MigrationRecoveryPointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MigrationRecoveryPointResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="fabricName"> The fabricName. </param>
        /// <param name="protectionContainerName"> The protectionContainerName. </param>
        /// <param name="migrationItemName"> The migrationItemName. </param>
        /// <param name="migrationRecoveryPointName"> The migrationRecoveryPointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string migrationItemName, string migrationRecoveryPointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationMigrationItems/{migrationItemName}/migrationRecoveryPoints/{migrationRecoveryPointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _migrationRecoveryPointClientDiagnostics;
        private readonly MigrationRecoveryPointsRestOperations _migrationRecoveryPointRestClient;
        private readonly MigrationRecoveryPointData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/replicationFabrics/replicationProtectionContainers/replicationMigrationItems/migrationRecoveryPoints";

        /// <summary> Initializes a new instance of the <see cref="MigrationRecoveryPointResource"/> class for mocking. </summary>
        protected MigrationRecoveryPointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MigrationRecoveryPointResource(ArmClient client, MigrationRecoveryPointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationRecoveryPointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MigrationRecoveryPointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationRecoveryPointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string migrationRecoveryPointApiVersion);
            _migrationRecoveryPointRestClient = new MigrationRecoveryPointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationRecoveryPointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MigrationRecoveryPointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a recovery point for a migration item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationMigrationItems/{migrationItemName}/migrationRecoveryPoints/{migrationRecoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationRecoveryPoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationRecoveryPointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MigrationRecoveryPointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationRecoveryPointClientDiagnostics.CreateScope("MigrationRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = await _migrationRecoveryPointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a recovery point for a migration item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}/replicationMigrationItems/{migrationItemName}/migrationRecoveryPoints/{migrationRecoveryPointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MigrationRecoveryPoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationRecoveryPointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationRecoveryPointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationRecoveryPointClientDiagnostics.CreateScope("MigrationRecoveryPointResource.Get");
            scope.Start();
            try
            {
                var response = _migrationRecoveryPointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationRecoveryPointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
