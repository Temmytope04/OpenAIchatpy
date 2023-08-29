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
    /// A class representing a collection of <see cref="ManagedInstanceStartStopScheduleResource" /> and their operations.
    /// Each <see cref="ManagedInstanceStartStopScheduleResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstanceStartStopScheduleCollection" /> instance call the GetManagedInstanceStartStopSchedules method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstanceStartStopScheduleCollection : ArmCollection, IEnumerable<ManagedInstanceStartStopScheduleResource>, IAsyncEnumerable<ManagedInstanceStartStopScheduleResource>
    {
        private readonly ClientDiagnostics _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics;
        private readonly StartStopManagedInstanceSchedulesRestOperations _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceStartStopScheduleCollection"/> class for mocking. </summary>
        protected ManagedInstanceStartStopScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceStartStopScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceStartStopScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceStartStopScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceStartStopScheduleResource.ResourceType, out string managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesApiVersion);
            _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient = new StartStopManagedInstanceSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the managed instance's Start/Stop schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="data"> The requested managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceStartStopScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedInstanceStartStopScheduleName startStopScheduleName, ManagedInstanceStartStopScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceStartStopScheduleResource>(Response.FromValue(new ManagedInstanceStartStopScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the managed instance's Start/Stop schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="data"> The requested managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceStartStopScheduleResource> CreateOrUpdate(WaitUntil waitUntil, ManagedInstanceStartStopScheduleName startStopScheduleName, ManagedInstanceStartStopScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceStartStopScheduleResource>(Response.FromValue(new ManagedInstanceStartStopScheduleResource(Client, response), response.GetRawResponse()));
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
        /// Gets the managed instance's Start/Stop schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceStartStopScheduleResource>> GetAsync(ManagedInstanceStartStopScheduleName startStopScheduleName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceStartStopScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the managed instance's Start/Stop schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceStartStopScheduleResource> Get(ManagedInstanceStartStopScheduleName startStopScheduleName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceStartStopScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the managed instance's Start/Stop schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceStartStopScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceStartStopScheduleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceStartStopScheduleResource(Client, ManagedInstanceStartStopScheduleData.DeserializeManagedInstanceStartStopScheduleData(e)), _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics, Pipeline, "ManagedInstanceStartStopScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the managed instance's Start/Stop schedules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceStartStopScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceStartStopScheduleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedInstanceStartStopScheduleResource(Client, ManagedInstanceStartStopScheduleData.DeserializeManagedInstanceStartStopScheduleData(e)), _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics, Pipeline, "ManagedInstanceStartStopScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedInstanceStartStopScheduleName startStopScheduleName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/startStopSchedules/{startStopScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StartStopManagedInstanceSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="startStopScheduleName"> Name of the managed instance Start/Stop schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedInstanceStartStopScheduleName startStopScheduleName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesClientDiagnostics.CreateScope("ManagedInstanceStartStopScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceStartStopScheduleStartStopManagedInstanceSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, startStopScheduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceStartStopScheduleResource> IEnumerable<ManagedInstanceStartStopScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceStartStopScheduleResource> IAsyncEnumerable<ManagedInstanceStartStopScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
