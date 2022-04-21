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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VpnGatewayNatRuleResource" /> and their operations.
    /// Each <see cref="VpnGatewayNatRuleResource" /> in the collection will belong to the same instance of <see cref="VpnGatewayResource" />.
    /// To get a <see cref="VpnGatewayNatRuleCollection" /> instance call the GetVpnGatewayNatRules method from an instance of <see cref="VpnGatewayResource" />.
    /// </summary>
    public partial class VpnGatewayNatRuleCollection : ArmCollection, IEnumerable<VpnGatewayNatRuleResource>, IAsyncEnumerable<VpnGatewayNatRuleResource>
    {
        private readonly ClientDiagnostics _vpnGatewayNatRuleNatRulesClientDiagnostics;
        private readonly NatRulesRestOperations _vpnGatewayNatRuleNatRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VpnGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayNatRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnGatewayNatRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnGatewayNatRuleNatRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnGatewayNatRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnGatewayNatRuleResource.ResourceType, out string vpnGatewayNatRuleNatRulesApiVersion);
            _vpnGatewayNatRuleNatRulesRestClient = new NatRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnGatewayNatRuleNatRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VpnGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VpnGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnGatewayNatRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string natRuleName, VpnGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnGatewayNatRuleResource>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a nat rule to a scalable vpn gateway if it doesn&apos;t exist else updates the existing nat rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VpnGatewayNatRuleResource> CreateOrUpdate(WaitUntil waitUntil, string natRuleName, VpnGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, data, cancellationToken);
                var operation = new NetworkArmOperation<VpnGatewayNatRuleResource>(new VpnGatewayNatRuleOperationSource(Client), _vpnGatewayNatRuleNatRulesClientDiagnostics, Pipeline, _vpnGatewayNatRuleNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual async Task<Response<VpnGatewayNatRuleResource>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a nat ruleGet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VpnGatewayNatRuleResource> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayNatRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules
        /// Operation Id: NatRules_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGatewayNatRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnGatewayNatRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGatewayNatRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGatewayNatRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules
        /// Operation Id: NatRules_ListByVpnGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGatewayNatRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnGatewayNatRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGatewayNatRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGatewayNatRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayNatRuleNatRulesRestClient.ListByVpnGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayNatRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vpnGatewayNatRuleNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}/natRules/{natRuleName}
        /// Operation Id: NatRules_Get
        /// </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var scope = _vpnGatewayNatRuleNatRulesClientDiagnostics.CreateScope("VpnGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _vpnGatewayNatRuleNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnGatewayNatRuleResource> IEnumerable<VpnGatewayNatRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnGatewayNatRuleResource> IAsyncEnumerable<VpnGatewayNatRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
