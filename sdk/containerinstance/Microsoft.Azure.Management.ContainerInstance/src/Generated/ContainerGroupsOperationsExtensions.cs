// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ContainerGroupsOperations.
    /// </summary>
    public static partial class ContainerGroupsOperationsExtensions
    {
            /// <summary>
            /// Get a list of container groups in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in the specified subscription. This
            /// operation returns properties of each container group including containers,
            /// image registry credentials, restart policy, IP address type, OS type,
            /// state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ContainerGroup> List(this IContainerGroupsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in the specified subscription. This
            /// operation returns properties of each container group including containers,
            /// image registry credentials, restart policy, IP address type, OS type,
            /// state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerGroup>> ListAsync(this IContainerGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription and resource
            /// group.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in a specified subscription and resource
            /// group. This operation returns properties of each container group including
            /// containers, image registry credentials, restart policy, IP address type, OS
            /// type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ContainerGroup> ListByResourceGroup(this IContainerGroupsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription and resource
            /// group.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in a specified subscription and resource
            /// group. This operation returns properties of each container group including
            /// containers, image registry credentials, restart policy, IP address type, OS
            /// type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerGroup>> ListByResourceGroupAsync(this IContainerGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the properties of the specified container group.
            /// </summary>
            /// <remarks>
            /// Gets the properties of the specified container group in the specified
            /// subscription and resource group. The operation returns the properties of
            /// each container group including containers, image registry credentials,
            /// restart policy, IP address type, OS type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static ContainerGroup Get(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                return operations.GetAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the properties of the specified container group.
            /// </summary>
            /// <remarks>
            /// Gets the properties of the specified container group in the specified
            /// subscription and resource group. The operation returns the properties of
            /// each container group including containers, image registry credentials,
            /// restart policy, IP address type, OS type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> GetAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update container groups.
            /// </summary>
            /// <remarks>
            /// Create or update container groups with specified configurations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='containerGroup'>
            /// The properties of the container group to be created or updated.
            /// </param>
            public static ContainerGroup CreateOrUpdate(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, ContainerGroup containerGroup)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, containerGroupName, containerGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update container groups.
            /// </summary>
            /// <remarks>
            /// Create or update container groups with specified configurations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='containerGroup'>
            /// The properties of the container group to be created or updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> CreateOrUpdateAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, ContainerGroup containerGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, containerGroupName, containerGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update container groups.
            /// </summary>
            /// <remarks>
            /// Updates container group tags with specified values.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='resource'>
            /// The container group resource with just the tags to be updated.
            /// </param>
            public static ContainerGroup Update(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, Resource resource)
            {
                return operations.UpdateAsync(resourceGroupName, containerGroupName, resource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update container groups.
            /// </summary>
            /// <remarks>
            /// Updates container group tags with specified values.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='resource'>
            /// The container group resource with just the tags to be updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> UpdateAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, Resource resource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, containerGroupName, resource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the specified container group.
            /// </summary>
            /// <remarks>
            /// Delete the specified container group in the specified subscription and
            /// resource group. The operation does not delete other resources provided by
            /// the user, such as volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static ContainerGroup Delete(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                return operations.DeleteAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified container group.
            /// </summary>
            /// <remarks>
            /// Delete the specified container group in the specified subscription and
            /// resource group. The operation does not delete other resources provided by
            /// the user, such as volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> DeleteAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Restarts all containers in a container group in place. If container image
            /// has updates, new image will be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static void Restart(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                operations.RestartAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Restarts all containers in a container group in place. If container image
            /// has updates, new image will be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestartWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Stops all containers in a container group. Compute resources will be
            /// deallocated and billing will stop.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static void Stop(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                operations.StopAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Stops all containers in a container group. Compute resources will be
            /// deallocated and billing will stop.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Starts all containers in a container group. Compute resources will be
            /// allocated and billing will start.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static void Start(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                operations.StartAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Starts all containers in a container group. Compute resources will be
            /// allocated and billing will start.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all network dependencies for container group.
            /// </summary>
            /// <remarks>
            /// Gets all the network dependencies for this container group to allow
            /// complete control of network setting and configuration. For container
            /// groups, this will always be an empty list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static IList<string> GetOutboundNetworkDependenciesEndpoints(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                return operations.GetOutboundNetworkDependenciesEndpointsAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all network dependencies for container group.
            /// </summary>
            /// <remarks>
            /// Gets all the network dependencies for this container group to allow
            /// complete control of network setting and configuration. For container
            /// groups, this will always be an empty list.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetOutboundNetworkDependenciesEndpointsAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOutboundNetworkDependenciesEndpointsWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update container groups.
            /// </summary>
            /// <remarks>
            /// Create or update container groups with specified configurations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='containerGroup'>
            /// The properties of the container group to be created or updated.
            /// </param>
            public static ContainerGroup BeginCreateOrUpdate(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, ContainerGroup containerGroup)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, containerGroupName, containerGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update container groups.
            /// </summary>
            /// <remarks>
            /// Create or update container groups with specified configurations.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='containerGroup'>
            /// The properties of the container group to be created or updated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> BeginCreateOrUpdateAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, ContainerGroup containerGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, containerGroupName, containerGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the specified container group.
            /// </summary>
            /// <remarks>
            /// Delete the specified container group in the specified subscription and
            /// resource group. The operation does not delete other resources provided by
            /// the user, such as volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static ContainerGroup BeginDelete(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified container group.
            /// </summary>
            /// <remarks>
            /// Delete the specified container group in the specified subscription and
            /// resource group. The operation does not delete other resources provided by
            /// the user, such as volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerGroup> BeginDeleteAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Restarts all containers in a container group in place. If container image
            /// has updates, new image will be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static void BeginRestart(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                operations.BeginRestartAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Restarts all containers in a container group in place. If container image
            /// has updates, new image will be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Starts all containers in a container group. Compute resources will be
            /// allocated and billing will start.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            public static void BeginStart(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName)
            {
                operations.BeginStartAsync(resourceGroupName, containerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts all containers in a container group.
            /// </summary>
            /// <remarks>
            /// Starts all containers in a container group. Compute resources will be
            /// allocated and billing will start.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerGroupName'>
            /// The name of the container group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IContainerGroupsOperations operations, string resourceGroupName, string containerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, containerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in the specified subscription. This
            /// operation returns properties of each container group including containers,
            /// image registry credentials, restart policy, IP address type, OS type,
            /// state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ContainerGroup> ListNext(this IContainerGroupsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in the specified subscription. This
            /// operation returns properties of each container group including containers,
            /// image registry credentials, restart policy, IP address type, OS type,
            /// state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerGroup>> ListNextAsync(this IContainerGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription and resource
            /// group.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in a specified subscription and resource
            /// group. This operation returns properties of each container group including
            /// containers, image registry credentials, restart policy, IP address type, OS
            /// type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ContainerGroup> ListByResourceGroupNext(this IContainerGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of container groups in the specified subscription and resource
            /// group.
            /// </summary>
            /// <remarks>
            /// Get a list of container groups in a specified subscription and resource
            /// group. This operation returns properties of each container group including
            /// containers, image registry credentials, restart policy, IP address type, OS
            /// type, state, and volumes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerGroup>> ListByResourceGroupNextAsync(this IContainerGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
