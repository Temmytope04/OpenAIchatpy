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

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary>
    /// A class representing a collection of <see cref="ElasticSanVolumeGroupResource"/> and their operations.
    /// Each <see cref="ElasticSanVolumeGroupResource"/> in the collection will belong to the same instance of <see cref="ElasticSanResource"/>.
    /// To get an <see cref="ElasticSanVolumeGroupCollection"/> instance call the GetElasticSanVolumeGroups method from an instance of <see cref="ElasticSanResource"/>.
    /// </summary>
    public partial class ElasticSanVolumeGroupCollection : ArmCollection, IEnumerable<ElasticSanVolumeGroupResource>, IAsyncEnumerable<ElasticSanVolumeGroupResource>
    {
        private readonly ClientDiagnostics _elasticSanVolumeGroupVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _elasticSanVolumeGroupVolumeGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupCollection"/> class for mocking. </summary>
        protected ElasticSanVolumeGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticSanVolumeGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticSanVolumeGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticSanVolumeGroupVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ElasticSan", ElasticSanVolumeGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticSanVolumeGroupResource.ResourceType, out string elasticSanVolumeGroupVolumeGroupsApiVersion);
            _elasticSanVolumeGroupVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticSanVolumeGroupVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ElasticSanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ElasticSanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Volume Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticSanVolumeGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Volume Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="data"> Volume Group object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ElasticSanVolumeGroupResource> CreateOrUpdate(WaitUntil waitUntil, string volumeGroupName, ElasticSanVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data, cancellationToken);
                var operation = new ElasticSanArmOperation<ElasticSanVolumeGroupResource>(new ElasticSanVolumeGroupOperationSource(Client), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _elasticSanVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get an VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<ElasticSanVolumeGroupResource>> GetAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<ElasticSanVolumeGroupResource> Get(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_ListByElasticSan</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanVolumeGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticSanVolumeGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanVolumeGroupVolumeGroupsRestClient.CreateListByElasticSanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanVolumeGroupVolumeGroupsRestClient.CreateListByElasticSanNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ElasticSanVolumeGroupResource(Client, ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(e)), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, "ElasticSanVolumeGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List VolumeGroups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumeGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_ListByElasticSan</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanVolumeGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticSanVolumeGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _elasticSanVolumeGroupVolumeGroupsRestClient.CreateListByElasticSanRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _elasticSanVolumeGroupVolumeGroupsRestClient.CreateListByElasticSanNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ElasticSanVolumeGroupResource(Client, ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(e)), _elasticSanVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, "ElasticSanVolumeGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<ElasticSanVolumeGroupResource>> GetIfExistsAsync(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _elasticSanVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ElasticSanVolumeGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ElasticSanVolumeGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeGroupName"> The name of the VolumeGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeGroupName"/> is null. </exception>
        public virtual NullableResponse<ElasticSanVolumeGroupResource> GetIfExists(string volumeGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeGroupName, nameof(volumeGroupName));

            using var scope = _elasticSanVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("ElasticSanVolumeGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _elasticSanVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, volumeGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ElasticSanVolumeGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ElasticSanVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticSanVolumeGroupResource> IEnumerable<ElasticSanVolumeGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticSanVolumeGroupResource> IAsyncEnumerable<ElasticSanVolumeGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
