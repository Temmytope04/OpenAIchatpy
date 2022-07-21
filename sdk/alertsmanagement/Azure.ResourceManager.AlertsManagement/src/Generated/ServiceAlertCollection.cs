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
using Azure.ResourceManager.AlertsManagement.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceAlertResource" /> and their operations.
    /// Each <see cref="ServiceAlertResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="ServiceAlertCollection" /> instance call the GetServiceAlerts method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class ServiceAlertCollection : ArmCollection, IEnumerable<ServiceAlertResource>, IAsyncEnumerable<ServiceAlertResource>
    {
        private readonly ClientDiagnostics _serviceAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _serviceAlertAlertsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertCollection"/> class for mocking. </summary>
        protected ServiceAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceAlertCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", ServiceAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceAlertResource.ResourceType, out string serviceAlertAlertsApiVersion);
            _serviceAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information related to a specific alert
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}
        /// Operation Id: Alerts_GetById
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual async Task<Response<ServiceAlertResource>> GetAsync(string alertId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertId, nameof(alertId));

            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetByIdAsync(Id.SubscriptionId, alertId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information related to a specific alert
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}
        /// Operation Id: Alerts_GetById
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual Response<ServiceAlertResource> Get(string alertId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertId, nameof(alertId));

            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetById(Id.SubscriptionId, alertId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all existing alerts, where the results can be filtered on the basis of multiple parameters (e.g. time range). The results can then be sorted on the basis specific fields, with the default being lastModifiedDateTime. 
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts
        /// Operation Id: Alerts_GetAll
        /// </summary>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either &apos;Fired&apos; or &apos;Resolved&apos;. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="alertState"> Filter by state of the alert instance. Default value is to select all. </param>
        /// <param name="alertRule"> Filter by specific alert rule.  Default value is to select all. </param>
        /// <param name="smartGroupId"> Filter the alerts list by the Smart Group Id. Default value is none. </param>
        /// <param name="includeContext"> Include context which has contextual data specific to the monitor service. Default value is false&apos;. </param>
        /// <param name="includeEgressConfig"> Include egress config which would be used for displaying the content in portal.  Default value is &apos;false&apos;. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the &quot;includeContent&quot;  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field,  Default value is &apos;lastModifiedDateTime&apos;. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is &apos;desc&apos; for time fields and &apos;asc&apos; for others. </param>
        /// <param name="select"> This filter allows to selection of the fields(comma separated) which would  be part of the essential section. This would allow to project only the  required fields rather than getting entire content.  Default is to fetch all the fields in the essentials section. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="customTimeRange"> Filter by custom time range in the format &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)&apos;. Permissible values is within 30 days from  query time. Either timeRange or customTimeRange could be used but not both. Default is none. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceAlertResource> GetAllAsync(string targetResource = null, string targetResourceType = null, string targetResourceGroup = null, MonitorService? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, AlertState? alertState = null, string alertRule = null, string smartGroupId = null, bool? includeContext = null, bool? includeEgressConfig = null, long? pageCount = null, AlertsSortByField? sortBy = null, SortOrder? sortOrder = null, string select = null, TimeRangeFilter? timeRange = null, string customTimeRange = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceAlertResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceAlertAlertsRestClient.GetAllAsync(Id.SubscriptionId, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceAlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceAlertResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceAlertAlertsRestClient.GetAllNextPageAsync(nextLink, Id.SubscriptionId, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceAlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all existing alerts, where the results can be filtered on the basis of multiple parameters (e.g. time range). The results can then be sorted on the basis specific fields, with the default being lastModifiedDateTime. 
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts
        /// Operation Id: Alerts_GetAll
        /// </summary>
        /// <param name="targetResource"> Filter by target resource( which is full ARM ID) Default value is select all. </param>
        /// <param name="targetResourceType"> Filter by target resource type. Default value is select all. </param>
        /// <param name="targetResourceGroup"> Filter by target resource group name. Default value is select all. </param>
        /// <param name="monitorService"> Filter by monitor service which generates the alert instance. Default value is select all. </param>
        /// <param name="monitorCondition"> Filter by monitor condition which is either &apos;Fired&apos; or &apos;Resolved&apos;. Default value is to select all. </param>
        /// <param name="severity"> Filter by severity.  Default value is select all. </param>
        /// <param name="alertState"> Filter by state of the alert instance. Default value is to select all. </param>
        /// <param name="alertRule"> Filter by specific alert rule.  Default value is to select all. </param>
        /// <param name="smartGroupId"> Filter the alerts list by the Smart Group Id. Default value is none. </param>
        /// <param name="includeContext"> Include context which has contextual data specific to the monitor service. Default value is false&apos;. </param>
        /// <param name="includeEgressConfig"> Include egress config which would be used for displaying the content in portal.  Default value is &apos;false&apos;. </param>
        /// <param name="pageCount"> Determines number of alerts returned per page in response. Permissible value is between 1 to 250. When the &quot;includeContent&quot;  filter is selected, maximum value allowed is 25. Default value is 25. </param>
        /// <param name="sortBy"> Sort the query results by input field,  Default value is &apos;lastModifiedDateTime&apos;. </param>
        /// <param name="sortOrder"> Sort the query results order in either ascending or descending.  Default value is &apos;desc&apos; for time fields and &apos;asc&apos; for others. </param>
        /// <param name="select"> This filter allows to selection of the fields(comma separated) which would  be part of the essential section. This would allow to project only the  required fields rather than getting entire content.  Default is to fetch all the fields in the essentials section. </param>
        /// <param name="timeRange"> Filter by time range by below listed values. Default value is 1 day. </param>
        /// <param name="customTimeRange"> Filter by custom time range in the format &lt;start-time&gt;/&lt;end-time&gt;  where time is in (ISO-8601 format)&apos;. Permissible values is within 30 days from  query time. Either timeRange or customTimeRange could be used but not both. Default is none. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceAlertResource> GetAll(string targetResource = null, string targetResourceType = null, string targetResourceGroup = null, MonitorService? monitorService = null, MonitorCondition? monitorCondition = null, ServiceAlertSeverity? severity = null, AlertState? alertState = null, string alertRule = null, string smartGroupId = null, bool? includeContext = null, bool? includeEgressConfig = null, long? pageCount = null, AlertsSortByField? sortBy = null, SortOrder? sortOrder = null, string select = null, TimeRangeFilter? timeRange = null, string customTimeRange = null, CancellationToken cancellationToken = default)
        {
            Page<ServiceAlertResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceAlertAlertsRestClient.GetAll(Id.SubscriptionId, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceAlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceAlertResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceAlertAlertsRestClient.GetAllNextPage(nextLink, Id.SubscriptionId, targetResource, targetResourceType, targetResourceGroup, monitorService, monitorCondition, severity, alertState, alertRule, smartGroupId, includeContext, includeEgressConfig, pageCount, sortBy, sortOrder, select, timeRange, customTimeRange, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceAlertResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}
        /// Operation Id: Alerts_GetById
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertId, nameof(alertId));

            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceAlertAlertsRestClient.GetByIdAsync(Id.SubscriptionId, alertId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alerts/{alertId}
        /// Operation Id: Alerts_GetById
        /// </summary>
        /// <param name="alertId"> Unique ID of an alert instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertId"/> is null. </exception>
        public virtual Response<bool> Exists(string alertId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertId, nameof(alertId));

            using var scope = _serviceAlertAlertsClientDiagnostics.CreateScope("ServiceAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceAlertAlertsRestClient.GetById(Id.SubscriptionId, alertId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceAlertResource> IEnumerable<ServiceAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceAlertResource> IAsyncEnumerable<ServiceAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
