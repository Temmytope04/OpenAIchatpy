// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
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
    /// A class representing a collection of <see cref="SecurityConnectorGovernanceRuleResource" /> and their operations.
    /// Each <see cref="SecurityConnectorGovernanceRuleResource" /> in the collection will belong to the same instance of <see cref="SecurityConnectorResource" />.
    /// To get a <see cref="SecurityConnectorGovernanceRuleCollection" /> instance call the GetSecurityConnectorGovernanceRules method from an instance of <see cref="SecurityConnectorResource" />.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This class is obsolete and will be removed in a future release.", false)]
    public partial class SecurityConnectorGovernanceRuleCollection : ArmCollection, IEnumerable<SecurityConnectorGovernanceRuleResource>, IAsyncEnumerable<SecurityConnectorGovernanceRuleResource>
    {
        private readonly ClientDiagnostics _securityConnectorGovernanceRuleClientDiagnostics;
        private readonly SecurityConnectorGovernanceRulesRestOperations _securityConnectorGovernanceRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGovernanceRuleCollection"/> class for mocking. </summary>
        protected SecurityConnectorGovernanceRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGovernanceRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityConnectorGovernanceRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorGovernanceRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityConnectorGovernanceRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityConnectorGovernanceRuleResource.ResourceType, out string securityConnectorGovernanceRuleApiVersion);
            _securityConnectorGovernanceRuleRestClient = new SecurityConnectorGovernanceRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorGovernanceRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityConnectorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityConnectorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or update a security GovernanceRule on the given security connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="data"> GovernanceRule over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityConnectorGovernanceRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityConnectorGovernanceRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityConnectorGovernanceRuleResource>(Response.FromValue(new SecurityConnectorGovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates or update a security GovernanceRule on the given security connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="data"> GovernanceRule over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityConnectorGovernanceRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleId, GovernanceRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityConnectorGovernanceRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityConnectorGovernanceRuleResource>(Response.FromValue(new SecurityConnectorGovernanceRuleResource(Client, response), response.GetRawResponse()));
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
        /// Get a specific governanceRule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<SecurityConnectorGovernanceRuleResource>> GetAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorGovernanceRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific governanceRule for the requested scope by ruleId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<SecurityConnectorGovernanceRuleResource> Get(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorGovernanceRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGovernanceRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all relevant governanceRules over a security connector level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityConnectorGovernanceRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityConnectorGovernanceRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGovernanceRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGovernanceRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGovernanceRuleResource(Client, GovernanceRuleData.DeserializeGovernanceRuleData(e)), _securityConnectorGovernanceRuleClientDiagnostics, Pipeline, "SecurityConnectorGovernanceRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all relevant governanceRules over a security connector level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityConnectorGovernanceRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityConnectorGovernanceRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorGovernanceRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorGovernanceRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityConnectorGovernanceRuleResource(Client, GovernanceRuleData.DeserializeGovernanceRuleData(e)), _securityConnectorGovernanceRuleClientDiagnostics, Pipeline, "SecurityConnectorGovernanceRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityConnectorGovernanceRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/governanceRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorGovernanceRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleId"> The security GovernanceRule key - unique key for the standard GovernanceRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));

            using var scope = _securityConnectorGovernanceRuleClientDiagnostics.CreateScope("SecurityConnectorGovernanceRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityConnectorGovernanceRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityConnectorGovernanceRuleResource> IEnumerable<SecurityConnectorGovernanceRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityConnectorGovernanceRuleResource> IAsyncEnumerable<SecurityConnectorGovernanceRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
