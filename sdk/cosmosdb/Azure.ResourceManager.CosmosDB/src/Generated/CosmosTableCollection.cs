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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CosmosTable and their operations over its parent. </summary>
    public partial class CosmosTableCollection : ArmCollection, IEnumerable<CosmosTable>, IAsyncEnumerable<CosmosTable>
    {
        private readonly ClientDiagnostics _cosmosTableTableResourcesClientDiagnostics;
        private readonly TableResourcesRestOperations _cosmosTableTableResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosTableCollection"/> class for mocking. </summary>
        protected CosmosTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosTableCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CosmosTableCollection(ArmResource parent) : base(parent)
        {
            _cosmosTableTableResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosTable.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(CosmosTable.ResourceType, out string cosmosTableTableResourcesApiVersion);
            _cosmosTableTableResourcesRestClient = new TableResourcesRestOperations(_cosmosTableTableResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cosmosTableTableResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccount.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public virtual CosmosTableCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string tableName, TableCreateUpdateOptions createUpdateTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            if (createUpdateTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateTableParameters));
            }

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.CreateUpdateTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken);
                var operation = new CosmosTableCreateOrUpdateOperation(ArmClient, _cosmosTableTableResourcesClientDiagnostics, Pipeline, _cosmosTableTableResourcesRestClient.CreateCreateUpdateTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an Azure Cosmos DB Table. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="createUpdateTableParameters"> The parameters to provide for the current Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="createUpdateTableParameters"/> is null. </exception>
        public async virtual Task<CosmosTableCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string tableName, TableCreateUpdateOptions createUpdateTableParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            if (createUpdateTableParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateTableParameters));
            }

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.CreateUpdateTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosTableCreateOrUpdateOperation(ArmClient, _cosmosTableTableResourcesClientDiagnostics, Pipeline, _cosmosTableTableResourcesRestClient.CreateCreateUpdateTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, createUpdateTableParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Tables under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CosmosTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.GetTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw _cosmosTableTableResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Tables under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CosmosTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.GetTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _cosmosTableTableResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CosmosTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CosmosTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosTableTableResourcesRestClient.GetTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CosmosTable>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<CosmosTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosTableTableResourcesRestClient.GetTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CosmosTable>(null, response.GetRawResponse());
                return Response.FromValue(new CosmosTable(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Tables under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CosmosTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cosmosTableTableResourcesRestClient.ListTables(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosTable(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Tables under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CosmosTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cosmosTableTableResourcesClientDiagnostics.CreateScope("CosmosTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cosmosTableTableResourcesRestClient.ListTablesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CosmosTable(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<CosmosTable> IEnumerable<CosmosTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosTable> IAsyncEnumerable<CosmosTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
