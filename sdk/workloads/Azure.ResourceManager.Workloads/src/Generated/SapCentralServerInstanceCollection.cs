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

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing a collection of <see cref="SapCentralServerInstanceResource" /> and their operations.
    /// Each <see cref="SapCentralServerInstanceResource" /> in the collection will belong to the same instance of <see cref="SapVirtualInstanceResource" />.
    /// To get a <see cref="SapCentralServerInstanceCollection" /> instance call the GetSapCentralServerInstances method from an instance of <see cref="SapVirtualInstanceResource" />.
    /// </summary>
    public partial class SapCentralServerInstanceCollection : ArmCollection, IEnumerable<SapCentralServerInstanceResource>, IAsyncEnumerable<SapCentralServerInstanceResource>
    {
        private readonly ClientDiagnostics _sapCentralServerInstanceSapCentralInstancesClientDiagnostics;
        private readonly SAPCentralInstancesRestOperations _sapCentralServerInstanceSapCentralInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapCentralServerInstanceCollection"/> class for mocking. </summary>
        protected SapCentralServerInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapCentralServerInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapCentralServerInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapCentralServerInstanceSapCentralInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", SapCentralServerInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapCentralServerInstanceResource.ResourceType, out string sapCentralServerInstanceSapCentralInstancesApiVersion);
            _sapCentralServerInstanceSapCentralInstancesRestClient = new SAPCentralInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapCentralServerInstanceSapCentralInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SapVirtualInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SapVirtualInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Puts the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual async Task<ArmOperation<SapCentralServerInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string centralInstanceName, SapCentralServerInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapCentralServerInstanceSapCentralInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<SapCentralServerInstanceResource>(new SapCentralServerInstanceOperationSource(Client), _sapCentralServerInstanceSapCentralInstancesClientDiagnostics, Pipeline, _sapCentralServerInstanceSapCentralInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual ArmOperation<SapCentralServerInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string centralInstanceName, SapCentralServerInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapCentralServerInstanceSapCentralInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, data, cancellationToken);
                var operation = new WorkloadsArmOperation<SapCentralServerInstanceResource>(new SapCentralServerInstanceOperationSource(Client), _sapCentralServerInstanceSapCentralInstancesClientDiagnostics, Pipeline, _sapCentralServerInstanceSapCentralInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the SAP Central Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Get
        /// </summary>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual async Task<Response<SapCentralServerInstanceResource>> GetAsync(string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapCentralServerInstanceSapCentralInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapCentralServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SAP Central Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Get
        /// </summary>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual Response<SapCentralServerInstanceResource> Get(string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _sapCentralServerInstanceSapCentralInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapCentralServerInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SAP Central Instances in an SVI.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances
        /// Operation Id: SAPCentralInstances_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapCentralServerInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapCentralServerInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SapCentralServerInstanceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sapCentralServerInstanceSapCentralInstancesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SapCentralServerInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SapCentralServerInstanceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sapCentralServerInstanceSapCentralInstancesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SapCentralServerInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the SAP Central Instances in an SVI.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances
        /// Operation Id: SAPCentralInstances_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapCentralServerInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapCentralServerInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SapCentralServerInstanceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sapCentralServerInstanceSapCentralInstancesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SapCentralServerInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SapCentralServerInstanceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sapCentralServerInstanceSapCentralInstancesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SapCentralServerInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Get
        /// </summary>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapCentralServerInstanceSapCentralInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/centralInstances/{centralInstanceName}
        /// Operation Id: SAPCentralInstances_Get
        /// </summary>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="centralInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var scope = _sapCentralServerInstanceSapCentralInstancesClientDiagnostics.CreateScope("SapCentralServerInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapCentralServerInstanceSapCentralInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, centralInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapCentralServerInstanceResource> IEnumerable<SapCentralServerInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapCentralServerInstanceResource> IAsyncEnumerable<SapCentralServerInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
