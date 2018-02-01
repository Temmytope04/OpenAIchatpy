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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DscConfigurationOperations.
    /// </summary>
    public static partial class DscConfigurationOperationsExtensions
    {
            /// <summary>
            /// Delete the dsc configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            public static void Delete(this IDscConfigurationOperations operations, string automationAccountName, string configurationName)
            {
                operations.DeleteAsync(automationAccountName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the dsc configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDscConfigurationOperations operations, string automationAccountName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(automationAccountName, configurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            public static DscConfiguration Get(this IDscConfigurationOperations operations, string automationAccountName, string configurationName)
            {
                return operations.GetAsync(automationAccountName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DscConfiguration> GetAsync(this IDscConfigurationOperations operations, string automationAccountName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(automationAccountName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The create or update parameters for configuration.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for configuration.
            /// </param>
            public static DscConfiguration CreateOrUpdate(this IDscConfigurationOperations operations, string automationAccountName, string configurationName, DscConfigurationCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(automationAccountName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the configuration identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The create or update parameters for configuration.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DscConfiguration> CreateOrUpdateAsync(this IDscConfigurationOperations operations, string automationAccountName, string configurationName, DscConfigurationCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(automationAccountName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the configuration script identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            public static Stream GetContent(this IDscConfigurationOperations operations, string automationAccountName, string configurationName)
            {
                return operations.GetContentAsync(automationAccountName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the configuration script identified by configuration name.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='configurationName'>
            /// The configuration name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetContentAsync(this IDscConfigurationOperations operations, string automationAccountName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetContentWithHttpMessagesAsync(automationAccountName, configurationName, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Retrieve a list of configurations.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            public static IPage<DscConfiguration> ListByAutomationAccount(this IDscConfigurationOperations operations, string automationAccountName)
            {
                return operations.ListByAutomationAccountAsync(automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of configurations.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DscConfiguration>> ListByAutomationAccountAsync(this IDscConfigurationOperations operations, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of configurations.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DscConfiguration> ListByAutomationAccountNext(this IDscConfigurationOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of configurations.
            /// <see href="http://aka.ms/azureautomationsdk/configurationoperations" />
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
            public static async Task<IPage<DscConfiguration>> ListByAutomationAccountNextAsync(this IDscConfigurationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
