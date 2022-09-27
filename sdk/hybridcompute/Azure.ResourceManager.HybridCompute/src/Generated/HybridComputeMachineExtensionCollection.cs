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

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputeMachineExtensionResource" /> and their operations.
    /// Each <see cref="HybridComputeMachineExtensionResource" /> in the collection will belong to the same instance of <see cref="HybridComputeMachineResource" />.
    /// To get a <see cref="HybridComputeMachineExtensionCollection" /> instance call the GetHybridComputeMachineExtensions method from an instance of <see cref="HybridComputeMachineResource" />.
    /// </summary>
    public partial class HybridComputeMachineExtensionCollection : ArmCollection, IEnumerable<HybridComputeMachineExtensionResource>, IAsyncEnumerable<HybridComputeMachineExtensionResource>
    {
        private readonly ClientDiagnostics _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics;
        private readonly MachineExtensionsRestOperations _hybridComputeMachineExtensionMachineExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridComputeMachineExtensionCollection"/> class for mocking. </summary>
        protected HybridComputeMachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputeMachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridComputeMachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputeMachineExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputeMachineExtensionResource.ResourceType, out string hybridComputeMachineExtensionMachineExtensionsApiVersion);
            _hybridComputeMachineExtensionMachineExtensionsRestClient = new MachineExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputeMachineExtensionMachineExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HybridComputeMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HybridComputeMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridComputeMachineExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, HybridComputeMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineExtensionMachineExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridComputeArmOperation<HybridComputeMachineExtensionResource>(new HybridComputeMachineExtensionOperationSource(Client), _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, _hybridComputeMachineExtensionMachineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridComputeMachineExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionName, HybridComputeMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineExtensionMachineExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken);
                var operation = new HybridComputeArmOperation<HybridComputeMachineExtensionResource>(new HybridComputeMachineExtensionOperationSource(Client), _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, _hybridComputeMachineExtensionMachineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<HybridComputeMachineExtensionResource>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineExtensionMachineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<HybridComputeMachineExtensionResource> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineExtensionMachineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of a non-Azure machine
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions
        /// Operation Id: MachineExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputeMachineExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridComputeMachineExtensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridComputeMachineExtensionMachineExtensionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridComputeMachineExtensionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridComputeMachineExtensionMachineExtensionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The operation to get all extensions of a non-Azure machine
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions
        /// Operation Id: MachineExtensions_List
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputeMachineExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<HybridComputeMachineExtensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridComputeMachineExtensionMachineExtensionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridComputeMachineExtensionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridComputeMachineExtensionMachineExtensionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineExtensionMachineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}/extensions/{extensionName}
        /// Operation Id: MachineExtensions_Get
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hybridComputeMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HybridComputeMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineExtensionMachineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputeMachineExtensionResource> IEnumerable<HybridComputeMachineExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputeMachineExtensionResource> IAsyncEnumerable<HybridComputeMachineExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
