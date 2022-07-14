// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGroupLongTermRetentionBackupResource" /> and their operations.
    /// Each <see cref="ResourceGroupLongTermRetentionBackupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResourceGroupLongTermRetentionBackupCollection" /> instance call the GetResourceGroupLongTermRetentionBackups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResourceGroupLongTermRetentionBackupCollection : ArmCollection, IEnumerable<ResourceGroupLongTermRetentionBackupResource>, IAsyncEnumerable<ResourceGroupLongTermRetentionBackupResource>
    {
        private readonly ClientDiagnostics _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient;
        private readonly AzureLocation _locationName;
        private readonly string _longTermRetentionServerName;
        private readonly string _longTermRetentionDatabaseName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupCollection"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="longTermRetentionServerName"/> or <paramref name="longTermRetentionDatabaseName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ResourceGroupLongTermRetentionBackupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName) : base(client, id)
        {
            _locationName = locationName;
            _longTermRetentionServerName = longTermRetentionServerName;
            _longTermRetentionDatabaseName = longTermRetentionDatabaseName;
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceGroupLongTermRetentionBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupLongTermRetentionBackupResource.ResourceType, out string resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<ResourceGroupLongTermRetentionBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all long term retention backups for a database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupDatabase
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupLongTermRetentionBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupLongTermRetentionBackupResource> GetAllAsync(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroupLongTermRetentionBackupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByResourceGroupDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroupLongTermRetentionBackupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByResourceGroupDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all long term retention backups for a database.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// Operation Id: LongTermRetentionBackups_ListByResourceGroupDatabase
        /// </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupLongTermRetentionBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupLongTermRetentionBackupResource> GetAll(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroupLongTermRetentionBackupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByResourceGroupDatabase(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroupLongTermRetentionBackupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByResourceGroupDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionBackupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// Operation Id: LongTermRetentionBackups_GetByResourceGroup
        /// </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupLongTermRetentionBackupResource> IEnumerable<ResourceGroupLongTermRetentionBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupLongTermRetentionBackupResource> IAsyncEnumerable<ResourceGroupLongTermRetentionBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
