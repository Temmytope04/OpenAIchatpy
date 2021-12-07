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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerAzureADOnlyAuthentication and their operations over its parent. </summary>
    public partial class ServerAzureADOnlyAuthenticationCollection : ArmCollection, IEnumerable<ServerAzureADOnlyAuthentication>, IAsyncEnumerable<ServerAzureADOnlyAuthentication>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerAzureADOnlyAuthenticationsRestOperations _serverAzureADOnlyAuthenticationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerAzureADOnlyAuthenticationCollection"/> class for mocking. </summary>
        protected ServerAzureADOnlyAuthenticationCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerAzureADOnlyAuthenticationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerAzureADOnlyAuthenticationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverAzureADOnlyAuthenticationsRestClient = new ServerAzureADOnlyAuthenticationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlServer.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// <summary> Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ServerAzureADOnlyAuthenticationCreateOrUpdateOperation CreateOrUpdate(AuthenticationName authenticationName, ServerAzureADOnlyAuthenticationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters, cancellationToken);
                var operation = new ServerAzureADOnlyAuthenticationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// <summary> Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="parameters"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerAzureADOnlyAuthenticationCreateOrUpdateOperation> CreateOrUpdateAsync(AuthenticationName authenticationName, ServerAzureADOnlyAuthenticationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerAzureADOnlyAuthenticationCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_Get
        /// <summary> Gets a specific Azure Active Directory only authentication property. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADOnlyAuthentication> Get(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_Get
        /// <summary> Gets a specific Azure Active Directory only authentication property. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerAzureADOnlyAuthentication>> GetAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerAzureADOnlyAuthentication(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAzureADOnlyAuthentication> GetIfExists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerAzureADOnlyAuthentication>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerAzureADOnlyAuthentication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerAzureADOnlyAuthentication>> GetIfExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerAzureADOnlyAuthentication>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerAzureADOnlyAuthentication(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(authenticationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_ListByServer
        /// <summary> Gets a list of server Azure Active Directory only authentications. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerAzureADOnlyAuthentication" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerAzureADOnlyAuthentication> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerAzureADOnlyAuthentication> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADOnlyAuthenticationsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerAzureADOnlyAuthentication> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverAzureADOnlyAuthenticationsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAzureADOnlyAuthentications_ListByServer
        /// <summary> Gets a list of server Azure Active Directory only authentications. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerAzureADOnlyAuthentication" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerAzureADOnlyAuthentication> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerAzureADOnlyAuthentication>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADOnlyAuthenticationsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerAzureADOnlyAuthentication>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverAzureADOnlyAuthenticationsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerAzureADOnlyAuthentication(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerAzureADOnlyAuthentication> IEnumerable<ServerAzureADOnlyAuthentication>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerAzureADOnlyAuthentication> IAsyncEnumerable<ServerAzureADOnlyAuthentication>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerAzureADOnlyAuthentication, ServerAzureADOnlyAuthenticationData> Construct() { }
    }
}
