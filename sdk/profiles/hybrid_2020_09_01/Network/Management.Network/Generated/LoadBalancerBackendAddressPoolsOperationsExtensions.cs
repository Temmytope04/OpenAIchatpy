// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LoadBalancerBackendAddressPoolsOperations.
    /// </summary>
    public static partial class LoadBalancerBackendAddressPoolsOperationsExtensions
    {
            /// <summary>
            /// Gets all the load balancer backed address pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            public static IPage<BackendAddressPool> List(this ILoadBalancerBackendAddressPoolsOperations operations, string resourceGroupName, string loadBalancerName)
            {
                return operations.ListAsync(resourceGroupName, loadBalancerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the load balancer backed address pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BackendAddressPool>> ListAsync(this ILoadBalancerBackendAddressPoolsOperations operations, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, loadBalancerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets load balancer backend address pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='backendAddressPoolName'>
            /// The name of the backend address pool.
            /// </param>
            public static BackendAddressPool Get(this ILoadBalancerBackendAddressPoolsOperations operations, string resourceGroupName, string loadBalancerName, string backendAddressPoolName)
            {
                return operations.GetAsync(resourceGroupName, loadBalancerName, backendAddressPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets load balancer backend address pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='backendAddressPoolName'>
            /// The name of the backend address pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackendAddressPool> GetAsync(this ILoadBalancerBackendAddressPoolsOperations operations, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, loadBalancerName, backendAddressPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the load balancer backed address pools.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BackendAddressPool> ListNext(this ILoadBalancerBackendAddressPoolsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the load balancer backed address pools.
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
            public static async Task<IPage<BackendAddressPool>> ListNextAsync(this ILoadBalancerBackendAddressPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
