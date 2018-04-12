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
    /// JobScheduleOperations operations.
    /// </summary>
    public partial interface IJobScheduleOperations
    {
        /// <summary>
        /// Delete the job schedule identified by job schedule name.
        /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='jobScheduleId'>
        /// The job schedule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.
        /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='jobScheduleId'>
        /// The job schedule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobSchedule>> GetWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a job schedule.
        /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='jobScheduleId'>
        /// The job schedule name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create job schedule operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobSchedule>> CreateWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, JobScheduleCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a list of job schedules.
        /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobSchedule>>> ListByAutomationAccountWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a list of job schedules.
        /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobSchedule>>> ListByAutomationAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
