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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="IotSecurityAggregatedAlertResource" /> and their operations.
    /// Each <see cref="IotSecurityAggregatedAlertResource" /> in the collection will belong to the same instance of <see cref="IotSecuritySolutionAnalyticsModelResource" />.
    /// To get an <see cref="IotSecurityAggregatedAlertCollection" /> instance call the GetIotSecurityAggregatedAlerts method from an instance of <see cref="IotSecuritySolutionAnalyticsModelResource" />.
    /// </summary>
    public partial class IotSecurityAggregatedAlertCollection : ArmCollection, IEnumerable<IotSecurityAggregatedAlertResource>, IAsyncEnumerable<IotSecurityAggregatedAlertResource>
    {
        private readonly ClientDiagnostics _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics;
        private readonly IotSecuritySolutionsAnalyticsAggregatedAlertRestOperations _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotSecurityAggregatedAlertCollection"/> class for mocking. </summary>
        protected IotSecurityAggregatedAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecurityAggregatedAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotSecurityAggregatedAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", IotSecurityAggregatedAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotSecurityAggregatedAlertResource.ResourceType, out string iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertApiVersion);
            _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient = new IotSecuritySolutionsAnalyticsAggregatedAlertRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotSecuritySolutionAnalyticsModelResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotSecuritySolutionAnalyticsModelResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Use this method to get a single the aggregated alert of yours IoT Security solution. This aggregation is performed by alert name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedAlertName"> Identifier of the aggregated alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        public virtual async Task<Response<IotSecurityAggregatedAlertResource>> GetAsync(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aggregatedAlertName, nameof(aggregatedAlertName));

            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aggregatedAlertName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecurityAggregatedAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to get a single the aggregated alert of yours IoT Security solution. This aggregation is performed by alert name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedAlertName"> Identifier of the aggregated alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        public virtual Response<IotSecurityAggregatedAlertResource> Get(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aggregatedAlertName, nameof(aggregatedAlertName));

            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aggregatedAlertName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecurityAggregatedAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to get the aggregated alert list of yours IoT Security solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of results to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotSecurityAggregatedAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotSecurityAggregatedAlertResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotSecurityAggregatedAlertResource(Client, IotSecurityAggregatedAlertData.DeserializeIotSecurityAggregatedAlertData(e)), _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics, Pipeline, "IotSecurityAggregatedAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Use this method to get the aggregated alert list of yours IoT Security solution.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of results to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotSecurityAggregatedAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotSecurityAggregatedAlertResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotSecurityAggregatedAlertResource(Client, IotSecurityAggregatedAlertData.DeserializeIotSecurityAggregatedAlertData(e)), _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics, Pipeline, "IotSecurityAggregatedAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedAlertName"> Identifier of the aggregated alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aggregatedAlertName, nameof(aggregatedAlertName));

            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aggregatedAlertName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsAggregatedAlert_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedAlertName"> Identifier of the aggregated alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        public virtual Response<bool> Exists(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(aggregatedAlertName, nameof(aggregatedAlertName));

            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aggregatedAlertName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotSecurityAggregatedAlertResource> IEnumerable<IotSecurityAggregatedAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotSecurityAggregatedAlertResource> IAsyncEnumerable<IotSecurityAggregatedAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
