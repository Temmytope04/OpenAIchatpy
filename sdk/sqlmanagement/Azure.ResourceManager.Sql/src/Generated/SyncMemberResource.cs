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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SyncMember along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SyncMemberResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSyncMemberResource method.
    /// Otherwise you can get one from its parent resource <see cref="SyncGroupResource" /> using the GetSyncMember method.
    /// </summary>
    public partial class SyncMemberResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SyncMemberResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string syncGroupName, string syncMemberName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _syncMemberClientDiagnostics;
        private readonly SyncMembersRestOperations _syncMemberRestClient;
        private readonly SyncMemberData _data;

        /// <summary> Initializes a new instance of the <see cref="SyncMemberResource"/> class for mocking. </summary>
        protected SyncMemberResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SyncMemberResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SyncMemberResource(ArmClient client, SyncMemberData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SyncMemberResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SyncMemberResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncMemberClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string syncMemberApiVersion);
            _syncMemberRestClient = new SyncMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncMemberApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/syncGroups/syncMembers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SyncMemberData Data
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
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SyncMemberResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Get");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SyncMemberResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Get");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Delete");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Delete");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested sync member resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncMemberResource>> UpdateAsync(WaitUntil waitUntil, SyncMemberData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Update");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncMemberResource>(new SyncMemberOperationSource(Client), _syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested sync member resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SyncMemberResource> Update(WaitUntil waitUntil, SyncMemberData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.Update");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<SyncMemberResource>(new SyncMemberOperationSource(Client), _syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a sync member database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_ListMemberSchemas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncFullSchemaProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncFullSchemaProperties> GetMemberSchemasAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncMemberRestClient.CreateListMemberSchemasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncMemberRestClient.CreateListMemberSchemasNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SyncFullSchemaProperties.DeserializeSyncFullSchemaProperties, _syncMemberClientDiagnostics, Pipeline, "SyncMemberResource.GetMemberSchemas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a sync member database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}/schemas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_ListMemberSchemas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncFullSchemaProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncFullSchemaProperties> GetMemberSchemas(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncMemberRestClient.CreateListMemberSchemasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncMemberRestClient.CreateListMemberSchemasNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SyncFullSchemaProperties.DeserializeSyncFullSchemaProperties, _syncMemberClientDiagnostics, Pipeline, "SyncMemberResource.GetMemberSchemas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Refreshes a sync member database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}/refreshSchema</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_RefreshMemberSchema</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> RefreshMemberSchemaAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.RefreshMemberSchema");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.RefreshMemberSchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateRefreshMemberSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refreshes a sync member database schema.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}/refreshSchema</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_RefreshMemberSchema</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation RefreshMemberSchema(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberResource.RefreshMemberSchema");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.RefreshMemberSchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateRefreshMemberSchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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
