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
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="NamespaceNotificationHubAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="NamespaceNotificationHubAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="NotificationHubResource" />.
    /// To get a <see cref="NamespaceNotificationHubAuthorizationRuleCollection" /> instance call the GetNamespaceNotificationHubAuthorizationRules method from an instance of <see cref="NotificationHubResource" />.
    /// </summary>
    public partial class NamespaceNotificationHubAuthorizationRuleCollection : ArmCollection, IEnumerable<NamespaceNotificationHubAuthorizationRuleResource>, IAsyncEnumerable<NamespaceNotificationHubAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics;
        private readonly NotificationHubsRestOperations _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceNotificationHubAuthorizationRuleCollection"/> class for mocking. </summary>
        protected NamespaceNotificationHubAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceNotificationHubAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NamespaceNotificationHubAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NotificationHubs", NamespaceNotificationHubAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NamespaceNotificationHubAuthorizationRuleResource.ResourceType, out string namespaceNotificationHubAuthorizationRuleNotificationHubsApiVersion);
            _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient = new NotificationHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceNotificationHubAuthorizationRuleNotificationHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NotificationHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NotificationHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> Authorization Rule Name. </param>
        /// <param name="sharedAccessAuthorizationRuleCreateOrUpdateParameters"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="sharedAccessAuthorizationRuleCreateOrUpdateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceNotificationHubAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters sharedAccessAuthorizationRuleCreateOrUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(sharedAccessAuthorizationRuleCreateOrUpdateParameters, nameof(sharedAccessAuthorizationRuleCreateOrUpdateParameters));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, sharedAccessAuthorizationRuleCreateOrUpdateParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NotificationHubsArmOperation<NamespaceNotificationHubAuthorizationRuleResource>(Response.FromValue(new NamespaceNotificationHubAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates/Updates an authorization rule for a NotificationHub
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_CreateOrUpdateAuthorizationRule
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> Authorization Rule Name. </param>
        /// <param name="sharedAccessAuthorizationRuleCreateOrUpdateParameters"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="sharedAccessAuthorizationRuleCreateOrUpdateParameters"/> is null. </exception>
        public virtual ArmOperation<NamespaceNotificationHubAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters sharedAccessAuthorizationRuleCreateOrUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(sharedAccessAuthorizationRuleCreateOrUpdateParameters, nameof(sharedAccessAuthorizationRuleCreateOrUpdateParameters));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, sharedAccessAuthorizationRuleCreateOrUpdateParameters, cancellationToken);
                var operation = new NotificationHubsArmOperation<NamespaceNotificationHubAuthorizationRuleResource>(Response.FromValue(new NamespaceNotificationHubAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<NamespaceNotificationHubAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceNotificationHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a NotificationHub by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceNotificationHubAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceNotificationHubAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the authorization rules for a NotificationHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules
        /// Operation Id: NotificationHubs_ListAuthorizationRules
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceNotificationHubAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceNotificationHubAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NamespaceNotificationHubAuthorizationRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.ListAuthorizationRulesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceNotificationHubAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NamespaceNotificationHubAuthorizationRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.ListAuthorizationRulesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceNotificationHubAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the authorization rules for a NotificationHub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules
        /// Operation Id: NotificationHubs_ListAuthorizationRules
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceNotificationHubAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceNotificationHubAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NamespaceNotificationHubAuthorizationRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.ListAuthorizationRules(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceNotificationHubAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NamespaceNotificationHubAuthorizationRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.ListAuthorizationRulesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceNotificationHubAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}/AuthorizationRules/{authorizationRuleName}
        /// Operation Id: NotificationHubs_GetAuthorizationRule
        /// </summary>
        /// <param name="authorizationRuleName"> authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceNotificationHubAuthorizationRuleNotificationHubsClientDiagnostics.CreateScope("NamespaceNotificationHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _namespaceNotificationHubAuthorizationRuleNotificationHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NamespaceNotificationHubAuthorizationRuleResource> IEnumerable<NamespaceNotificationHubAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceNotificationHubAuthorizationRuleResource> IAsyncEnumerable<NamespaceNotificationHubAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
