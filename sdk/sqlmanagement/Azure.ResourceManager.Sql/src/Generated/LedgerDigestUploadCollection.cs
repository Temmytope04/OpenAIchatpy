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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="LedgerDigestUploadResource" /> and their operations.
    /// Each <see cref="LedgerDigestUploadResource" /> in the collection will belong to the same instance of <see cref="SqlDatabaseResource" />.
    /// To get a <see cref="LedgerDigestUploadCollection" /> instance call the GetLedgerDigestUploads method from an instance of <see cref="SqlDatabaseResource" />.
    /// </summary>
    public partial class LedgerDigestUploadCollection : ArmCollection, IEnumerable<LedgerDigestUploadResource>, IAsyncEnumerable<LedgerDigestUploadResource>
    {
        private readonly ClientDiagnostics _ledgerDigestUploadClientDiagnostics;
        private readonly LedgerDigestUploadsRestOperations _ledgerDigestUploadRestClient;

        /// <summary> Initializes a new instance of the <see cref="LedgerDigestUploadCollection"/> class for mocking. </summary>
        protected LedgerDigestUploadCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LedgerDigestUploadCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LedgerDigestUploadCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ledgerDigestUploadClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", LedgerDigestUploadResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LedgerDigestUploadResource.ResourceType, out string ledgerDigestUploadApiVersion);
            _ledgerDigestUploadRestClient = new LedgerDigestUploadsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ledgerDigestUploadApiVersion);
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
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="data"> The LedgerDigestUpload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LedgerDigestUploadResource>> CreateOrUpdateAsync(WaitUntil waitUntil, LedgerDigestUploadsName ledgerDigestUploads, LedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ledgerDigestUploadRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LedgerDigestUploadResource>(new LedgerDigestUploadOperationSource(Client), _ledgerDigestUploadClientDiagnostics, Pipeline, _ledgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data).Request, response, OperationFinalStateVia.Location);
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
        /// Enables upload ledger digests to an Azure Storage account or an Azure Confidential Ledger instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="data"> The LedgerDigestUpload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LedgerDigestUploadResource> CreateOrUpdate(WaitUntil waitUntil, LedgerDigestUploadsName ledgerDigestUploads, LedgerDigestUploadData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ledgerDigestUploadRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data, cancellationToken);
                var operation = new SqlArmOperation<LedgerDigestUploadResource>(new LedgerDigestUploadOperationSource(Client), _ledgerDigestUploadClientDiagnostics, Pipeline, _ledgerDigestUploadRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the current ledger digest upload configuration for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LedgerDigestUploadResource>> GetAsync(LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.Get");
            scope.Start();
            try
            {
                var response = await _ledgerDigestUploadRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LedgerDigestUploadResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current ledger digest upload configuration for a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LedgerDigestUploadResource> Get(LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.Get");
            scope.Start();
            try
            {
                var response = _ledgerDigestUploadRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LedgerDigestUploadResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LedgerDigestUploadResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LedgerDigestUploadResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ledgerDigestUploadRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ledgerDigestUploadRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LedgerDigestUploadResource(Client, LedgerDigestUploadData.DeserializeLedgerDigestUploadData(e)), _ledgerDigestUploadClientDiagnostics, Pipeline, "LedgerDigestUploadCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all ledger digest upload settings on a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LedgerDigestUploadResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LedgerDigestUploadResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _ledgerDigestUploadRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _ledgerDigestUploadRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LedgerDigestUploadResource(Client, LedgerDigestUploadData.DeserializeLedgerDigestUploadData(e)), _ledgerDigestUploadClientDiagnostics, Pipeline, "LedgerDigestUploadCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ledgerDigestUploadRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/ledgerDigestUploads/{ledgerDigestUploads}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LedgerDigestUploads_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ledgerDigestUploads"> The LedgerDigestUploadsName to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(LedgerDigestUploadsName ledgerDigestUploads, CancellationToken cancellationToken = default)
        {
            using var scope = _ledgerDigestUploadClientDiagnostics.CreateScope("LedgerDigestUploadCollection.Exists");
            scope.Start();
            try
            {
                var response = _ledgerDigestUploadRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ledgerDigestUploads, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LedgerDigestUploadResource> IEnumerable<LedgerDigestUploadResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LedgerDigestUploadResource> IAsyncEnumerable<LedgerDigestUploadResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
