// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountSqlDatabaseThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountSqlDatabaseThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountSqlDatabaseThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountSqlDatabaseThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountSqlDatabaseThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountSqlDatabaseThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountSqlDatabaseThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountSqlDatabaseThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountSqlDatabaseThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string databaseAccountSqlDatabaseThroughputSettingSqlResourcesApiVersion);
            _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountSqlDatabaseThroughputSettingSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlDatabases/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the RUs per second of the SQL database under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DatabaseAccountSqlDatabaseThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the SQL database under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountSqlDatabaseThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB SQL database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_UpdateSqlDatabaseThroughput
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateThroughputParameters"> The parameters to provide for the RUs per second of the current SQL database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>> CreateOrUpdateAsync(WaitUntil waitUntil, ThroughputSettingsUpdateData updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.UpdateSqlDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateUpdateSqlDatabaseThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of an Azure Cosmos DB SQL database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_UpdateSqlDatabaseThroughput
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="updateThroughputParameters"> The parameters to provide for the RUs per second of the current SQL database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting> CreateOrUpdate(WaitUntil waitUntil, ThroughputSettingsUpdateData updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.UpdateSqlDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateUpdateSqlDatabaseThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB SQL database from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: SqlResources_MigrateSqlDatabaseToAutoscale
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>> MigrateSqlDatabaseToAutoscaleAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.MigrateSqlDatabaseToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.MigrateSqlDatabaseToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateMigrateSqlDatabaseToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB SQL database from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: SqlResources_MigrateSqlDatabaseToAutoscale
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting> MigrateSqlDatabaseToAutoscale(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.MigrateSqlDatabaseToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.MigrateSqlDatabaseToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateMigrateSqlDatabaseToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB SQL database from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: SqlResources_MigrateSqlDatabaseToManualThroughput
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>> MigrateSqlDatabaseToManualThroughputAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.MigrateSqlDatabaseToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.MigrateSqlDatabaseToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateMigrateSqlDatabaseToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB SQL database from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: SqlResources_MigrateSqlDatabaseToManualThroughput
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountSqlDatabaseThroughputSetting> MigrateSqlDatabaseToManualThroughput(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.MigrateSqlDatabaseToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.MigrateSqlDatabaseToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountSqlDatabaseThroughputSetting>(new DatabaseAccountSqlDatabaseThroughputSettingOperationSource(Client), _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics, Pipeline, _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.CreateMigrateSqlDatabaseToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<DatabaseAccountSqlDatabaseThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<DatabaseAccountSqlDatabaseThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<DatabaseAccountSqlDatabaseThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: SqlResources_GetSqlDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountSqlDatabaseThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesClientDiagnostics.CreateScope("DatabaseAccountSqlDatabaseThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountSqlDatabaseThroughputSettingSqlResourcesRestClient.GetSqlDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountSqlDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
