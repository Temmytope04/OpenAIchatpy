// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations.
    /// </summary>
    public static partial class WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperationsExtensions
    {
            /// <summary>
            /// Update server's tls settings.
            /// </summary>
            /// <remarks>
            /// Update workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// minimal tls settings
            /// </param>
            public static DedicatedSQLminimalTlsSettings Update(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, DedicatedSQLminimalTlsSettings parameters)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update server's tls settings.
            /// </summary>
            /// <remarks>
            /// Update workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// minimal tls settings
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedSQLminimalTlsSettings> UpdateAsync(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, DedicatedSQLminimalTlsSettings parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dedicatedSQLminimalTlsSettingsName'>
            /// The name of the dedicated sql minimal tls settings.
            /// </param>
            public static DedicatedSQLminimalTlsSettings Get(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, string dedicatedSQLminimalTlsSettingsName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, dedicatedSQLminimalTlsSettingsName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// Get workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dedicatedSQLminimalTlsSettingsName'>
            /// The name of the dedicated sql minimal tls settings.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedSQLminimalTlsSettings> GetAsync(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, string dedicatedSQLminimalTlsSettingsName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, dedicatedSQLminimalTlsSettingsName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List workspace server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// List workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<DedicatedSQLminimalTlsSettings> List(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List workspace server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// List workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DedicatedSQLminimalTlsSettings>> ListAsync(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update server's tls settings.
            /// </summary>
            /// <remarks>
            /// Update workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// minimal tls settings
            /// </param>
            public static DedicatedSQLminimalTlsSettings BeginUpdate(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, DedicatedSQLminimalTlsSettings parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, workspaceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update server's tls settings.
            /// </summary>
            /// <remarks>
            /// Update workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='parameters'>
            /// minimal tls settings
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DedicatedSQLminimalTlsSettings> BeginUpdateAsync(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string resourceGroupName, string workspaceName, DedicatedSQLminimalTlsSettings parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List workspace server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// List workspace managed sql server's minimal tls settings.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DedicatedSQLminimalTlsSettings> ListNext(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List workspace server's minimal tls settings.
            /// </summary>
            /// <remarks>
            /// List workspace managed sql server's minimal tls settings.
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
            public static async Task<IPage<DedicatedSQLminimalTlsSettings>> ListNextAsync(this IWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
