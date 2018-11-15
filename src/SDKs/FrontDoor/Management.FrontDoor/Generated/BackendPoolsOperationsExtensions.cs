// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackendPoolsOperations.
    /// </summary>
    public static partial class BackendPoolsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the Backend Pools within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            public static IPage<BackendPool> ListByFrontDoor(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName)
            {
                return operations.ListByFrontDoorAsync(resourceGroupName, frontDoorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the Backend Pools within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BackendPool>> ListByFrontDoorAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFrontDoorWithHttpMessagesAsync(resourceGroupName, frontDoorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Backend Pool with the specified Pool name within the specified Front
            /// Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            public static BackendPool Get(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName)
            {
                return operations.GetAsync(resourceGroupName, frontDoorName, backendPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Backend Pool with the specified Pool name within the specified Front
            /// Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackendPool> GetAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, frontDoorName, backendPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Backend Pool with the specified Pool name within the
            /// specified Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='backendPoolParameters'>
            /// Backend Pool properties needed to create a new Pool.
            /// </param>
            public static BackendPool CreateOrUpdate(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, frontDoorName, backendPoolName, backendPoolParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Backend Pool with the specified Pool name within the
            /// specified Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='backendPoolParameters'>
            /// Backend Pool properties needed to create a new Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackendPool> CreateOrUpdateAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, frontDoorName, backendPoolName, backendPoolParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Backend Pool with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            public static void Delete(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName)
            {
                operations.DeleteAsync(resourceGroupName, frontDoorName, backendPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Backend Pool with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, frontDoorName, backendPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new Backend Pool with the specified Pool name within the
            /// specified Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='backendPoolParameters'>
            /// Backend Pool properties needed to create a new Pool.
            /// </param>
            public static BackendPool BeginCreateOrUpdate(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, frontDoorName, backendPoolName, backendPoolParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Backend Pool with the specified Pool name within the
            /// specified Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='backendPoolParameters'>
            /// Backend Pool properties needed to create a new Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackendPool> BeginCreateOrUpdateAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, frontDoorName, backendPoolName, backendPoolParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Backend Pool with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            public static void BeginDelete(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName)
            {
                operations.BeginDeleteAsync(resourceGroupName, frontDoorName, backendPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Backend Pool with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='backendPoolName'>
            /// Name of the Backend Pool which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IBackendPoolsOperations operations, string resourceGroupName, string frontDoorName, string backendPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, frontDoorName, backendPoolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all of the Backend Pools within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BackendPool> ListByFrontDoorNext(this IBackendPoolsOperations operations, string nextPageLink)
            {
                return operations.ListByFrontDoorNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the Backend Pools within a Front Door.
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
            public static async Task<IPage<BackendPool>> ListByFrontDoorNextAsync(this IBackendPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFrontDoorNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
