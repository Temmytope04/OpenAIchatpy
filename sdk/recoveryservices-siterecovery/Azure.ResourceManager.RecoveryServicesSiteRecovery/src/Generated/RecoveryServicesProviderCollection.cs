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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="RecoveryServicesProviderResource" /> and their operations.
    /// Each <see cref="RecoveryServicesProviderResource" /> in the collection will belong to the same instance of <see cref="FabricResource" />.
    /// To get a <see cref="RecoveryServicesProviderCollection" /> instance call the GetRecoveryServicesProviders method from an instance of <see cref="FabricResource" />.
    /// </summary>
    public partial class RecoveryServicesProviderCollection : ArmCollection, IEnumerable<RecoveryServicesProviderResource>, IAsyncEnumerable<RecoveryServicesProviderResource>
    {
        private readonly ClientDiagnostics _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics;
        private readonly ReplicationRecoveryServicesProvidersRestOperations _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecoveryServicesProviderCollection"/> class for mocking. </summary>
        protected RecoveryServicesProviderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoveryServicesProviderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RecoveryServicesProviderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", RecoveryServicesProviderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoveryServicesProviderResource.ResourceType, out string recoveryServicesProviderReplicationRecoveryServicesProvidersApiVersion);
            _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient = new ReplicationRecoveryServicesProvidersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoveryServicesProviderReplicationRecoveryServicesProvidersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to add a recovery services provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="content"> Add provider input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RecoveryServicesProviderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string providerName, RecoveryServicesProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<RecoveryServicesProviderResource>(new RecoveryServicesProviderOperationSource(Client), _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics, Pipeline, _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to add a recovery services provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="content"> Add provider input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RecoveryServicesProviderResource> CreateOrUpdate(WaitUntil waitUntil, string providerName, RecoveryServicesProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<RecoveryServicesProviderResource>(new RecoveryServicesProviderOperationSource(Client), _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics, Pipeline, _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of registered recovery services provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Get
        /// </summary>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual async Task<Response<RecoveryServicesProviderResource>> GetAsync(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of registered recovery services provider.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Get
        /// </summary>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual Response<RecoveryServicesProviderResource> Get(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.Get");
            scope.Start();
            try
            {
                var response = _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryServicesProviderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the registered recovery services providers for the specified fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders
        /// Operation Id: ReplicationRecoveryServicesProviders_ListByReplicationFabrics
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoveryServicesProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoveryServicesProviderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RecoveryServicesProviderResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.ListByReplicationFabricsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoveryServicesProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RecoveryServicesProviderResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.ListByReplicationFabricsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoveryServicesProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the registered recovery services providers for the specified fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders
        /// Operation Id: ReplicationRecoveryServicesProviders_ListByReplicationFabrics
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoveryServicesProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoveryServicesProviderResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RecoveryServicesProviderResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.ListByReplicationFabrics(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoveryServicesProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RecoveryServicesProviderResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.ListByReplicationFabricsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecoveryServicesProviderResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Get
        /// </summary>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationRecoveryServicesProviders/{providerName}
        /// Operation Id: ReplicationRecoveryServicesProviders_Get
        /// </summary>
        /// <param name="providerName"> Recovery services provider name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/> is null. </exception>
        public virtual Response<bool> Exists(string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(providerName, nameof(providerName));

            using var scope = _recoveryServicesProviderReplicationRecoveryServicesProvidersClientDiagnostics.CreateScope("RecoveryServicesProviderCollection.Exists");
            scope.Start();
            try
            {
                var response = _recoveryServicesProviderReplicationRecoveryServicesProvidersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, providerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecoveryServicesProviderResource> IEnumerable<RecoveryServicesProviderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoveryServicesProviderResource> IAsyncEnumerable<RecoveryServicesProviderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
