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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceServiceTaskResource"/> and their operations.
    /// Each <see cref="ServiceServiceTaskResource"/> in the collection will belong to the same instance of <see cref="DataMigrationServiceResource"/>.
    /// To get a <see cref="ServiceServiceTaskCollection"/> instance call the GetServiceServiceTasks method from an instance of <see cref="DataMigrationServiceResource"/>.
    /// </summary>
    public partial class ServiceServiceTaskCollection : ArmCollection, IEnumerable<ServiceServiceTaskResource>, IAsyncEnumerable<ServiceServiceTaskResource>
    {
        private readonly ClientDiagnostics _serviceServiceTaskServiceTasksClientDiagnostics;
        private readonly ServiceTasksRestOperations _serviceServiceTaskServiceTasksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceServiceTaskCollection"/> class for mocking. </summary>
        protected ServiceServiceTaskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceServiceTaskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceServiceTaskCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceServiceTaskServiceTasksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", ServiceServiceTaskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceServiceTaskResource.ResourceType, out string serviceServiceTaskServiceTasksApiVersion);
            _serviceServiceTaskServiceTasksRestClient = new ServiceTasksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceServiceTaskServiceTasksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataMigrationServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataMigrationServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The service tasks resource is a nested, proxy-only resource representing work performed by a DMS instance. The PUT method creates a new service task or updates an existing one, although since service tasks have no mutable custom properties, there is little reason to update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="data"> Information about the task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceServiceTaskResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string taskName, ProjectTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceServiceTaskServiceTasksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation<ServiceServiceTaskResource>(Response.FromValue(new ServiceServiceTaskResource(Client, response), response.GetRawResponse()));
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
        /// The service tasks resource is a nested, proxy-only resource representing work performed by a DMS instance. The PUT method creates a new service task or updates an existing one, although since service tasks have no mutable custom properties, there is little reason to update an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="data"> Information about the task. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceServiceTaskResource> CreateOrUpdate(WaitUntil waitUntil, string taskName, ProjectTaskData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceServiceTaskServiceTasksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, data, cancellationToken);
                var operation = new DataMigrationArmOperation<ServiceServiceTaskResource>(Response.FromValue(new ServiceServiceTaskResource(Client, response), response.GetRawResponse()));
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
        /// The service tasks resource is a nested, proxy-only resource representing work performed by a DMS instance. The GET method retrieves information about a service task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<ServiceServiceTaskResource>> GetAsync(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceServiceTaskServiceTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The service tasks resource is a nested, proxy-only resource representing work performed by a DMS instance. The GET method retrieves information about a service task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<ServiceServiceTaskResource> Get(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceServiceTaskServiceTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The services resource is the top-level resource that represents the Database Migration Service. This method returns a list of service level tasks owned by a service resource. Some tasks may have a status of Unknown, which indicates that an error occurred while querying the status of that task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskType"> Filter tasks by task type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceServiceTaskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceServiceTaskResource> GetAllAsync(string taskType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceServiceTaskServiceTasksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceServiceTaskServiceTasksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceServiceTaskResource(Client, ProjectTaskData.DeserializeProjectTaskData(e)), _serviceServiceTaskServiceTasksClientDiagnostics, Pipeline, "ServiceServiceTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The services resource is the top-level resource that represents the Database Migration Service. This method returns a list of service level tasks owned by a service resource. Some tasks may have a status of Unknown, which indicates that an error occurred while querying the status of that task.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskType"> Filter tasks by task type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceServiceTaskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceServiceTaskResource> GetAll(string taskType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceServiceTaskServiceTasksRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceServiceTaskServiceTasksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceServiceTaskResource(Client, ProjectTaskData.DeserializeProjectTaskData(e)), _serviceServiceTaskServiceTasksClientDiagnostics, Pipeline, "ServiceServiceTaskCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceServiceTaskServiceTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual Response<bool> Exists(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceServiceTaskServiceTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceServiceTaskResource>> GetIfExistsAsync(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceServiceTaskServiceTasksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceServiceTaskResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceServiceTaskResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.DataMigration/services/{serviceName}/serviceTasks/{taskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceTasks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-30-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceServiceTaskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="taskName"> Name of the Task. </param>
        /// <param name="expand"> Expand the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="taskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="taskName"/> is null. </exception>
        public virtual NullableResponse<ServiceServiceTaskResource> GetIfExists(string taskName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(taskName, nameof(taskName));

            using var scope = _serviceServiceTaskServiceTasksClientDiagnostics.CreateScope("ServiceServiceTaskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceServiceTaskServiceTasksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, taskName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceServiceTaskResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceServiceTaskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceServiceTaskResource> IEnumerable<ServiceServiceTaskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceServiceTaskResource> IAsyncEnumerable<ServiceServiceTaskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
