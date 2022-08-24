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
    /// A class representing a collection of <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> and their operations.
    /// Each <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> in the collection will belong to the same instance of <see cref="VolumeResource" />.
    /// To get a <see cref="NetAppAccountCapacityPoolVolumeBackupCollection" /> instance call the GetNetAppAccountCapacityPoolVolumeBackups method from an instance of <see cref="VolumeResource" />.
    /// </summary>
    public partial class NetAppAccountCapacityPoolVolumeBackupCollection : ArmCollection, IEnumerable<NetAppAccountCapacityPoolVolumeBackupResource>, IAsyncEnumerable<NetAppAccountCapacityPoolVolumeBackupResource>
    {
        private readonly ClientDiagnostics _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics;
        private readonly BackupsRestOperations _netAppAccountCapacityPoolVolumeBackupBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppAccountCapacityPoolVolumeBackupCollection"/> class for mocking. </summary>
        protected NetAppAccountCapacityPoolVolumeBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppAccountCapacityPoolVolumeBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppAccountCapacityPoolVolumeBackupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppAccountCapacityPoolVolumeBackupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppAccountCapacityPoolVolumeBackupResource.ResourceType, out string netAppAccountCapacityPoolVolumeBackupBackupsApiVersion);
            _netAppAccountCapacityPoolVolumeBackupBackupsRestClient = new BackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppAccountCapacityPoolVolumeBackupBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VolumeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VolumeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a backup for the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="data"> Backup object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppAccountCapacityPoolVolumeBackupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupName, BackupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppAccountCapacityPoolVolumeBackupResource>(new NetAppAccountCapacityPoolVolumeBackupOperationSource(Client), _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a backup for the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="data"> Backup object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppAccountCapacityPoolVolumeBackupResource> CreateOrUpdate(WaitUntil waitUntil, string backupName, BackupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppAccountCapacityPoolVolumeBackupResource>(new NetAppAccountCapacityPoolVolumeBackupOperationSource(Client), _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics, Pipeline, _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<NetAppAccountCapacityPoolVolumeBackupResource>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppAccountCapacityPoolVolumeBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified backup of the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<NetAppAccountCapacityPoolVolumeBackupResource> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppAccountCapacityPoolVolumeBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all backups for a volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups
        /// Operation Id: Backups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppAccountCapacityPoolVolumeBackupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetAppAccountCapacityPoolVolumeBackupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountCapacityPoolVolumeBackupResource(Client, value)), null, response.GetRawResponse());
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
        /// List all backups for a volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups
        /// Operation Id: Backups_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppAccountCapacityPoolVolumeBackupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppAccountCapacityPoolVolumeBackupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetAppAccountCapacityPoolVolumeBackupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetAppAccountCapacityPoolVolumeBackupResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/backups/{backupName}
        /// Operation Id: Backups_Get
        /// </summary>
        /// <param name="backupName"> The name of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _netAppAccountCapacityPoolVolumeBackupBackupsClientDiagnostics.CreateScope("NetAppAccountCapacityPoolVolumeBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppAccountCapacityPoolVolumeBackupBackupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppAccountCapacityPoolVolumeBackupResource> IEnumerable<NetAppAccountCapacityPoolVolumeBackupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppAccountCapacityPoolVolumeBackupResource> IAsyncEnumerable<NetAppAccountCapacityPoolVolumeBackupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
