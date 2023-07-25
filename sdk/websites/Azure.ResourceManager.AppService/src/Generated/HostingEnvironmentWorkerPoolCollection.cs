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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="HostingEnvironmentWorkerPoolResource" /> and their operations.
    /// Each <see cref="HostingEnvironmentWorkerPoolResource" /> in the collection will belong to the same instance of <see cref="AppServiceEnvironmentResource" />.
    /// To get a <see cref="HostingEnvironmentWorkerPoolCollection" /> instance call the GetHostingEnvironmentWorkerPools method from an instance of <see cref="AppServiceEnvironmentResource" />.
    /// </summary>
    public partial class HostingEnvironmentWorkerPoolCollection : ArmCollection, IEnumerable<HostingEnvironmentWorkerPoolResource>, IAsyncEnumerable<HostingEnvironmentWorkerPoolResource>
    {
        private readonly ClientDiagnostics _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolCollection"/> class for mocking. </summary>
        protected HostingEnvironmentWorkerPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostingEnvironmentWorkerPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostingEnvironmentWorkerPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", HostingEnvironmentWorkerPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostingEnvironmentWorkerPoolResource.ResourceType, out string hostingEnvironmentWorkerPoolAppServiceEnvironmentsApiVersion);
            _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostingEnvironmentWorkerPoolAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServiceEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServiceEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create or update a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdateWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="data"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HostingEnvironmentWorkerPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workerPoolName, AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateOrUpdateWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<HostingEnvironmentWorkerPoolResource>(new HostingEnvironmentWorkerPoolOperationSource(Client), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateWorkerPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Create or update a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_CreateOrUpdateWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="data"> Properties of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HostingEnvironmentWorkerPoolResource> CreateOrUpdate(WaitUntil waitUntil, string workerPoolName, AppServiceWorkerPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateOrUpdateWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, data, cancellationToken);
                var operation = new AppServiceArmOperation<HostingEnvironmentWorkerPoolResource>(new HostingEnvironmentWorkerPoolOperationSource(Client), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateCreateOrUpdateWorkerPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get properties of a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual async Task<Response<HostingEnvironmentWorkerPoolResource>> GetAsync(string workerPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get properties of a worker pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual Response<HostingEnvironmentWorkerPoolResource> Get(string workerPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostingEnvironmentWorkerPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all worker pools of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPools</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostingEnvironmentWorkerPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostingEnvironmentWorkerPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HostingEnvironmentWorkerPoolResource(Client, AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(e)), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Get all worker pools of an App Service Environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_ListWorkerPools</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostingEnvironmentWorkerPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostingEnvironmentWorkerPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.CreateListWorkerPoolsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HostingEnvironmentWorkerPoolResource(Client, AppServiceWorkerPoolData.DeserializeAppServiceWorkerPoolData(e)), _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics, Pipeline, "HostingEnvironmentWorkerPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workerPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/workerPools/{workerPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppServiceEnvironments_GetWorkerPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workerPoolName"> Name of the worker pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workerPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workerPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string workerPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workerPoolName, nameof(workerPoolName));

            using var scope = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsClientDiagnostics.CreateScope("HostingEnvironmentWorkerPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _hostingEnvironmentWorkerPoolAppServiceEnvironmentsRestClient.GetWorkerPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, workerPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostingEnvironmentWorkerPoolResource> IEnumerable<HostingEnvironmentWorkerPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostingEnvironmentWorkerPoolResource> IAsyncEnumerable<HostingEnvironmentWorkerPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
