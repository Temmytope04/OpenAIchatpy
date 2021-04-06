// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// List all private endpoint connections on a Automation account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            public static IEnumerable<PrivateEndpointConnection> ListByAutomationAccount(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all private endpoint connections on a Automation account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PrivateEndpointConnection>> ListByAutomationAccountAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a private endpoint connection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            public static PrivateEndpointConnection BeginCreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, PrivateEndpointConnection parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='parameters'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginCreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a private endpoint connection with a given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string automationAccountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
