﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// Class to overcome issue when the original resource is generated by swagger has "default" suffix in it. E.g.
    /// "/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficManagerUserMetricsKeys/default"
    /// which generates HTTP 400 and simply does not work.
    /// </summary>
    public partial class UserMetricsModelResource
    {
        /// <summary> Generate the resource identifier of a <see cref="UserMetricsModelResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficManagerUserMetricsKeys/default";
            return new ResourceIdentifier(resourceId);
        }

        /// <summary>
        /// Get the subscription-level key used for Real User Metrics collection.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficManagerUserMetricsKeys/default
        /// Operation Id: TrafficManagerUserMetricsKeys_Get
        /// </summary>
        /// <remarks>
        /// The method is added to overcome problem when the Get API returns resource id with the subscription part which
        /// actually is an invalid ARM resource id.
        /// </remarks>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<UserMetricsModelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _userMetricsModelTrafficManagerUserMetricsKeysClientDiagnostics.CreateScope("UserMetricsModelResource.Get");
            scope.Start();
            try
            {
                var response = await _userMetricsModelTrafficManagerUserMetricsKeysRestClient.GetAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());

                response.Value.Id = $"/subscriptions/{Id.SubscriptionId}{response.Value.Id}";

                return Response.FromValue(new UserMetricsModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the subscription-level key used for Real User Metrics collection.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficManagerUserMetricsKeys/default
        /// Operation Id: TrafficManagerUserMetricsKeys_Get
        /// </summary>
        /// <remarks>
        /// The method is added to overcome problem when the Get API returns resource id with the subscription part which
        /// actually is an invalid ARM resource id.
        /// </remarks>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<UserMetricsModelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _userMetricsModelTrafficManagerUserMetricsKeysClientDiagnostics.CreateScope("UserMetricsModelResource.Get");
            scope.Start();
            try
            {
                var response = _userMetricsModelTrafficManagerUserMetricsKeysRestClient.Get(Id.SubscriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());

                response.Value.Id = $"/subscriptions/{Id.SubscriptionId}{response.Value.Id}";

                return Response.FromValue(new UserMetricsModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
