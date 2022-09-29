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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SqlPoolTable along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlPoolTableResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlPoolTableResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlPoolSchemaResource" /> using the GetSqlPoolTable method.
    /// </summary>
    public partial class SqlPoolTableResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlPoolTableResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlPoolTableClientDiagnostics;
        private readonly SqlPoolTablesRestOperations _sqlPoolTableRestClient;
        private readonly SqlPoolTableData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlPoolTableResource"/> class for mocking. </summary>
        protected SqlPoolTableResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlPoolTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlPoolTableResource(ArmClient client, SqlPoolTableData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlPoolTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlPoolTableResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlPoolTableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlPoolTableApiVersion);
            _sqlPoolTableRestClient = new SqlPoolTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlPoolTableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/schemas/tables";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlPoolTableData Data
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

        /// <summary> Gets a collection of SqlPoolColumnResources in the SqlPoolTable. </summary>
        /// <returns> An object representing collection of SqlPoolColumnResources and their operations over a SqlPoolColumnResource. </returns>
        public virtual SqlPoolColumnCollection GetSqlPoolColumns()
        {
            return GetCachedClient(Client => new SqlPoolColumnCollection(Client, Id));
        }

        /// <summary>
        /// Get Sql pool column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: SqlPoolColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlPoolColumnResource>> GetSqlPoolColumnAsync(string columnName, CancellationToken cancellationToken = default)
        {
            return await GetSqlPoolColumns().GetAsync(columnName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Sql pool column
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// Operation Id: SqlPoolColumns_Get
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlPoolColumnResource> GetSqlPoolColumn(string columnName, CancellationToken cancellationToken = default)
        {
            return GetSqlPoolColumns().Get(columnName, cancellationToken);
        }

        /// <summary>
        /// Get Sql pool table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: SqlPoolTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlPoolTableResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolTableClientDiagnostics.CreateScope("SqlPoolTableResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlPoolTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql pool table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}
        /// Operation Id: SqlPoolTables_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlPoolTableResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlPoolTableClientDiagnostics.CreateScope("SqlPoolTableResource.Get");
            scope.Start();
            try
            {
                var response = _sqlPoolTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
