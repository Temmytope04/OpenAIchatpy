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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteGatewayResource" /> and their operations.
    /// Each <see cref="ExpressRouteGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ExpressRouteGatewayCollection" /> instance call the GetExpressRouteGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ExpressRouteGatewayCollection : ArmCollection, IEnumerable<ExpressRouteGatewayResource>, IAsyncEnumerable<ExpressRouteGatewayResource>
    {
        private readonly ClientDiagnostics _expressRouteGatewayClientDiagnostics;
        private readonly ExpressRouteGatewaysRestOperations _expressRouteGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteGatewayCollection"/> class for mocking. </summary>
        protected ExpressRouteGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteGatewayResource.ResourceType, out string expressRouteGatewayApiVersion);
            _expressRouteGatewayRestClient = new ExpressRouteGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteGatewayApiVersion);
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
        /// Creates or updates a ExpressRoute gateway in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="data"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string expressRouteGatewayName, ExpressRouteGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteGatewayResource>(new ExpressRouteGatewayOperationSource(Client), _expressRouteGatewayClientDiagnostics, Pipeline, _expressRouteGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a ExpressRoute gateway in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="data"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string expressRouteGatewayName, ExpressRouteGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteGatewayResource>(new ExpressRouteGatewayOperationSource(Client), _expressRouteGatewayClientDiagnostics, Pipeline, _expressRouteGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Fetches the details of a ExpressRoute gateway in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_Get
        /// </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteGatewayResource>> GetAsync(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches the details of a ExpressRoute gateway in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_Get
        /// </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual Response<ExpressRouteGatewayResource> Get(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists ExpressRoute gateways in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways
        /// Operation Id: ExpressRouteGateways_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteGatewayResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteGatewayRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteGatewayResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists ExpressRoute gateways in a given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways
        /// Operation Id: ExpressRouteGateways_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteGatewayResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteGatewayRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteGatewayResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_Get
        /// </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}
        /// Operation Id: ExpressRouteGateways_Get
        /// </summary>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRouteGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRouteGatewayName, nameof(expressRouteGatewayName));

            using var scope = _expressRouteGatewayClientDiagnostics.CreateScope("ExpressRouteGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRouteGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteGatewayResource> IEnumerable<ExpressRouteGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteGatewayResource> IAsyncEnumerable<ExpressRouteGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
