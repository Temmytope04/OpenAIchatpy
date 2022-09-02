// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppVolumeGroupResource" /> and their operations.
    /// Each <see cref="NetAppVolumeGroupResource" /> in the collection will belong to the same instance of <see cref="NetAppAccountResource" />.
    /// To get a <see cref="NetAppVolumeGroupCollection" /> instance call the GetNetAppVolumeGroups method from an instance of <see cref="NetAppAccountResource" />.
    /// </summary>
    public partial class NetAppVolumeGroupCollection : ArmCollection, IEnumerable<NetAppVolumeGroupResource>, IAsyncEnumerable<NetAppVolumeGroupResource>
    {
        private readonly ClientDiagnostics _netAppVolumeGroupVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _netAppVolumeGroupVolumeGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeGroupCollection"/> class for mocking. </summary>
        protected NetAppVolumeGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppVolumeGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppVolumeGroupVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppVolumeGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppVolumeGroupResource.ResourceType, out string netAppVolumeGroupVolumeGroupsApiVersion);
            _netAppVolumeGroupVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeGroupVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a volume group along with specified volumes
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="data"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppVolumeGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeGroupName, NetAppVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppVolumeGroupResource>(new NetAppVolumeGroupOperationSource(Client), _netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a volume group along with specified volumes
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="data"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppVolumeGroupResource> CreateOrUpdate(WaitUntil waitUntil, string volumeGroupName, NetAppVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppVolumeGroupResource>(new NetAppVolumeGroupOperationSource(Client), _netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get details of the specified volume group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<NetAppVolumeGroupResource>> GetAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified volume group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<NetAppVolumeGroupResource> Get(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all volume groups for given account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups
        /// Operation Id: VolumeGroups_ListByNetAppAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppVolumeGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppVolumeGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetAppVolumeGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _netAppVolumeGroupVolumeGroupsRestClient.ListByNetAppAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppVolumeGroupResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all volume groups for given account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups
        /// Operation Id: VolumeGroups_ListByNetAppAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppVolumeGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppVolumeGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetAppVolumeGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _netAppVolumeGroupVolumeGroupsRestClient.ListByNetAppAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppVolumeGroupResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}
        /// Operation Id: VolumeGroups_Get
        /// </summary>
        /// <param name="volumeGroupName"> The name of the volumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppVolumeGroupResource> IEnumerable<NetAppVolumeGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppVolumeGroupResource> IAsyncEnumerable<NetAppVolumeGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
