// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    /// <summary> The Users service client. </summary>
    public partial class UsersOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal UsersRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of UsersOperations for mocking. </summary>
        protected UsersOperations()
        {
        }
        /// <summary> Initializes a new instance of UsersOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal UsersOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            RestClient = new UsersRestOperations(clientDiagnostics, pipeline, tenantID, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create a new user. </summary>
        /// <param name="parameters"> Parameters to create a user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> CreateAsync(UserCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new user. </summary>
        /// <param name="parameters"> Parameters to create a user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Create(UserCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Create");
            scope.Start();
            try
            {
                return RestClient.Create(parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets user information from the directory. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user for which to get information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> GetAsync(string upnOrObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(upnOrObjectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets user information from the directory. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user for which to get information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Get(string upnOrObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(upnOrObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a user. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user to update. </param>
        /// <param name="parameters"> Parameters to update an existing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateAsync(string upnOrObjectId, UserUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(upnOrObjectId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a user. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user to update. </param>
        /// <param name="parameters"> Parameters to update an existing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Update(string upnOrObjectId, UserUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(upnOrObjectId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a user. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string upnOrObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(upnOrObjectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a user. </summary>
        /// <param name="upnOrObjectId"> The object ID or principal name of the user to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string upnOrObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(upnOrObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets list of users for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<User> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<User>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<User>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets list of users for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<User> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<User> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<User> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a collection that contains the object IDs of the groups of which the user is a member. </summary>
        /// <param name="objectId"> The object ID of the user for which to get group membership. </param>
        /// <param name="parameters"> User filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<string> GetMemberGroupsAsync(string objectId, UserGetMemberGroupsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            async Task<Page<string>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.GetMemberGroups");
                scope.Start();
                try
                {
                    var response = await RestClient.GetMemberGroupsAsync(objectId, parameters, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a collection that contains the object IDs of the groups of which the user is a member. </summary>
        /// <param name="objectId"> The object ID of the user for which to get group membership. </param>
        /// <param name="parameters"> User filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<string> GetMemberGroups(string objectId, UserGetMemberGroupsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Page<string> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.GetMemberGroups");
                scope.Start();
                try
                {
                    var response = RestClient.GetMemberGroups(objectId, parameters, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of users for the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<User> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<User>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<User>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of users for the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<User> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<User> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<User> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersOperations.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
