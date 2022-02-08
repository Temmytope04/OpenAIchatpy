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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of RestorableDatabaseAccount and their operations over its parent. </summary>
    public partial class RestorableDatabaseAccountCollection : ArmCollection, IEnumerable<RestorableDatabaseAccount>, IAsyncEnumerable<RestorableDatabaseAccount>
    {
        private readonly ClientDiagnostics _restorableDatabaseAccountClientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class for mocking. </summary>
        protected RestorableDatabaseAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorableDatabaseAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDatabaseAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", RestorableDatabaseAccount.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(RestorableDatabaseAccount.ResourceType, out string restorableDatabaseAccountApiVersion);
            _restorableDatabaseAccountRestClient = new RestorableDatabaseAccountsRestOperations(_restorableDatabaseAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorableDatabaseAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBLocation.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBLocation.ResourceType), nameof(id));
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountRestClient.GetByLocationAsync(Id.SubscriptionId, Id.Name, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _restorableDatabaseAccountClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountRestClient.GetByLocation(Id.SubscriptionId, Id.Name, instanceId, cancellationToken);
                if (response.Value == null)
                    throw _restorableDatabaseAccountClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDatabaseAccount> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableDatabaseAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDatabaseAccountRestClient.ListByLocationAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDatabaseAccount> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorableDatabaseAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDatabaseAccountRestClient.ListByLocation(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetIfExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountRestClient.GetByLocationAsync(Id.SubscriptionId, Id.Name, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> GetIfExists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountRestClient.GetByLocation(Id.SubscriptionId, Id.Name, instanceId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableDatabaseAccount> IEnumerable<RestorableDatabaseAccount>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDatabaseAccount> IAsyncEnumerable<RestorableDatabaseAccount>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
