// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
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
    /// A class representing a collection of <see cref="SynapseRestorableDroppedSqlPoolResource" /> and their operations.
    /// Each <see cref="SynapseRestorableDroppedSqlPoolResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseRestorableDroppedSqlPoolCollection" /> instance call the GetSynapseRestorableDroppedSqlPools method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseRestorableDroppedSqlPoolCollection : ArmCollection, IEnumerable<SynapseRestorableDroppedSqlPoolResource>, IAsyncEnumerable<SynapseRestorableDroppedSqlPoolResource>
    {
        private readonly ClientDiagnostics _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics;
        private readonly RestorableDroppedSqlPoolsRestOperations _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseRestorableDroppedSqlPoolCollection"/> class for mocking. </summary>
        protected SynapseRestorableDroppedSqlPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseRestorableDroppedSqlPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseRestorableDroppedSqlPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseRestorableDroppedSqlPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseRestorableDroppedSqlPoolResource.ResourceType, out string synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsApiVersion);
            _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient = new RestorableDroppedSqlPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted sql pool that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedSqlPoolId"> The id of the deleted Sql Pool in the form of sqlPoolName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedSqlPoolId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedSqlPoolId"/> is null. </exception>
        public virtual async Task<Response<SynapseRestorableDroppedSqlPoolResource>> GetAsync(string restorableDroppedSqlPoolId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedSqlPoolId, nameof(restorableDroppedSqlPoolId));

            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedSqlPoolId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseRestorableDroppedSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted sql pool that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedSqlPoolId"> The id of the deleted Sql Pool in the form of sqlPoolName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedSqlPoolId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedSqlPoolId"/> is null. </exception>
        public virtual Response<SynapseRestorableDroppedSqlPoolResource> Get(string restorableDroppedSqlPoolId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedSqlPoolId, nameof(restorableDroppedSqlPoolId));

            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedSqlPoolId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseRestorableDroppedSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of deleted Sql pools that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseRestorableDroppedSqlPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseRestorableDroppedSqlPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new SynapseRestorableDroppedSqlPoolResource(Client, SynapseRestorableDroppedSqlPoolData.DeserializeSynapseRestorableDroppedSqlPoolData(e)), _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics, Pipeline, "SynapseRestorableDroppedSqlPoolCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of deleted Sql pools that can be restored
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseRestorableDroppedSqlPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseRestorableDroppedSqlPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new SynapseRestorableDroppedSqlPoolResource(Client, SynapseRestorableDroppedSqlPoolData.DeserializeSynapseRestorableDroppedSqlPoolData(e)), _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics, Pipeline, "SynapseRestorableDroppedSqlPoolCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedSqlPoolId"> The id of the deleted Sql Pool in the form of sqlPoolName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedSqlPoolId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedSqlPoolId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorableDroppedSqlPoolId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedSqlPoolId, nameof(restorableDroppedSqlPoolId));

            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedSqlPoolId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/restorableDroppedSqlPools/{restorableDroppedSqlPoolId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedSqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorableDroppedSqlPoolId"> The id of the deleted Sql Pool in the form of sqlPoolName,deletionTimeInFileTimeFormat. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorableDroppedSqlPoolId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorableDroppedSqlPoolId"/> is null. </exception>
        public virtual Response<bool> Exists(string restorableDroppedSqlPoolId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorableDroppedSqlPoolId, nameof(restorableDroppedSqlPoolId));

            using var scope = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsClientDiagnostics.CreateScope("SynapseRestorableDroppedSqlPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseRestorableDroppedSqlPoolRestorableDroppedSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorableDroppedSqlPoolId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseRestorableDroppedSqlPoolResource> IEnumerable<SynapseRestorableDroppedSqlPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseRestorableDroppedSqlPoolResource> IAsyncEnumerable<SynapseRestorableDroppedSqlPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
