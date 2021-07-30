// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class DataFlowRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DataFlowRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataFlowRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2019-06-01-preview")
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateDataFlowRequest(string dataFlowName, DataFlowResource dataFlow, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataFlowName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(dataFlow);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="dataFlow"/> is null. </exception>
        public async Task<Response> CreateOrUpdateDataFlowAsync(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            using var message = CreateCreateOrUpdateDataFlowRequest(dataFlowName, dataFlow, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="dataFlow"> Data flow resource definition. </param>
        /// <param name="ifMatch"> ETag of the data flow entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="dataFlow"/> is null. </exception>
        public Response CreateOrUpdateDataFlow(string dataFlowName, DataFlowResource dataFlow, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            using var message = CreateCreateOrUpdateDataFlowRequest(dataFlowName, dataFlow, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDataFlowRequest(string dataFlowName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataFlowName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public async Task<Response<DataFlowResource>> GetDataFlowAsync(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var message = CreateGetDataFlowRequest(dataFlowName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFlowResource.DeserializeDataFlowResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="ifNoneMatch"> ETag of the data flow entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public Response<DataFlowResource> GetDataFlow(string dataFlowName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var message = CreateGetDataFlowRequest(dataFlowName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFlowResource.DeserializeDataFlowResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteDataFlowRequest(string dataFlowName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataFlowName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public async Task<Response> DeleteDataFlowAsync(string dataFlowName, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var message = CreateDeleteDataFlowRequest(dataFlowName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a data flow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> is null. </exception>
        public Response DeleteDataFlow(string dataFlowName, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }

            using var message = CreateDeleteDataFlowRequest(dataFlowName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameDataFlowRequest(string dataFlowName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/dataflows/", false);
            uri.AppendPath(dataFlowName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a dataflow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameDataFlowAsync(string dataFlowName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameDataFlowRequest(dataFlowName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Renames a dataflow. </summary>
        /// <param name="dataFlowName"> The data flow name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlowName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameDataFlow(string dataFlowName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (dataFlowName == null)
            {
                throw new ArgumentNullException(nameof(dataFlowName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameDataFlowRequest(dataFlowName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDataFlowsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/dataflows", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DataFlowListResponse>> GetDataFlowsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDataFlowsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFlowListResponse.DeserializeDataFlowListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DataFlowListResponse> GetDataFlowsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetDataFlowsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFlowListResponse.DeserializeDataFlowListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDataFlowsByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DataFlowListResponse>> GetDataFlowsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetDataFlowsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataFlowListResponse.DeserializeDataFlowListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists data flows. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DataFlowListResponse> GetDataFlowsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetDataFlowsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataFlowListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataFlowListResponse.DeserializeDataFlowListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
