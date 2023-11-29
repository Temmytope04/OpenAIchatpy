// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeMarketplace
{
    /// <summary>
    /// A class representing a collection of <see cref="PublisherResource"/> and their operations.
    /// Each <see cref="PublisherResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="PublisherCollection"/> instance call the GetPublishers method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class PublisherCollection : ArmCollection, IEnumerable<PublisherResource>, IAsyncEnumerable<PublisherResource>
    {
        private readonly ClientDiagnostics _publisherClientDiagnostics;
        private readonly PublishersRestOperations _publisherRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class for mocking. </summary>
        protected PublisherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublisherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publisherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeMarketplace", PublisherResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublisherResource.ResourceType, out string publisherApiVersion);
            _publisherRestClient = new PublishersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publisherApiVersion);
        }

        /// <summary>
        /// Get a Publisher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<PublisherResource>> GetAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id, publisherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Publisher
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<PublisherResource> Get(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id, publisherName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Publisher resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_List</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeMarketplace/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublisherResource> GetAllAsync(int? top = null, int? skip = null, int? maxpagesize = null, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == "")
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListRequest(Id, top, skip, pageSizeHint, filter, skipToken);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListNextPageRequest(nextLink, Id, top, skip, pageSizeHint, filter, skipToken);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, skip, pageSizeHint, filter, skipToken);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, skip, pageSizeHint, filter, skipToken);
                return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// List Publisher resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_List</description>
        /// </item>
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeMarketplace/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublisherResource> GetAll(int? top = null, int? skip = null, int? maxpagesize = null, string filter = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == "")
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListRequest(Id, top, skip, pageSizeHint, filter, skipToken);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListNextPageRequest(nextLink, Id, top, skip, pageSizeHint, filter, skipToken);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, skip, pageSizeHint, filter, skipToken);
                HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, skip, pageSizeHint, filter, skipToken);
                return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<bool> Exists(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id, publisherName, cancellationToken: cancellationToken);
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
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<NullableResponse<PublisherResource>> GetIfExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceUri}/providers/Microsoft.EdgeMarketplace/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> Name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual NullableResponse<PublisherResource> GetIfExists(string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id, publisherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublisherResource> IEnumerable<PublisherResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublisherResource> IAsyncEnumerable<PublisherResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
