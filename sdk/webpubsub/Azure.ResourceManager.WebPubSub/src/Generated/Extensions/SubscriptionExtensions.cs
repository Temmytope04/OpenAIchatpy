// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Checks that the resource name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public async static Task<Response<NameAvailability>> CheckWebPubSubNameAvailabilityAsync(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await GetExtensionClient(subscription).CheckWebPubSubNameAvailabilityAsync(location, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Checks that the resource name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<NameAvailability> CheckWebPubSubNameAvailability(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return GetExtensionClient(subscription).CheckWebPubSubNameAvailability(location, parameters, cancellationToken);
        }

        /// <summary> Handles requests to list all resources in a subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebPubSub" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<WebPubSub> GetWebPubSubsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetWebPubSubsAsync(cancellationToken);
        }

        /// <summary> Handles requests to list all resources in a subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebPubSub" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<WebPubSub> GetWebPubSubs(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetWebPubSubs(cancellationToken);
        }

        /// <summary> List resource usage quotas by location. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="SignalRServiceUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SignalRServiceUsage> GetUsagesAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsagesAsync(location, cancellationToken);
        }

        /// <summary> List resource usage quotas by location. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="SignalRServiceUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SignalRServiceUsage> GetUsages(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetUsages(location, cancellationToken);
        }
    }
}
