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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="RegionInfoResource"/> and their operations.
    /// Each <see cref="RegionInfoResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="RegionInfoResourceCollection"/> instance call the GetRegionInfoResources method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class RegionInfoResourceCollection : ArmCollection, IEnumerable<RegionInfoResource>, IAsyncEnumerable<RegionInfoResource>
    {
        private readonly ClientDiagnostics _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics;
        private readonly NetAppResourceRegionInfosRestOperations _regionInfoResourceNetAppResourceRegionInfosRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="RegionInfoResourceCollection"/> class for mocking. </summary>
        protected RegionInfoResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegionInfoResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of the Azure region. </param>
        internal RegionInfoResourceCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", RegionInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RegionInfoResource.ResourceType, out string regionInfoResourceNetAppResourceRegionInfosApiVersion);
            _regionInfoResourceNetAppResourceRegionInfosRestClient = new NetAppResourceRegionInfosRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regionInfoResourceNetAppResourceRegionInfosApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegionInfoResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _regionInfoResourceNetAppResourceRegionInfosRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides storage to network proximity and logical zone mapping information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegionInfoResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _regionInfoResourceNetAppResourceRegionInfosRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Provides region specific information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegionInfoResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegionInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regionInfoResourceNetAppResourceRegionInfosRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regionInfoResourceNetAppResourceRegionInfosRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RegionInfoResource(Client, RegionInfoResourceData.DeserializeRegionInfoResourceData(e)), _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics, Pipeline, "RegionInfoResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Provides region specific information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegionInfoResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegionInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regionInfoResourceNetAppResourceRegionInfosRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regionInfoResourceNetAppResourceRegionInfosRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RegionInfoResource(Client, RegionInfoResourceData.DeserializeRegionInfoResourceData(e)), _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics, Pipeline, "RegionInfoResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _regionInfoResourceNetAppResourceRegionInfosRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _regionInfoResourceNetAppResourceRegionInfosRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<RegionInfoResource>> GetIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _regionInfoResourceNetAppResourceRegionInfosRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RegionInfoResource>(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetApp/locations/{location}/regionInfos/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetAppResourceRegionInfos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RegionInfoResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<RegionInfoResource> GetIfExists(CancellationToken cancellationToken = default)
        {
            using var scope = _regionInfoResourceNetAppResourceRegionInfosClientDiagnostics.CreateScope("RegionInfoResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _regionInfoResourceNetAppResourceRegionInfosRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RegionInfoResource>(response.GetRawResponse());
                return Response.FromValue(new RegionInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RegionInfoResource> IEnumerable<RegionInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RegionInfoResource> IAsyncEnumerable<RegionInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
