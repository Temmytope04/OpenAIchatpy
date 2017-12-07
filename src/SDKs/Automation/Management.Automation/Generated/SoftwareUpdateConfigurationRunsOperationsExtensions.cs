// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SoftwareUpdateConfigurationRunsOperations.
    /// </summary>
    public static partial class SoftwareUpdateConfigurationRunsOperationsExtensions
    {
            /// <summary>
            /// Get a single software update configuration Run by Id.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationrunoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            public static SoftwareUpdateConfigurationRun GetById(this ISoftwareUpdateConfigurationRunsOperations operations, string resourceGroupName)
            {
                return operations.GetByIdAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single software update configuration Run by Id.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationrunoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfigurationRun> GetByIdAsync(this ISoftwareUpdateConfigurationRunsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return list of software update configuration runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='skip'>
            /// number of entries you skip before returning results
            /// </param>
            /// <param name='top'>
            /// Maximum number of entries returned in the results collection
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. You can use the following filters:
            /// 'properties/osType', 'properties/status', 'properties/startTime', and
            /// 'properties/softwareUpdateConfiguration/name'
            /// </param>
            public static SoftwareUpdateConfigurationRunListResult List(this ISoftwareUpdateConfigurationRunsOperations operations, string resourceGroupName, string skip = default(string), string top = default(string), string filter = default(string))
            {
                return operations.ListAsync(resourceGroupName, skip, top, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return list of software update configuration runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='skip'>
            /// number of entries you skip before returning results
            /// </param>
            /// <param name='top'>
            /// Maximum number of entries returned in the results collection
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. You can use the following filters:
            /// 'properties/osType', 'properties/status', 'properties/startTime', and
            /// 'properties/softwareUpdateConfiguration/name'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfigurationRunListResult> ListAsync(this ISoftwareUpdateConfigurationRunsOperations operations, string resourceGroupName, string skip = default(string), string top = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, skip, top, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
