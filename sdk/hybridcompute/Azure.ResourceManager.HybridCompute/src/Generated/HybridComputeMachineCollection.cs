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
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputeMachineResource" /> and their operations.
    /// Each <see cref="HybridComputeMachineResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HybridComputeMachineCollection" /> instance call the GetHybridComputeMachines method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HybridComputeMachineCollection : ArmCollection, IEnumerable<HybridComputeMachineResource>, IAsyncEnumerable<HybridComputeMachineResource>
    {
        private readonly ClientDiagnostics _hybridComputeMachineMachinesClientDiagnostics;
        private readonly MachinesRestOperations _hybridComputeMachineMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridComputeMachineCollection"/> class for mocking. </summary>
        protected HybridComputeMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputeMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridComputeMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridComputeMachineMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputeMachineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputeMachineResource.ResourceType, out string hybridComputeMachineMachinesApiVersion);
            _hybridComputeMachineMachinesRestClient = new MachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputeMachineMachinesApiVersion);
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
        /// The operation to create or update a hybrid machine. Please note some properties can be set only during machine creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="data"> Parameters supplied to the Create hybrid machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridComputeMachineResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string machineName, HybridComputeMachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineMachinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, machineName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridComputeArmOperation<HybridComputeMachineResource>(Response.FromValue(new HybridComputeMachineResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a hybrid machine. Please note some properties can be set only during machine creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="data"> Parameters supplied to the Create hybrid machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridComputeMachineResource> CreateOrUpdate(WaitUntil waitUntil, string machineName, HybridComputeMachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineMachinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, machineName, data, cancellationToken);
                var operation = new HybridComputeArmOperation<HybridComputeMachineResource>(Response.FromValue(new HybridComputeMachineResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_Get
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual async Task<Response<HybridComputeMachineResource>> GetAsync(string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, machineName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a hybrid machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_Get
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual Response<HybridComputeMachineResource> Get(string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, machineName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the hybrid machines in the specified resource group. Use the nextLink property in the response to get the next page of hybrid machines.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines
        /// Operation Id: Machines_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputeMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridComputeMachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridComputeMachineMachinesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridComputeMachineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridComputeMachineMachinesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the hybrid machines in the specified resource group. Use the nextLink property in the response to get the next page of hybrid machines.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines
        /// Operation Id: Machines_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputeMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HybridComputeMachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridComputeMachineMachinesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridComputeMachineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridComputeMachineMachinesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridComputeMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_Get
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputeMachineMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, machineName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/machines/{machineName}
        /// Operation Id: Machines_Get
        /// </summary>
        /// <param name="machineName"> The name of the hybrid machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="machineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual Response<bool> Exists(string machineName, InstanceViewType? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));

            using var scope = _hybridComputeMachineMachinesClientDiagnostics.CreateScope("HybridComputeMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputeMachineMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, machineName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputeMachineResource> IEnumerable<HybridComputeMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputeMachineResource> IAsyncEnumerable<HybridComputeMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
