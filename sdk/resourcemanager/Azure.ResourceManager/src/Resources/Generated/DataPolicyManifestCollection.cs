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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="DataPolicyManifestResource" /> and their operations.
    /// Each <see cref="DataPolicyManifestResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="DataPolicyManifestCollection" /> instance call the GetDataPolicyManifests method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class DataPolicyManifestCollection : ArmCollection, IEnumerable<DataPolicyManifestResource>, IAsyncEnumerable<DataPolicyManifestResource>
    {
        private readonly ClientDiagnostics _dataPolicyManifestClientDiagnostics;
        private readonly DataPolicyManifestsRestOperations _dataPolicyManifestRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestCollection"/> class for mocking. </summary>
        protected DataPolicyManifestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataPolicyManifestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataPolicyManifestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataPolicyManifestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", DataPolicyManifestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataPolicyManifestResource.ResourceType, out string dataPolicyManifestApiVersion);
            _dataPolicyManifestRestClient = new DataPolicyManifestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataPolicyManifestApiVersion);
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
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual async Task<Response<DataPolicyManifestResource>> GetAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyMode, nameof(policyMode));

            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataPolicyManifestRestClient.GetByPolicyModeAsync(policyMode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataPolicyManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves the data policy manifest with the given policy mode.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<DataPolicyManifestResource> Get(string policyMode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyMode, nameof(policyMode));

            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestCollection.Get");
            scope.Start();
            try
            {
                var response = _dataPolicyManifestRestClient.GetByPolicyMode(policyMode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataPolicyManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: "$filter=namespace eq '{0}'". If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: "namespace eq '{value}'". If $filter is not provided, no filtering is performed. If $filter=namespace eq '{value}' is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataPolicyManifestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataPolicyManifestResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataPolicyManifestRestClient.CreateListRequest(filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataPolicyManifestRestClient.CreateListNextPageRequest(nextLink, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataPolicyManifestResource(Client, DataPolicyManifestData.DeserializeDataPolicyManifestData(e)), _dataPolicyManifestClientDiagnostics, Pipeline, "DataPolicyManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// This operation retrieves a list of all the data policy manifests that match the optional given $filter. Valid values for $filter are: "$filter=namespace eq '{0}'". If $filter is not provided, the unfiltered list includes all data policy manifests for data resource types. If $filter=namespace is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: "namespace eq '{value}'". If $filter is not provided, no filtering is performed. If $filter=namespace eq '{value}' is provided, the returned list only includes all data policy manifests that have a namespace matching the provided value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataPolicyManifestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataPolicyManifestResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataPolicyManifestRestClient.CreateListRequest(filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataPolicyManifestRestClient.CreateListNextPageRequest(nextLink, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataPolicyManifestResource(Client, DataPolicyManifestData.DeserializeDataPolicyManifestData(e)), _dataPolicyManifestClientDiagnostics, Pipeline, "DataPolicyManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string policyMode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyMode, nameof(policyMode));

            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataPolicyManifestRestClient.GetByPolicyModeAsync(policyMode, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Authorization/dataPolicyManifests/{policyMode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataPolicyManifests_GetByPolicyMode</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyMode"> The policy mode of the data policy manifest to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyMode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyMode"/> is null. </exception>
        public virtual Response<bool> Exists(string policyMode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyMode, nameof(policyMode));

            using var scope = _dataPolicyManifestClientDiagnostics.CreateScope("DataPolicyManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataPolicyManifestRestClient.GetByPolicyMode(policyMode, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataPolicyManifestResource> IEnumerable<DataPolicyManifestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataPolicyManifestResource> IAsyncEnumerable<DataPolicyManifestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
