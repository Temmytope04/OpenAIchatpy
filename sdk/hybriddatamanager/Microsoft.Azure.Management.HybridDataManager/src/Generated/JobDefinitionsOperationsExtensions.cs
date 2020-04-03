// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobDefinitionsOperations.
    /// </summary>
    public static partial class JobDefinitionsOperationsExtensions
    {
            /// <summary>
            /// This method gets all the job definitions of the given data service name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of interest.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<JobDefinition> ListByDataService(this IJobDefinitionsOperations operations, string dataServiceName, string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>))
            {
                return operations.ListByDataServiceAsync(dataServiceName, resourceGroupName, dataManagerName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data service name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of interest.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobDefinition>> ListByDataServiceAsync(this IJobDefinitionsOperations operations, string dataServiceName, string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataServiceWithHttpMessagesAsync(dataServiceName, resourceGroupName, dataManagerName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This method gets job definition object by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service name of the job definition
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name that is being queried.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static JobDefinition Get(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName)
            {
                return operations.GetAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets job definition object by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service name of the job definition
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name that is being queried.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDefinition> GetAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be created or updated.
            /// </param>
            /// <param name='jobDefinition'>
            /// Job Definition object to be created or updated.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static JobDefinition CreateOrUpdate(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName)
            {
                return operations.CreateOrUpdateAsync(dataServiceName, jobDefinitionName, jobDefinition, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be created or updated.
            /// </param>
            /// <param name='jobDefinition'>
            /// Job Definition object to be created or updated.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDefinition> CreateOrUpdateAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(dataServiceName, jobDefinitionName, jobDefinition, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This method deletes the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be deleted.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static void Delete(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName)
            {
                operations.DeleteAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method deletes the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be deleted.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// This method runs a job instance of the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// Name of the job definition.
            /// </param>
            /// <param name='runParameters'>
            /// Run time parameters for the job definition.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static void Run(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName)
            {
                operations.RunAsync(dataServiceName, jobDefinitionName, runParameters, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method runs a job instance of the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// Name of the job definition.
            /// </param>
            /// <param name='runParameters'>
            /// Run time parameters for the job definition.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RunAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RunWithHttpMessagesAsync(dataServiceName, jobDefinitionName, runParameters, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data manager
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<JobDefinition> ListByDataManager(this IJobDefinitionsOperations operations, string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>))
            {
                return operations.ListByDataManagerAsync(resourceGroupName, dataManagerName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data manager
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobDefinition>> ListByDataManagerAsync(this IJobDefinitionsOperations operations, string resourceGroupName, string dataManagerName, ODataQuery<JobDefinitionFilter> odataQuery = default(ODataQuery<JobDefinitionFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataManagerWithHttpMessagesAsync(resourceGroupName, dataManagerName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be created or updated.
            /// </param>
            /// <param name='jobDefinition'>
            /// Job Definition object to be created or updated.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static JobDefinition BeginCreateOrUpdate(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName)
            {
                return operations.BeginCreateOrUpdateAsync(dataServiceName, jobDefinitionName, jobDefinition, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be created or updated.
            /// </param>
            /// <param name='jobDefinition'>
            /// Job Definition object to be created or updated.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDefinition> BeginCreateOrUpdateAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, JobDefinition jobDefinition, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(dataServiceName, jobDefinitionName, jobDefinition, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This method deletes the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be deleted.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static void BeginDelete(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName)
            {
                operations.BeginDeleteAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method deletes the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// The job definition name to be deleted.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(dataServiceName, jobDefinitionName, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// This method runs a job instance of the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// Name of the job definition.
            /// </param>
            /// <param name='runParameters'>
            /// Run time parameters for the job definition.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static void BeginRun(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName)
            {
                operations.BeginRunAsync(dataServiceName, jobDefinitionName, runParameters, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method runs a job instance of the given job definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The data service type of the job definition.
            /// </param>
            /// <param name='jobDefinitionName'>
            /// Name of the job definition.
            /// </param>
            /// <param name='runParameters'>
            /// Run time parameters for the job definition.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRunAsync(this IJobDefinitionsOperations operations, string dataServiceName, string jobDefinitionName, RunParameters runParameters, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRunWithHttpMessagesAsync(dataServiceName, jobDefinitionName, runParameters, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data service name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobDefinition> ListByDataServiceNext(this IJobDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByDataServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data service name.
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
            public static async Task<IPage<JobDefinition>> ListByDataServiceNextAsync(this IJobDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This method gets all the job definitions of the given data manager
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobDefinition> ListByDataManagerNext(this IJobDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByDataManagerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the job definitions of the given data manager
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
            public static async Task<IPage<JobDefinition>> ListByDataManagerNextAsync(this IJobDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataManagerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
