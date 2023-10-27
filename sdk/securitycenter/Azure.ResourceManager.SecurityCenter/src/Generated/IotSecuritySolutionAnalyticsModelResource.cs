// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an IotSecuritySolutionAnalyticsModel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="IotSecuritySolutionAnalyticsModelResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetIotSecuritySolutionAnalyticsModelResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotSecuritySolutionResource" /> using the GetIotSecuritySolutionAnalyticsModel method.
    /// </summary>
    public partial class IotSecuritySolutionAnalyticsModelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotSecuritySolutionAnalyticsModelResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string solutionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsClientDiagnostics;
        private readonly IotSecuritySolutionAnalyticsRestOperations _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsRestClient;
        private readonly IotSecuritySolutionAnalyticsModelData _data;

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionAnalyticsModelResource"/> class for mocking. </summary>
        protected IotSecuritySolutionAnalyticsModelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IotSecuritySolutionAnalyticsModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotSecuritySolutionAnalyticsModelResource(ArmClient client, IotSecuritySolutionAnalyticsModelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecuritySolutionAnalyticsModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotSecuritySolutionAnalyticsModelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsApiVersion);
            _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsRestClient = new IotSecuritySolutionAnalyticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/iotSecuritySolutions/analyticsModels";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotSecuritySolutionAnalyticsModelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of IotSecurityAggregatedAlertResources in the IotSecuritySolutionAnalyticsModel. </summary>
        /// <returns> An object representing collection of IotSecurityAggregatedAlertResources and their operations over a IotSecurityAggregatedAlertResource. </returns>
        public virtual IotSecurityAggregatedAlertCollection GetIotSecurityAggregatedAlerts()
        {
            return GetCachedClient(client => new IotSecurityAggregatedAlertCollection(client, Id));
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
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<IotSecurityAggregatedAlertResource>> GetIotSecurityAggregatedAlertAsync(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            return await GetIotSecurityAggregatedAlerts().GetAsync(aggregatedAlertName, cancellationToken).ConfigureAwait(false);
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
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedAlertName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedAlertName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<IotSecurityAggregatedAlertResource> GetIotSecurityAggregatedAlert(string aggregatedAlertName, CancellationToken cancellationToken = default)
        {
            return GetIotSecurityAggregatedAlerts().Get(aggregatedAlertName, cancellationToken);
        }

        /// <summary> Gets a collection of IotSecurityAggregatedRecommendationResources in the IotSecuritySolutionAnalyticsModel. </summary>
        /// <returns> An object representing collection of IotSecurityAggregatedRecommendationResources and their operations over a IotSecurityAggregatedRecommendationResource. </returns>
        public virtual IotSecurityAggregatedRecommendationCollection GetIotSecurityAggregatedRecommendations()
        {
            return GetCachedClient(client => new IotSecurityAggregatedRecommendationCollection(client, Id));
        }

        /// <summary>
        /// Use this method to get the aggregated security analytics recommendation of yours IoT Security solution. This aggregation is performed by recommendation name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedRecommendations/{aggregatedRecommendationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsRecommendation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedRecommendationName"> Name of the recommendation aggregated for this query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedRecommendationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedRecommendationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<IotSecurityAggregatedRecommendationResource>> GetIotSecurityAggregatedRecommendationAsync(string aggregatedRecommendationName, CancellationToken cancellationToken = default)
        {
            return await GetIotSecurityAggregatedRecommendations().GetAsync(aggregatedRecommendationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to get the aggregated security analytics recommendation of yours IoT Security solution. This aggregation is performed by recommendation name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedRecommendations/{aggregatedRecommendationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionsAnalyticsRecommendation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="aggregatedRecommendationName"> Name of the recommendation aggregated for this query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregatedRecommendationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aggregatedRecommendationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<IotSecurityAggregatedRecommendationResource> GetIotSecurityAggregatedRecommendation(string aggregatedRecommendationName, CancellationToken cancellationToken = default)
        {
            return GetIotSecurityAggregatedRecommendations().Get(aggregatedRecommendationName, cancellationToken);
        }

        /// <summary>
        /// Use this method to get IoT Security Analytics metrics.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionAnalytics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotSecuritySolutionAnalyticsModelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsClientDiagnostics.CreateScope("IotSecuritySolutionAnalyticsModelResource.Get");
            scope.Start();
            try
            {
                var response = await _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionAnalyticsModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to get IoT Security Analytics metrics.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotSecuritySolutionAnalytics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotSecuritySolutionAnalyticsModelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsClientDiagnostics.CreateScope("IotSecuritySolutionAnalyticsModelResource.Get");
            scope.Start();
            try
            {
                var response = _iotSecuritySolutionAnalyticsModelIotSecuritySolutionAnalyticsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotSecuritySolutionAnalyticsModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
