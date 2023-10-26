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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppJobExecutionResource" /> and their operations.
    /// Each <see cref="ContainerAppJobExecutionResource" /> in the collection will belong to the same instance of <see cref="JobResource" />.
    /// To get a <see cref="ContainerAppJobExecutionCollection" /> instance call the GetContainerAppJobExecutions method from an instance of <see cref="JobResource" />.
    /// </summary>
    public partial class ContainerAppJobExecutionCollection : ArmCollection, IEnumerable<ContainerAppJobExecutionResource>, IAsyncEnumerable<ContainerAppJobExecutionResource>
    {
        private readonly ClientDiagnostics _containerAppJobExecutionClientDiagnostics;
        private readonly ContainerAppsAPIRestOperations _containerAppJobExecutionRestClient;
        private readonly ClientDiagnostics _containerAppJobExecutionJobsExecutionsClientDiagnostics;
        private readonly JobsExecutionsRestOperations _containerAppJobExecutionJobsExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobExecutionCollection"/> class for mocking. </summary>
        protected ContainerAppJobExecutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppJobExecutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppJobExecutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppJobExecutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppJobExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppJobExecutionResource.ResourceType, out string containerAppJobExecutionApiVersion);
            _containerAppJobExecutionRestClient = new ContainerAppsAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppJobExecutionApiVersion);
            _containerAppJobExecutionJobsExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppJobExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppJobExecutionResource.ResourceType, out string containerAppJobExecutionJobsExecutionsApiVersion);
            _containerAppJobExecutionJobsExecutionsRestClient = new JobsExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppJobExecutionJobsExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != JobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, JobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get details of a single job execution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppJobExecutionResource>> GetAsync(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppJobExecutionRestClient.JobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a single job execution
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual Response<ContainerAppJobExecutionResource> Get(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppJobExecutionRestClient.JobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Container Apps Job's executions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobsExecutions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppJobExecutionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppJobExecutionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppJobExecutionJobsExecutionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppJobExecutionJobsExecutionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppJobExecutionResource(Client, ContainerAppJobExecutionData.DeserializeContainerAppJobExecutionData(e)), _containerAppJobExecutionJobsExecutionsClientDiagnostics, Pipeline, "ContainerAppJobExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a Container Apps Job's executions
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobsExecutions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppJobExecutionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppJobExecutionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppJobExecutionJobsExecutionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppJobExecutionJobsExecutionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppJobExecutionResource(Client, ContainerAppJobExecutionData.DeserializeContainerAppJobExecutionData(e)), _containerAppJobExecutionJobsExecutionsClientDiagnostics, Pipeline, "ContainerAppJobExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppJobExecutionRestClient.JobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual Response<bool> Exists(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppJobExecutionRestClient.JobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppJobExecutionResource>> GetIfExistsAsync(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppJobExecutionRestClient.JobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppJobExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}/executions/{jobExecutionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobExecution</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobExecutionName"> Job execution name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobExecutionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobExecutionName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppJobExecutionResource> GetIfExists(string jobExecutionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(jobExecutionName, nameof(jobExecutionName));

            using var scope = _containerAppJobExecutionClientDiagnostics.CreateScope("ContainerAppJobExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppJobExecutionRestClient.JobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, jobExecutionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppJobExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppJobExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppJobExecutionResource> IEnumerable<ContainerAppJobExecutionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppJobExecutionResource> IAsyncEnumerable<ContainerAppJobExecutionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
