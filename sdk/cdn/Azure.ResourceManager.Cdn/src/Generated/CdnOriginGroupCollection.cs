// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of CdnOriginGroup and their operations over its parent. </summary>
    public partial class CdnOriginGroupCollection : ArmCollection, IEnumerable<CdnOriginGroup>, IAsyncEnumerable<CdnOriginGroup>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CdnOriginGroupsRestOperations _cdnOriginGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginGroupCollection"/> class for mocking. </summary>
        protected CdnOriginGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of CdnOriginGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CdnOriginGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cdnOriginGroupsRestClient = new CdnOriginGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => CdnEndpoint.ResourceType;

        // Collection level operations.

        /// <summary> Creates a new origin group within the specified endpoint. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="originGroup"/> is null. </exception>
        public virtual CdnOriginGroupCreateOperation CreateOrUpdate(string originGroupName, CdnOriginGroupData originGroup, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, originGroup, cancellationToken);
                var operation = new CdnOriginGroupCreateOperation(Parent, _clientDiagnostics, Pipeline, _cdnOriginGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, originGroup).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new origin group within the specified endpoint. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="originGroup"/> is null. </exception>
        public async virtual Task<CdnOriginGroupCreateOperation> CreateOrUpdateAsync(string originGroupName, CdnOriginGroupData originGroup, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, originGroup, cancellationToken).ConfigureAwait(false);
                var operation = new CdnOriginGroupCreateOperation(Parent, _clientDiagnostics, Pipeline, _cdnOriginGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, originGroup).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin group within an endpoint. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<CdnOriginGroup> Get(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin group within an endpoint. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<CdnOriginGroup>> GetAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnOriginGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<CdnOriginGroup> GetIfExists(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CdnOriginGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new CdnOriginGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<CdnOriginGroup>> GetIfExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CdnOriginGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new CdnOriginGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(originGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            if (originGroupName == null)
            {
                throw new ArgumentNullException(nameof(originGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnOriginGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnOriginGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CdnOriginGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginGroupsRestClient.ListByEndpoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOriginGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnOriginGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnOriginGroupsRestClient.ListByEndpointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOriginGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origin groups within an endpoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnOriginGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnOriginGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnOriginGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginGroupsRestClient.ListByEndpointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOriginGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnOriginGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnOriginGroupsRestClient.ListByEndpointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnOriginGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CdnOriginGroup> IEnumerable<CdnOriginGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnOriginGroup> IAsyncEnumerable<CdnOriginGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, CdnOriginGroup, CdnOriginGroupData> Construct() { }
    }
}
