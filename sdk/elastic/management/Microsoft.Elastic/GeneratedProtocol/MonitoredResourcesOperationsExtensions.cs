// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Elastic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MonitoredResourcesOperations.
    /// </summary>
    public static partial class MonitoredResourcesOperationsExtensions
    {
            /// <summary>
            /// List the resources currently being monitored by the Elastic monitor
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the Elastic resource belongs.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            public static IPage<MonitoredResource> List(this IMonitoredResourcesOperations operations, string resourceGroupName, string monitorName)
            {
                return operations.ListAsync(resourceGroupName, monitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the resources currently being monitored by the Elastic monitor
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the Elastic resource belongs.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MonitoredResource>> ListAsync(this IMonitoredResourcesOperations operations, string resourceGroupName, string monitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, monitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the resources currently being monitored by the Elastic monitor
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MonitoredResource> ListNext(this IMonitoredResourcesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the resources currently being monitored by the Elastic monitor
            /// resource.
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
            public static async Task<IPage<MonitoredResource>> ListNextAsync(this IMonitoredResourcesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
