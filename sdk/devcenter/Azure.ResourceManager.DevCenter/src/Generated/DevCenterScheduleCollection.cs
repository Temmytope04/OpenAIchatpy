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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterScheduleResource" /> and their operations.
    /// Each <see cref="DevCenterScheduleResource" /> in the collection will belong to the same instance of <see cref="DevCenterPoolResource" />.
    /// To get a <see cref="DevCenterScheduleCollection" /> instance call the GetDevCenterSchedules method from an instance of <see cref="DevCenterPoolResource" />.
    /// </summary>
    public partial class DevCenterScheduleCollection : ArmCollection, IEnumerable<DevCenterScheduleResource>, IAsyncEnumerable<DevCenterScheduleResource>
    {
        private readonly ClientDiagnostics _devCenterScheduleSchedulesClientDiagnostics;
        private readonly SchedulesRestOperations _devCenterScheduleSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterScheduleCollection"/> class for mocking. </summary>
        protected DevCenterScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterScheduleSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterScheduleResource.ResourceType, out string devCenterScheduleSchedulesApiVersion);
            _devCenterScheduleSchedulesRestClient = new SchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterScheduleSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="data"> Represents a scheduled task. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scheduleName, DevCenterScheduleData data, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterScheduleSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, data, top, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterScheduleResource>(new DevCenterScheduleOperationSource(Client), _devCenterScheduleSchedulesClientDiagnostics, Pipeline, _devCenterScheduleSchedulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, data, top).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="data"> Represents a scheduled task. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string scheduleName, DevCenterScheduleData data, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterScheduleSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, data, top, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterScheduleResource>(new DevCenterScheduleOperationSource(Client), _devCenterScheduleSchedulesClientDiagnostics, Pipeline, _devCenterScheduleSchedulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, data, top).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a schedule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<DevCenterScheduleResource>> GetAsync(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a schedule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<DevCenterScheduleResource> Get(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists schedules for a pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_ListByPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterScheduleResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterScheduleSchedulesRestClient.CreateListByPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterScheduleSchedulesRestClient.CreateListByPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevCenterScheduleResource(Client, DevCenterScheduleData.DeserializeDevCenterScheduleData(e)), _devCenterScheduleSchedulesClientDiagnostics, Pipeline, "DevCenterScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists schedules for a pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_ListByPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterScheduleResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterScheduleSchedulesRestClient.CreateListByPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterScheduleSchedulesRestClient.CreateListByPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevCenterScheduleResource(Client, DevCenterScheduleData.DeserializeDevCenterScheduleData(e)), _devCenterScheduleSchedulesClientDiagnostics, Pipeline, "DevCenterScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<DevCenterScheduleResource>> GetIfExistsAsync(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devCenterScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it. </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        public virtual NullableResponse<DevCenterScheduleResource> GetIfExists(string scheduleName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scheduleName, nameof(scheduleName));

            using var scope = _devCenterScheduleSchedulesClientDiagnostics.CreateScope("DevCenterScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devCenterScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scheduleName, top, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevCenterScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new DevCenterScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterScheduleResource> IEnumerable<DevCenterScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterScheduleResource> IAsyncEnumerable<DevCenterScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
