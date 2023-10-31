// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The Metastore service client. </summary>
    public partial class MetastoreClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MetastoreRestClient RestClient { get; }

        /// <summary> Initializes a new instance of MetastoreClient for mocking. </summary>
        protected MetastoreClient()
        {
        }

        /// <summary> Initializes a new instance of MetastoreClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MetastoreClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new MetastoreRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of MetastoreClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal MetastoreClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new MetastoreRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Register files in Syms. </summary>
        /// <param name="id"> The name of the database to be created. The name can contain only alphanumeric characters and should not exceed 24 characters. </param>
        /// <param name="registerBody"> The body for the register request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetastoreRegistrationResponse>> RegisterAsync(string id, MetastoreRegisterObject registerBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Register");
            scope.Start();
            try
            {
                return await RestClient.RegisterAsync(id, registerBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Register files in Syms. </summary>
        /// <param name="id"> The name of the database to be created. The name can contain only alphanumeric characters and should not exceed 24 characters. </param>
        /// <param name="registerBody"> The body for the register request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetastoreRegistrationResponse> Register(string id, MetastoreRegisterObject registerBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Register");
            scope.Start();
            try
            {
                return RestClient.Register(id, registerBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets status of the database. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetastoreRequestSuccessResponse>> GetDatabaseOperationsAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.GetDatabaseOperations");
            scope.Start();
            try
            {
                return await RestClient.GetDatabaseOperationsAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets status of the database. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetastoreRequestSuccessResponse> GetDatabaseOperations(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.GetDatabaseOperations");
            scope.Start();
            try
            {
                return RestClient.GetDatabaseOperations(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update files in Syms. </summary>
        /// <param name="id"> The name of the database to be updated. </param>
        /// <param name="updateBody"> The body for the update request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetastoreUpdationResponse>> UpdateAsync(string id, MetastoreUpdateObject updateBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(id, updateBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update files in Syms. </summary>
        /// <param name="id"> The name of the database to be updated. </param>
        /// <param name="updateBody"> The body for the update request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetastoreUpdationResponse> Update(string id, MetastoreUpdateObject updateBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(id, updateBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove files in Syms. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove files in Syms. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetastoreClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
