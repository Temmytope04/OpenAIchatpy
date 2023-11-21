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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="OutboundRuleResource"/> and their operations.
    /// Each <see cref="OutboundRuleResource"/> in the collection will belong to the same instance of <see cref="LoadBalancerResource"/>.
    /// To get an <see cref="OutboundRuleCollection"/> instance call the GetOutboundRules method from an instance of <see cref="LoadBalancerResource"/>.
    /// </summary>
    public partial class OutboundRuleCollection : ArmCollection, IEnumerable<OutboundRuleResource>, IAsyncEnumerable<OutboundRuleResource>
    {
        private readonly ClientDiagnostics _outboundRuleLoadBalancerOutboundRulesClientDiagnostics;
        private readonly LoadBalancerOutboundRulesRestOperations _outboundRuleLoadBalancerOutboundRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class for mocking. </summary>
        protected OutboundRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OutboundRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundRuleLoadBalancerOutboundRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", OutboundRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OutboundRuleResource.ResourceType, out string outboundRuleLoadBalancerOutboundRulesApiVersion);
            _outboundRuleLoadBalancerOutboundRulesRestClient = new LoadBalancerOutboundRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, outboundRuleLoadBalancerOutboundRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified load balancer outbound rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual async Task<Response<OutboundRuleResource>> GetAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer outbound rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<OutboundRuleResource> Get(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _outboundRuleLoadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the outbound rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _outboundRuleLoadBalancerOutboundRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _outboundRuleLoadBalancerOutboundRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OutboundRuleResource(Client, OutboundRuleData.DeserializeOutboundRuleData(e)), _outboundRuleLoadBalancerOutboundRulesClientDiagnostics, Pipeline, "OutboundRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the outbound rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _outboundRuleLoadBalancerOutboundRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _outboundRuleLoadBalancerOutboundRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OutboundRuleResource(Client, OutboundRuleData.DeserializeOutboundRuleData(e)), _outboundRuleLoadBalancerOutboundRulesClientDiagnostics, Pipeline, "OutboundRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _outboundRuleLoadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<OutboundRuleResource>> GetIfExistsAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _outboundRuleLoadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<OutboundRuleResource>(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/outboundRules/{outboundRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerOutboundRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="outboundRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual NullableResponse<OutboundRuleResource> GetIfExists(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(outboundRuleName, nameof(outboundRuleName));

            using var scope = _outboundRuleLoadBalancerOutboundRulesClientDiagnostics.CreateScope("OutboundRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _outboundRuleLoadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<OutboundRuleResource>(response.GetRawResponse());
                return Response.FromValue(new OutboundRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OutboundRuleResource> IEnumerable<OutboundRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundRuleResource> IAsyncEnumerable<OutboundRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
