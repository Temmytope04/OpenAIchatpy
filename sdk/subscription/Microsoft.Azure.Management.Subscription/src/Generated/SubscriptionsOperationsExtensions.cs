// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionsOperations.
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Gets all available geo-locations.
            /// </summary>
            /// <remarks>
            /// This operation provides all the locations that are available for resource
            /// providers; however, each resource provider may support a subset of this
            /// list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            public static IEnumerable<Location> ListLocations(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.ListLocationsAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all available geo-locations.
            /// </summary>
            /// <remarks>
            /// This operation provides all the locations that are available for resource
            /// providers; however, each resource provider may support a subset of this
            /// list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Location>> ListLocationsAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLocationsWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details about a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            public static SubscriptionModel Get(this ISubscriptionsOperations operations, string subscriptionId)
            {
                return operations.GetAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The ID of the target subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionModel> GetAsync(this ISubscriptionsOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SubscriptionModel> List(this ISubscriptionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SubscriptionModel>> ListAsync(this ISubscriptionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SubscriptionModel> ListNext(this ISubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all subscriptions for a tenant.
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
            public static async Task<IPage<SubscriptionModel>> ListNextAsync(this ISubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
