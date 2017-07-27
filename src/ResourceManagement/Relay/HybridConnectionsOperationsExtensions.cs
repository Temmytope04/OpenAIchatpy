// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Relay.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HybridConnectionsOperations.
    /// </summary>
    public static partial class HybridConnectionsOperationsExtensions
    {
            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            public static IPage<HybridConnectionInner> ListByNamespace(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HybridConnectionInner>> ListByNamespaceAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a service HybridConnection. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a HybridConnection.
            /// </param>
            public static HybridConnectionInner CreateOrUpdate(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, HybridConnectionInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, hybridConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a service HybridConnection. This operation is
            /// idempotent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a HybridConnection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridConnectionInner> CreateOrUpdateAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, HybridConnectionInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a HybridConnection .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static void Delete(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a HybridConnection .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the description for the specified HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static HybridConnectionInner Get(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the description for the specified HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridConnectionInner> GetAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            public static IPage<AuthorizationRuleInner> ListAuthorizationRules(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, hybridConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRuleInner>> ListAuthorizationRulesAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='rights'>
            /// The rights associated with the rule.
            /// </param>
            public static AuthorizationRuleInner CreateOrUpdateAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, IList<AccessRights?> rights = default(IList<AccessRights?>))
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, rights).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates an authorization rule for a HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='rights'>
            /// The rights associated with the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRuleInner> CreateOrUpdateAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, IList<AccessRights?> rights = default(IList<AccessRights?>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, rights, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a HybridConnection authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a HybridConnection authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// HybridConnection authorizationRule for a HybridConnection by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static AuthorizationRuleInner GetAuthorizationRule(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// HybridConnection authorizationRule for a HybridConnection by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRuleInner> GetAuthorizationRuleAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            public static AccessKeysInner ListKeys(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Primary and Secondary ConnectionStrings to the HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeysInner> ListKeysAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the
            /// HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate Auth Rule.
            /// </param>
            public static AccessKeysInner RegenerateKeys(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, RegenerateAccessKeyParametersInner parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the Primary or Secondary ConnectionStrings to the
            /// HybridConnection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace Name
            /// </param>
            /// <param name='hybridConnectionName'>
            /// The hybrid connection name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorizationRule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate Auth Rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeysInner> RegenerateKeysAsync(this IHybridConnectionsOperations operations, string resourceGroupName, string namespaceName, string hybridConnectionName, string authorizationRuleName, RegenerateAccessKeyParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, hybridConnectionName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HybridConnectionInner> ListByNamespaceNext(this IHybridConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the HybridConnection within the namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HybridConnectionInner>> ListByNamespaceNextAsync(this IHybridConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AuthorizationRuleInner> ListAuthorizationRulesNext(this IHybridConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Authorization rules for a HybridConnection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRuleInner>> ListAuthorizationRulesNextAsync(this IHybridConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
