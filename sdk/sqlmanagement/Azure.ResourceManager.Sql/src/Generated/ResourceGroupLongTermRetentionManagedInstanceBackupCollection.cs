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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstanceLongTermRetentionBackup and their operations over its parent. </summary>
    public partial class ResourceGroupLongTermRetentionManagedInstanceBackupCollection : ArmCollection, IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>, IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>
    {
        private readonly ClientDiagnostics _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics;
        private readonly LongTermRetentionManagedInstanceBackupsRestOperations _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient;
        private readonly string _locationName;
        private readonly string _managedInstanceName;
        private readonly string _databaseName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionManagedInstanceBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionManagedInstanceBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the managed database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="managedInstanceName"/>, or <paramref name="databaseName"/> is null. </exception>
        internal ResourceGroupLongTermRetentionManagedInstanceBackupCollection(ArmClient client, ResourceIdentifier id, string locationName, string managedInstanceName, string databaseName) : base(client, id)
        {
            _locationName = locationName;
            _managedInstanceName = managedInstanceName;
            _databaseName = databaseName;
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceGroupLongTermRetentionManagedInstanceBackup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceGroupLongTermRetentionManagedInstanceBackup.ResourceType, out string resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
            _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient = new LongTermRetentionManagedInstanceBackupsRestOperations(_resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackup>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Gets a long term retention backup for a managed database. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackup> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupLongTermRetentionManagedInstanceBackup> GetAllAsync(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceGroupLongTermRetentionManagedInstanceBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceGroupLongTermRetentionManagedInstanceBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_ListByResourceGroupDatabase
        /// <summary> Lists all long term retention backups for a managed database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupLongTermRetentionManagedInstanceBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupLongTermRetentionManagedInstanceBackup> GetAll(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<ResourceGroupLongTermRetentionManagedInstanceBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabase(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceGroupLongTermRetentionManagedInstanceBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.ListByResourceGroupDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<ResourceGroupLongTermRetentionManagedInstanceBackup>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourceGroupLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionManagedInstances/{managedInstanceName}/longTermRetentionDatabases/{databaseName}/longTermRetentionManagedInstanceBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: LongTermRetentionManagedInstanceBackups_GetByResourceGroup
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<ResourceGroupLongTermRetentionManagedInstanceBackup> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionManagedInstanceBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionManagedInstanceBackupLongTermRetentionManagedInstanceBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, _locationName, _managedInstanceName, _databaseName, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourceGroupLongTermRetentionManagedInstanceBackup>(null, response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionManagedInstanceBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackup> IEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupLongTermRetentionManagedInstanceBackup> IAsyncEnumerable<ResourceGroupLongTermRetentionManagedInstanceBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
