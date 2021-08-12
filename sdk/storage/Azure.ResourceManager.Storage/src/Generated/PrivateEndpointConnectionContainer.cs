// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of PrivateEndpointConnection and their operations over a StorageAccount. </summary>
    public partial class PrivateEndpointConnectionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionContainer"/> class for mocking. </summary>
        protected PrivateEndpointConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateEndpointConnectionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PrivateEndpointConnectionsRestOperations _restClient => new PrivateEndpointConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<PrivateEndpointConnection> CreateOrUpdate(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(privateEndpointConnectionName, properties, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<Response<PrivateEndpointConnection>> CreateOrUpdateAsync(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual PrivateEndpointConnectionPutOperation StartCreateOrUpdate(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken);
                return new PrivateEndpointConnectionPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update the state of specified private endpoint connection associated with the storage account. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<PrivateEndpointConnectionPutOperation> StartCreateOrUpdateAsync(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
                return new PrivateEndpointConnectionPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all the private endpoint connections associated with the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> List all the private endpoint connections associated with the storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="PrivateEndpointConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PrivateEndpointConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, PrivateEndpointConnection, PrivateEndpointConnectionData> Construct() { }
    }
}
