// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="DatabaseAdvancedThreatProtectionResource" /> and their operations.
    /// Each <see cref="DatabaseAdvancedThreatProtectionResource" /> in the collection will belong to the same instance of <see cref="SqlDatabaseResource" />.
    /// To get a <see cref="DatabaseAdvancedThreatProtectionCollection" /> instance call the GetDatabaseAdvancedThreatProtections method from an instance of <see cref="SqlDatabaseResource" />.
    /// </summary>
    public partial class DatabaseAdvancedThreatProtectionCollection : ArmCollection, IEnumerable<DatabaseAdvancedThreatProtectionResource>, IAsyncEnumerable<DatabaseAdvancedThreatProtectionResource>
    {
        private readonly ClientDiagnostics _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly DatabaseAdvancedThreatProtectionSettingsRestOperations _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAdvancedThreatProtectionCollection"/> class for mocking. </summary>
        protected DatabaseAdvancedThreatProtectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAdvancedThreatProtectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatabaseAdvancedThreatProtectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DatabaseAdvancedThreatProtectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatabaseAdvancedThreatProtectionResource.ResourceType, out string databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsApiVersion);
            _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient = new DatabaseAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseAdvancedThreatProtectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, DatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<DatabaseAdvancedThreatProtectionResource>(Response.FromValue(new DatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The database Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseAdvancedThreatProtectionResource> CreateOrUpdate(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, DatabaseAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, data, cancellationToken);
                var operation = new SqlArmOperation<DatabaseAdvancedThreatProtectionResource>(Response.FromValue(new DatabaseAdvancedThreatProtectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseAdvancedThreatProtectionResource>> GetAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAdvancedThreatProtectionResource> Get(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseAdvancedThreatProtectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseAdvancedThreatProtectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DatabaseAdvancedThreatProtectionResource(Client, DatabaseAdvancedThreatProtectionData.DeserializeDatabaseAdvancedThreatProtectionData(e)), _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "DatabaseAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of database's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseAdvancedThreatProtectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseAdvancedThreatProtectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DatabaseAdvancedThreatProtectionResource(Client, DatabaseAdvancedThreatProtectionData.DeserializeDatabaseAdvancedThreatProtectionData(e)), _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "DatabaseAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("DatabaseAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _databaseAdvancedThreatProtectionDatabaseAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatabaseAdvancedThreatProtectionResource> IEnumerable<DatabaseAdvancedThreatProtectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatabaseAdvancedThreatProtectionResource> IAsyncEnumerable<DatabaseAdvancedThreatProtectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
