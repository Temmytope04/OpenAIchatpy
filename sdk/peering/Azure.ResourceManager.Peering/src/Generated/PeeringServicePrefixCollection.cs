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

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing a collection of <see cref="PeeringServicePrefixResource" /> and their operations.
    /// Each <see cref="PeeringServicePrefixResource" /> in the collection will belong to the same instance of <see cref="PeeringServiceResource" />.
    /// To get a <see cref="PeeringServicePrefixCollection" /> instance call the GetPeeringServicePrefixes method from an instance of <see cref="PeeringServiceResource" />.
    /// </summary>
    public partial class PeeringServicePrefixCollection : ArmCollection, IEnumerable<PeeringServicePrefixResource>, IAsyncEnumerable<PeeringServicePrefixResource>
    {
        private readonly ClientDiagnostics _peeringServicePrefixPrefixesClientDiagnostics;
        private readonly PrefixesRestOperations _peeringServicePrefixPrefixesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PeeringServicePrefixCollection"/> class for mocking. </summary>
        protected PeeringServicePrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeeringServicePrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PeeringServicePrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peeringServicePrefixPrefixesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", PeeringServicePrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PeeringServicePrefixResource.ResourceType, out string peeringServicePrefixPrefixesApiVersion);
            _peeringServicePrefixPrefixesRestClient = new PrefixesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peeringServicePrefixPrefixesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PeeringServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PeeringServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new prefix with the specified name under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="data"> The properties needed to create a prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeeringServicePrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string prefixName, PeeringServicePrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _peeringServicePrefixPrefixesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeeringServicePrefixResource>(Response.FromValue(new PeeringServicePrefixResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new prefix with the specified name under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="data"> The properties needed to create a prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeeringServicePrefixResource> CreateOrUpdate(WaitUntil waitUntil, string prefixName, PeeringServicePrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _peeringServicePrefixPrefixesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, data, cancellationToken);
                var operation = new PeeringArmOperation<PeeringServicePrefixResource>(Response.FromValue(new PeeringServicePrefixResource(Client, response), response.GetRawResponse()));
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
        /// Gets an existing prefix with the specified name under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual async Task<Response<PeeringServicePrefixResource>> GetAsync(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _peeringServicePrefixPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringServicePrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing prefix with the specified name under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual Response<PeeringServicePrefixResource> Get(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _peeringServicePrefixPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeeringServicePrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all prefixes under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_ListByPeeringService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeeringServicePrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PeeringServicePrefixResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringServicePrefixPrefixesRestClient.CreateListByPeeringServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringServicePrefixPrefixesRestClient.CreateListByPeeringServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PeeringServicePrefixResource(Client, PeeringServicePrefixData.DeserializePeeringServicePrefixData(e)), _peeringServicePrefixPrefixesClientDiagnostics, Pipeline, "PeeringServicePrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all prefixes under the given subscription, resource group and peering service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_ListByPeeringService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeeringServicePrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PeeringServicePrefixResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _peeringServicePrefixPrefixesRestClient.CreateListByPeeringServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _peeringServicePrefixPrefixesRestClient.CreateListByPeeringServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PeeringServicePrefixResource(Client, PeeringServicePrefixData.DeserializePeeringServicePrefixData(e)), _peeringServicePrefixPrefixesClientDiagnostics, Pipeline, "PeeringServicePrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _peeringServicePrefixPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual Response<bool> Exists(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _peeringServicePrefixPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual async Task<NullableResponse<PeeringServicePrefixResource>> GetIfExistsAsync(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _peeringServicePrefixPrefixesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PeeringServicePrefixResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringServicePrefixResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Peering/peeringServices/{peeringServiceName}/prefixes/{prefixName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Prefixes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="prefixName"/> is null. </exception>
        public virtual NullableResponse<PeeringServicePrefixResource> GetIfExists(string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var scope = _peeringServicePrefixPrefixesClientDiagnostics.CreateScope("PeeringServicePrefixCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _peeringServicePrefixPrefixesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, prefixName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PeeringServicePrefixResource>(response.GetRawResponse());
                return Response.FromValue(new PeeringServicePrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PeeringServicePrefixResource> IEnumerable<PeeringServicePrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PeeringServicePrefixResource> IAsyncEnumerable<PeeringServicePrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
