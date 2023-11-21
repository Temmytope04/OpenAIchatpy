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

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantPacketCoreControlPlaneVersionResource"/> and their operations.
    /// Each <see cref="TenantPacketCoreControlPlaneVersionResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="TenantPacketCoreControlPlaneVersionCollection"/> instance call the GetTenantPacketCoreControlPlaneVersions method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class TenantPacketCoreControlPlaneVersionCollection : ArmCollection, IEnumerable<TenantPacketCoreControlPlaneVersionResource>, IAsyncEnumerable<TenantPacketCoreControlPlaneVersionResource>
    {
        private readonly ClientDiagnostics _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics;
        private readonly PacketCoreControlPlaneVersionsRestOperations _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantPacketCoreControlPlaneVersionCollection"/> class for mocking. </summary>
        protected TenantPacketCoreControlPlaneVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantPacketCoreControlPlaneVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantPacketCoreControlPlaneVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", TenantPacketCoreControlPlaneVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantPacketCoreControlPlaneVersionResource.ResourceType, out string tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
            _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient = new PacketCoreControlPlaneVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<TenantPacketCoreControlPlaneVersionResource>> GetAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetAsync(versionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<TenantPacketCoreControlPlaneVersionResource> Get(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.Get(versionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all supported packet core control planes versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantPacketCoreControlPlaneVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantPacketCoreControlPlaneVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new TenantPacketCoreControlPlaneVersionResource(Client, PacketCoreControlPlaneVersionData.DeserializePacketCoreControlPlaneVersionData(e)), _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics, Pipeline, "TenantPacketCoreControlPlaneVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all supported packet core control planes versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantPacketCoreControlPlaneVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantPacketCoreControlPlaneVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new TenantPacketCoreControlPlaneVersionResource(Client, PacketCoreControlPlaneVersionData.DeserializePacketCoreControlPlaneVersionData(e)), _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics, Pipeline, "TenantPacketCoreControlPlaneVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetAsync(versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<bool> Exists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.Get(versionName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<NullableResponse<TenantPacketCoreControlPlaneVersionResource>> GetIfExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetAsync(versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TenantPacketCoreControlPlaneVersionResource>(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual NullableResponse<TenantPacketCoreControlPlaneVersionResource> GetIfExists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("TenantPacketCoreControlPlaneVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.Get(versionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TenantPacketCoreControlPlaneVersionResource>(response.GetRawResponse());
                return Response.FromValue(new TenantPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TenantPacketCoreControlPlaneVersionResource> IEnumerable<TenantPacketCoreControlPlaneVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantPacketCoreControlPlaneVersionResource> IAsyncEnumerable<TenantPacketCoreControlPlaneVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
