// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PortalConfigOperations.
    /// </summary>
    public static partial class PortalConfigOperationsExtensions
    {
            /// <summary>
            /// Lists the developer portal configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            public static PortalConfigCollection ListByService(this IPortalConfigOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the developer portal configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalConfigCollection> ListByServiceAsync(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            public static PortalConfigGetEntityTagHeaders GetEntityTag(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, portalConfigId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalConfigGetEntityTagHeaders> GetEntityTagAsync(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, portalConfigId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            public static PortalConfigContract Get(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, portalConfigId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalConfigContract> GetAsync(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, portalConfigId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='parameters'>
            /// Update the developer portal configuration.
            /// </param>
            public static PortalConfigContract Update(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, string ifMatch, PortalConfigContract parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, portalConfigId, ifMatch, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='parameters'>
            /// Update the developer portal configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalConfigContract> UpdateAsync(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, string ifMatch, PortalConfigContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalConfigId, ifMatch, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='parameters'>
            /// Update the developer portal configuration.
            /// </param>
            public static PortalConfigContract CreateOrUpdate(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, string ifMatch, PortalConfigContract parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, portalConfigId, ifMatch, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the developer portal configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='portalConfigId'>
            /// Portal configuration identifier.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='parameters'>
            /// Update the developer portal configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PortalConfigContract> CreateOrUpdateAsync(this IPortalConfigOperations operations, string resourceGroupName, string serviceName, string portalConfigId, string ifMatch, PortalConfigContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, portalConfigId, ifMatch, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
