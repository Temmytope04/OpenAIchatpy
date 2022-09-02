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
    /// A Class representing an IotSecurityAggregatedAlert along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="IotSecurityAggregatedAlertResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetIotSecurityAggregatedAlertResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotSecuritySolutionAnalyticsModelResource" /> using the GetIotSecurityAggregatedAlert method.
    /// </summary>
    public partial class IotSecurityAggregatedAlertResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotSecurityAggregatedAlertResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string solutionName, string aggregatedAlertName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics;
        private readonly IotSecuritySolutionsAnalyticsAggregatedAlertRestOperations _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient;
        private readonly IotSecurityAggregatedAlertData _data;

        /// <summary> Initializes a new instance of the <see cref="IotSecurityAggregatedAlertResource"/> class for mocking. </summary>
        protected IotSecurityAggregatedAlertResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IotSecurityAggregatedAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotSecurityAggregatedAlertResource(ArmClient client, IotSecurityAggregatedAlertData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotSecurityAggregatedAlertResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotSecurityAggregatedAlertResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertApiVersion);
            _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient = new IotSecuritySolutionsAnalyticsAggregatedAlertRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/iotSecuritySolutions/analyticsModels/aggregatedAlerts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotSecurityAggregatedAlertData Data
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

        /// <summary>
        /// Use this method to get a single the aggregated alert of yours IoT Security solution. This aggregation is performed by alert name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}
        /// Operation Id: IotSecuritySolutionsAnalyticsAggregatedAlert_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotSecurityAggregatedAlertResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertResource.Get");
            scope.Start();
            try
            {
                var response = await _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}
        /// Operation Id: IotSecuritySolutionsAnalyticsAggregatedAlert_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotSecurityAggregatedAlertResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertResource.Get");
            scope.Start();
            try
            {
                var response = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
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
        /// Use this method to dismiss an aggregated IoT Security Solution Alert.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}/dismiss
        /// Operation Id: IotSecuritySolutionsAnalyticsAggregatedAlert_Dismiss
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DismissAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = await _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.DismissAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Use this method to dismiss an aggregated IoT Security Solution Alert.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/iotSecuritySolutions/{solutionName}/analyticsModels/default/aggregatedAlerts/{aggregatedAlertName}/dismiss
        /// Operation Id: IotSecuritySolutionsAnalyticsAggregatedAlert_Dismiss
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Dismiss(CancellationToken cancellationToken = default)
        {
            using var scope = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertClientDiagnostics.CreateScope("IotSecurityAggregatedAlertResource.Dismiss");
            scope.Start();
            try
            {
                var response = _iotSecurityAggregatedAlertIotSecuritySolutionsAnalyticsAggregatedAlertRestClient.Dismiss(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
