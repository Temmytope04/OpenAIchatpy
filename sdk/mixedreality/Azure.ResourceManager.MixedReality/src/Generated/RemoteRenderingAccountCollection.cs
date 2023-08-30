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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MixedReality
{
    /// <summary>
    /// A class representing a collection of <see cref="RemoteRenderingAccountResource" /> and their operations.
    /// Each <see cref="RemoteRenderingAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RemoteRenderingAccountCollection" /> instance call the GetRemoteRenderingAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RemoteRenderingAccountCollection : ArmCollection, IEnumerable<RemoteRenderingAccountResource>, IAsyncEnumerable<RemoteRenderingAccountResource>
    {
        private readonly ClientDiagnostics _remoteRenderingAccountClientDiagnostics;
        private readonly RemoteRenderingAccountsRestOperations _remoteRenderingAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="RemoteRenderingAccountCollection"/> class for mocking. </summary>
        protected RemoteRenderingAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RemoteRenderingAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RemoteRenderingAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _remoteRenderingAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MixedReality", RemoteRenderingAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RemoteRenderingAccountResource.ResourceType, out string remoteRenderingAccountApiVersion);
            _remoteRenderingAccountRestClient = new RemoteRenderingAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, remoteRenderingAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creating or Updating a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Remote Rendering Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RemoteRenderingAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, RemoteRenderingAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _remoteRenderingAccountRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MixedRealityArmOperation<RemoteRenderingAccountResource>(Response.FromValue(new RemoteRenderingAccountResource(Client, response), response.GetRawResponse()));
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
        /// Creating or Updating a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="data"> Remote Rendering Account parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RemoteRenderingAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, RemoteRenderingAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _remoteRenderingAccountRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken);
                var operation = new MixedRealityArmOperation<RemoteRenderingAccountResource>(Response.FromValue(new RemoteRenderingAccountResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<RemoteRenderingAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _remoteRenderingAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RemoteRenderingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a Remote Rendering Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<RemoteRenderingAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _remoteRenderingAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RemoteRenderingAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Resources by Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RemoteRenderingAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _remoteRenderingAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _remoteRenderingAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RemoteRenderingAccountResource(Client, RemoteRenderingAccountData.DeserializeRemoteRenderingAccountData(e)), _remoteRenderingAccountClientDiagnostics, Pipeline, "RemoteRenderingAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Resources by Resource Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RemoteRenderingAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _remoteRenderingAccountRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _remoteRenderingAccountRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RemoteRenderingAccountResource(Client, RemoteRenderingAccountData.DeserializeRemoteRenderingAccountData(e)), _remoteRenderingAccountClientDiagnostics, Pipeline, "RemoteRenderingAccountCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _remoteRenderingAccountRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MixedReality/remoteRenderingAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accountName"> Name of an Mixed Reality Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _remoteRenderingAccountClientDiagnostics.CreateScope("RemoteRenderingAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _remoteRenderingAccountRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RemoteRenderingAccountResource> IEnumerable<RemoteRenderingAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RemoteRenderingAccountResource> IAsyncEnumerable<RemoteRenderingAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
