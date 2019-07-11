// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LongTermRetentionBackupsOperations operations.
    /// </summary>
    public partial interface ILongTermRetentionBackupsOperations
    {
        /// <summary>
        /// Gets a long term retention backup.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database.
        /// </param>
        /// <param name='longTermRetentionServerName'>
        /// The name of the server
        /// </param>
        /// <param name='longTermRetentionDatabaseName'>
        /// The name of the database
        /// </param>
        /// <param name='backupName'>
        /// The backup name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LongTermRetentionBackup>> GetWithHttpMessagesAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a long term retention backup.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database
        /// </param>
        /// <param name='longTermRetentionServerName'>
        /// The name of the server
        /// </param>
        /// <param name='longTermRetentionDatabaseName'>
        /// The name of the database
        /// </param>
        /// <param name='backupName'>
        /// The backup name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all long term retention backups for a database.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database
        /// </param>
        /// <param name='longTermRetentionServerName'>
        /// The name of the server
        /// </param>
        /// <param name='longTermRetentionDatabaseName'>
        /// The name of the database
        /// </param>
        /// <param name='onlyLatestPerDatabase'>
        /// Whether or not to only get the latest backup for each database.
        /// </param>
        /// <param name='databaseState'>
        /// Whether to query against just live databases, just deleted
        /// databases, or all databases. Possible values include: 'All',
        /// 'Live', 'Deleted'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByDatabaseWithHttpMessagesAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, bool? onlyLatestPerDatabase = default(bool?), string databaseState = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the long term retention backups for a given location.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database
        /// </param>
        /// <param name='onlyLatestPerDatabase'>
        /// Whether or not to only get the latest backup for each database.
        /// </param>
        /// <param name='databaseState'>
        /// Whether to query against just live databases, just deleted
        /// databases, or all databases. Possible values include: 'All',
        /// 'Live', 'Deleted'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByLocationWithHttpMessagesAsync(string locationName, bool? onlyLatestPerDatabase = default(bool?), string databaseState = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the long term retention backups for a given server.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database
        /// </param>
        /// <param name='longTermRetentionServerName'>
        /// The name of the server
        /// </param>
        /// <param name='onlyLatestPerDatabase'>
        /// Whether or not to only get the latest backup for each database.
        /// </param>
        /// <param name='databaseState'>
        /// Whether to query against just live databases, just deleted
        /// databases, or all databases. Possible values include: 'All',
        /// 'Live', 'Deleted'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByServerWithHttpMessagesAsync(string locationName, string longTermRetentionServerName, bool? onlyLatestPerDatabase = default(bool?), string databaseState = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a long term retention backup.
        /// </summary>
        /// <param name='locationName'>
        /// The location of the database
        /// </param>
        /// <param name='longTermRetentionServerName'>
        /// The name of the server
        /// </param>
        /// <param name='longTermRetentionDatabaseName'>
        /// The name of the database
        /// </param>
        /// <param name='backupName'>
        /// The backup name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all long term retention backups for a database.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByDatabaseNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the long term retention backups for a given location.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByLocationNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the long term retention backups for a given server.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LongTermRetentionBackup>>> ListByServerNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
