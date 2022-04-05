// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A Class representing a TableService along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TableServiceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTableServiceResource method.
    /// Otherwise you can get one from its parent resource <see cref="StorageAccountResource" /> using the GetTableService method.
    /// </summary>
    public partial class TableServiceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TableServiceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tableServiceClientDiagnostics;
        private readonly TableServicesRestOperations _tableServiceRestClient;
        private readonly TableServiceData _data;

        /// <summary> Initializes a new instance of the <see cref="TableServiceResource"/> class for mocking. </summary>
        protected TableServiceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TableServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TableServiceResource(ArmClient client, TableServiceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TableServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TableServiceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tableServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tableServiceApiVersion);
            _tableServiceRestClient = new TableServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tableServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/tableServices";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TableServiceData Data
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

        /// <summary> Gets a collection of TableResources in the TableService. </summary>
        /// <returns> An object representing collection of TableResources and their operations over a TableResource. </returns>
        public virtual TableCollection GetTables()
        {
            return GetCachedClient(Client => new TableCollection(Client, Id));
        }

        /// <summary>
        /// Gets the table with the specified table name, under the specified account if it exists.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}
        /// Operation Id: Table_Get
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TableResource>> GetTableAsync(string tableName, CancellationToken cancellationToken = default)
        {
            return await GetTables().GetAsync(tableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the table with the specified table name, under the specified account if it exists.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default/tables/{tableName}
        /// Operation Id: Table_Get
        /// </summary>
        /// <param name="tableName"> A table name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of only alphanumeric characters and it cannot begin with a numeric character. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<TableResource> GetTable(string tableName, CancellationToken cancellationToken = default)
        {
            return GetTables().Get(tableName, cancellationToken);
        }

        /// <summary>
        /// Gets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/{tableServiceName}
        /// Operation Id: TableServices_GetServiceProperties
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TableServiceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tableServiceClientDiagnostics.CreateScope("TableServiceResource.Get");
            scope.Start();
            try
            {
                var response = await _tableServiceRestClient.GetServicePropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TableServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/{tableServiceName}
        /// Operation Id: TableServices_GetServiceProperties
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableServiceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tableServiceClientDiagnostics.CreateScope("TableServiceResource.Get");
            scope.Start();
            try
            {
                var response = _tableServiceRestClient.GetServiceProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TableServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/{tableServiceName}
        /// Operation Id: TableServices_SetServiceProperties
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties of a storage account’s Table service, only properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules can be specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TableServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TableServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tableServiceClientDiagnostics.CreateScope("TableServiceResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tableServiceRestClient.SetServicePropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<TableServiceResource>(Response.FromValue(new TableServiceResource(Client, response), response.GetRawResponse()));
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
        /// Sets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/{tableServiceName}
        /// Operation Id: TableServices_SetServiceProperties
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The properties of a storage account’s Table service, only properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules can be specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TableServiceResource> CreateOrUpdate(WaitUntil waitUntil, TableServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tableServiceClientDiagnostics.CreateScope("TableServiceResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tableServiceRestClient.SetServiceProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new StorageArmOperation<TableServiceResource>(Response.FromValue(new TableServiceResource(Client, response), response.GetRawResponse()));
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
    }
}
