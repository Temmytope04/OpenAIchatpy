// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The FirewallPolicyRuleGroups service client. </summary>
    public partial class FirewallPolicyRuleGroupsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FirewallPolicyRuleGroupsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsOperations for mocking. </summary>
        protected FirewallPolicyRuleGroupsOperations()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal FirewallPolicyRuleGroupsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new FirewallPolicyRuleGroupsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallPolicyRuleGroup>> GetAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallPolicyRuleGroup> Get(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual AsyncPageable<FirewallPolicyRuleGroup> ListAsync(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            async Task<Page<FirewallPolicyRuleGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicyRuleGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual Pageable<FirewallPolicyRuleGroup> List(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            Page<FirewallPolicyRuleGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, firewallPolicyName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicyRuleGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, firewallPolicyName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleGroupName"/> is null. </exception>
        public virtual async Task<FirewallPolicyRuleGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
                return new FirewallPolicyRuleGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleGroupName"/> is null. </exception>
        public virtual FirewallPolicyRuleGroupsDeleteOperation StartDelete(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
                return new FirewallPolicyRuleGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, <paramref name="ruleGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<FirewallPolicyRuleGroupsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new FirewallPolicyRuleGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, <paramref name="ruleGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual FirewallPolicyRuleGroupsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleGroupsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken);
                return new FirewallPolicyRuleGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
