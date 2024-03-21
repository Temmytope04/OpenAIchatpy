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
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppSubvolumeInfoResource"/> and their operations.
    /// Each <see cref="NetAppSubvolumeInfoResource"/> in the collection will belong to the same instance of <see cref="NetAppVolumeResource"/>.
    /// To get a <see cref="NetAppSubvolumeInfoCollection"/> instance call the GetNetAppSubvolumeInfos method from an instance of <see cref="NetAppVolumeResource"/>.
    /// </summary>
    public partial class NetAppSubvolumeInfoCollection : ArmCollection, IEnumerable<NetAppSubvolumeInfoResource>, IAsyncEnumerable<NetAppSubvolumeInfoResource>
    {
        private readonly ClientDiagnostics _netAppSubvolumeInfoSubvolumesClientDiagnostics;
        private readonly SubvolumesRestOperations _netAppSubvolumeInfoSubvolumesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppSubvolumeInfoCollection"/> class for mocking. </summary>
        protected NetAppSubvolumeInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppSubvolumeInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppSubvolumeInfoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppSubvolumeInfoSubvolumesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppSubvolumeInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppSubvolumeInfoResource.ResourceType, out string netAppSubvolumeInfoSubvolumesApiVersion);
            _netAppSubvolumeInfoSubvolumesRestClient = new SubvolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppSubvolumeInfoSubvolumesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppVolumeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppVolumeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a subvolume in the path or clones the subvolume mentioned in the parentPath
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="info"> Subvolume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> or <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppSubvolumeInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subvolumeName, NetAppSubvolumeInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppSubvolumeInfoSubvolumesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppSubvolumeInfoResource>(new NetAppSubvolumeInfoOperationSource(Client), _netAppSubvolumeInfoSubvolumesClientDiagnostics, Pipeline, _netAppSubvolumeInfoSubvolumesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a subvolume in the path or clones the subvolume mentioned in the parentPath
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="info"> Subvolume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> or <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<NetAppSubvolumeInfoResource> CreateOrUpdate(WaitUntil waitUntil, string subvolumeName, NetAppSubvolumeInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppSubvolumeInfoSubvolumesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info, cancellationToken);
                var operation = new NetAppArmOperation<NetAppSubvolumeInfoResource>(new NetAppSubvolumeInfoOperationSource(Client), _netAppSubvolumeInfoSubvolumesClientDiagnostics, Pipeline, _netAppSubvolumeInfoSubvolumesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns the path associated with the subvolumeName provided
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual async Task<Response<NetAppSubvolumeInfoResource>> GetAsync(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppSubvolumeInfoSubvolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppSubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the path associated with the subvolumeName provided
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual Response<NetAppSubvolumeInfoResource> Get(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppSubvolumeInfoSubvolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppSubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of the subvolumes in the volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_ListByVolume</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppSubvolumeInfoResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppSubvolumeInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppSubvolumeInfoSubvolumesRestClient.CreateListByVolumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppSubvolumeInfoSubvolumesRestClient.CreateListByVolumeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetAppSubvolumeInfoResource(Client, NetAppSubvolumeInfoData.DeserializeNetAppSubvolumeInfoData(e)), _netAppSubvolumeInfoSubvolumesClientDiagnostics, Pipeline, "NetAppSubvolumeInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of the subvolumes in the volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_ListByVolume</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppSubvolumeInfoResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppSubvolumeInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppSubvolumeInfoSubvolumesRestClient.CreateListByVolumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppSubvolumeInfoSubvolumesRestClient.CreateListByVolumeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetAppSubvolumeInfoResource(Client, NetAppSubvolumeInfoData.DeserializeNetAppSubvolumeInfoData(e)), _netAppSubvolumeInfoSubvolumesClientDiagnostics, Pipeline, "NetAppSubvolumeInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppSubvolumeInfoSubvolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual Response<bool> Exists(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppSubvolumeInfoSubvolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetAppSubvolumeInfoResource>> GetIfExistsAsync(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _netAppSubvolumeInfoSubvolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetAppSubvolumeInfoResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppSubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subvolumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppSubvolumeInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual NullableResponse<NetAppSubvolumeInfoResource> GetIfExists(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _netAppSubvolumeInfoSubvolumesClientDiagnostics.CreateScope("NetAppSubvolumeInfoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _netAppSubvolumeInfoSubvolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetAppSubvolumeInfoResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppSubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppSubvolumeInfoResource> IEnumerable<NetAppSubvolumeInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppSubvolumeInfoResource> IAsyncEnumerable<NetAppSubvolumeInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
