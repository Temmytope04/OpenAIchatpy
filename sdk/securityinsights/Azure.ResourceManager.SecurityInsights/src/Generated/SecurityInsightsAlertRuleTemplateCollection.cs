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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsAlertRuleTemplateResource"/> and their operations.
    /// Each <see cref="SecurityInsightsAlertRuleTemplateResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// To get a <see cref="SecurityInsightsAlertRuleTemplateCollection"/> instance call the GetSecurityInsightsAlertRuleTemplates method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// </summary>
    public partial class SecurityInsightsAlertRuleTemplateCollection : ArmCollection, IEnumerable<SecurityInsightsAlertRuleTemplateResource>, IAsyncEnumerable<SecurityInsightsAlertRuleTemplateResource>
    {
        private readonly ClientDiagnostics _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics;
        private readonly AlertRuleTemplatesRestOperations _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsAlertRuleTemplateCollection"/> class for mocking. </summary>
        protected SecurityInsightsAlertRuleTemplateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsAlertRuleTemplateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsAlertRuleTemplateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsAlertRuleTemplateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsAlertRuleTemplateResource.ResourceType, out string securityInsightsAlertRuleTemplateAlertRuleTemplatesApiVersion);
            _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient = new AlertRuleTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsAlertRuleTemplateAlertRuleTemplatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the alert rule template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsAlertRuleTemplateResource>> GetAsync(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the alert rule template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual Response<SecurityInsightsAlertRuleTemplateResource> Get(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all alert rule templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsAlertRuleTemplateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsAlertRuleTemplateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsAlertRuleTemplateResource(Client, SecurityInsightsAlertRuleTemplateData.DeserializeSecurityInsightsAlertRuleTemplateData(e)), _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics, Pipeline, "SecurityInsightsAlertRuleTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all alert rule templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsAlertRuleTemplateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsAlertRuleTemplateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsAlertRuleTemplateResource(Client, SecurityInsightsAlertRuleTemplateData.DeserializeSecurityInsightsAlertRuleTemplateData(e)), _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics, Pipeline, "SecurityInsightsAlertRuleTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual Response<bool> Exists(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsAlertRuleTemplateResource>> GetIfExistsAsync(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsAlertRuleTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleTemplateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRuleTemplates/{alertRuleTemplateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRuleTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsAlertRuleTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertRuleTemplateId"> Alert rule template ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertRuleTemplateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertRuleTemplateId"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsAlertRuleTemplateResource> GetIfExists(string alertRuleTemplateId, CancellationToken cancellationToken = default)
        {
            if (alertRuleTemplateId == null)
            {
                throw new ArgumentNullException(nameof(alertRuleTemplateId));
            }
            if (alertRuleTemplateId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(alertRuleTemplateId));
            }

            using var scope = _securityInsightsAlertRuleTemplateAlertRuleTemplatesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleTemplateAlertRuleTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, alertRuleTemplateId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsAlertRuleTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsAlertRuleTemplateResource> IEnumerable<SecurityInsightsAlertRuleTemplateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsAlertRuleTemplateResource> IAsyncEnumerable<SecurityInsightsAlertRuleTemplateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
