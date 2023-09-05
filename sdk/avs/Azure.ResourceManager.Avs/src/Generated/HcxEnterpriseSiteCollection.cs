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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="HcxEnterpriseSiteResource" /> and their operations.
    /// Each <see cref="HcxEnterpriseSiteResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="HcxEnterpriseSiteCollection" /> instance call the GetHcxEnterpriseSites method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class HcxEnterpriseSiteCollection : ArmCollection, IEnumerable<HcxEnterpriseSiteResource>, IAsyncEnumerable<HcxEnterpriseSiteResource>
    {
        private readonly ClientDiagnostics _hcxEnterpriseSiteClientDiagnostics;
        private readonly HcxEnterpriseSitesRestOperations _hcxEnterpriseSiteRestClient;

        /// <summary> Initializes a new instance of the <see cref="HcxEnterpriseSiteCollection"/> class for mocking. </summary>
        protected HcxEnterpriseSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HcxEnterpriseSiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HcxEnterpriseSiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hcxEnterpriseSiteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", HcxEnterpriseSiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HcxEnterpriseSiteResource.ResourceType, out string hcxEnterpriseSiteApiVersion);
            _hcxEnterpriseSiteRestClient = new HcxEnterpriseSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hcxEnterpriseSiteApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an HCX Enterprise Site in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="data"> The HCX Enterprise Site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HcxEnterpriseSiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hcxEnterpriseSiteName, HcxEnterpriseSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hcxEnterpriseSiteRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<HcxEnterpriseSiteResource>(Response.FromValue(new HcxEnterpriseSiteResource(Client, response), response.GetRawResponse()));
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
        /// Create or update an HCX Enterprise Site in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="data"> The HCX Enterprise Site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HcxEnterpriseSiteResource> CreateOrUpdate(WaitUntil waitUntil, string hcxEnterpriseSiteName, HcxEnterpriseSiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hcxEnterpriseSiteRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, data, cancellationToken);
                var operation = new AvsArmOperation<HcxEnterpriseSiteResource>(Response.FromValue(new HcxEnterpriseSiteResource(Client, response), response.GetRawResponse()));
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
        /// Get an HCX Enterprise Site by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public virtual async Task<Response<HcxEnterpriseSiteResource>> GetAsync(string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _hcxEnterpriseSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HcxEnterpriseSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an HCX Enterprise Site by name in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public virtual Response<HcxEnterpriseSiteResource> Get(string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.Get");
            scope.Start();
            try
            {
                var response = _hcxEnterpriseSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HcxEnterpriseSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List HCX Enterprise Sites in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HcxEnterpriseSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HcxEnterpriseSiteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hcxEnterpriseSiteRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hcxEnterpriseSiteRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HcxEnterpriseSiteResource(Client, HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(e)), _hcxEnterpriseSiteClientDiagnostics, Pipeline, "HcxEnterpriseSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List HCX Enterprise Sites in a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HcxEnterpriseSiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HcxEnterpriseSiteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hcxEnterpriseSiteRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hcxEnterpriseSiteRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HcxEnterpriseSiteResource(Client, HcxEnterpriseSiteData.DeserializeHcxEnterpriseSiteData(e)), _hcxEnterpriseSiteClientDiagnostics, Pipeline, "HcxEnterpriseSiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hcxEnterpriseSiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HcxEnterpriseSites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hcxEnterpriseSiteName"> Name of the HCX Enterprise Site in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcxEnterpriseSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcxEnterpriseSiteName"/> is null. </exception>
        public virtual Response<bool> Exists(string hcxEnterpriseSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcxEnterpriseSiteName, nameof(hcxEnterpriseSiteName));

            using var scope = _hcxEnterpriseSiteClientDiagnostics.CreateScope("HcxEnterpriseSiteCollection.Exists");
            scope.Start();
            try
            {
                var response = _hcxEnterpriseSiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hcxEnterpriseSiteName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HcxEnterpriseSiteResource> IEnumerable<HcxEnterpriseSiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HcxEnterpriseSiteResource> IAsyncEnumerable<HcxEnterpriseSiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
