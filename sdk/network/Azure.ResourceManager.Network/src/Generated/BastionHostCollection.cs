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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of BastionHost and their operations over its parent. </summary>
    public partial class BastionHostCollection : ArmCollection, IEnumerable<BastionHost>, IAsyncEnumerable<BastionHost>
    {
        private readonly ClientDiagnostics _bastionHostClientDiagnostics;
        private readonly BastionHostsRestOperations _bastionHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class for mocking. </summary>
        protected BastionHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BastionHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bastionHostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BastionHost.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(BastionHost.ResourceType, out string bastionHostApiVersion);
            _bastionHostRestClient = new BastionHostsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, bastionHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Bastion Host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<BastionHost>> CreateOrUpdateAsync(WaitUntil waitUntil, string bastionHostName, BastionHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BastionHost>(new BastionHostOperationSource(Client), _bastionHostClientDiagnostics, Pipeline, _bastionHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified Bastion Host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<BastionHost> CreateOrUpdate(WaitUntil waitUntil, string bastionHostName, BastionHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<BastionHost>(new BastionHostOperationSource(Client), _bastionHostClientDiagnostics, Pipeline, _bastionHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified Bastion Host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<Response<BastionHost>> GetAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BastionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Bastion Host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<BastionHost> Get(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BastionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Bastion Hosts in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts
        /// Operation Id: BastionHosts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BastionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BastionHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BastionHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bastionHostRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bastionHostRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all Bastion Hosts in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts
        /// Operation Id: BastionHosts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BastionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BastionHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BastionHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bastionHostRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bastionHostRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(bastionHostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual async Task<Response<BastionHost>> GetIfExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bastionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BastionHost>(null, response.GetRawResponse());
                return Response.FromValue(new BastionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}
        /// Operation Id: BastionHosts_Get
        /// </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<BastionHost> GetIfExists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _bastionHostClientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bastionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BastionHost>(null, response.GetRawResponse());
                return Response.FromValue(new BastionHost(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BastionHost> IEnumerable<BastionHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BastionHost> IAsyncEnumerable<BastionHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
