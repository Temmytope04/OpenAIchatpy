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
    internal partial class SparkConfigurationRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SparkConfigurationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        public SparkConfigurationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
        }

        internal HttpMessage CreateGetSparkConfigurationsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkconfigurations", false);
            uri.AppendQuery("api-version", "2021-06-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkConfigurationListResponse>> GetSparkConfigurationsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkConfigurationsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkConfigurationListResponse.DeserializeSparkConfigurationListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkConfigurationListResponse> GetSparkConfigurationsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkConfigurationsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkConfigurationListResponse.DeserializeSparkConfigurationListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateSparkConfigurationRequest(string sparkConfigurationName, SparkConfigurationResource sparkConfiguration, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkconfigurations/", false);
            uri.AppendPath(sparkConfigurationName, true);
            uri.AppendQuery("api-version", "2021-06-01-preview", true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sparkConfiguration);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a sparkconfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="sparkConfiguration"> SparkConfiguration resource definition. </param>
        /// <param name="ifMatch"> ETag of the sparkConfiguration entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="sparkConfiguration"/> is null. </exception>
        public async Task<Response> CreateOrUpdateSparkConfigurationAsync(string sparkConfigurationName, SparkConfigurationResource sparkConfiguration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (sparkConfiguration == null)
            {
                throw new ArgumentNullException(nameof(sparkConfiguration));
            }

            using var message = CreateCreateOrUpdateSparkConfigurationRequest(sparkConfigurationName, sparkConfiguration, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a sparkconfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="sparkConfiguration"> SparkConfiguration resource definition. </param>
        /// <param name="ifMatch"> ETag of the sparkConfiguration entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="sparkConfiguration"/> is null. </exception>
        public Response CreateOrUpdateSparkConfiguration(string sparkConfigurationName, SparkConfigurationResource sparkConfiguration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (sparkConfiguration == null)
            {
                throw new ArgumentNullException(nameof(sparkConfiguration));
            }

            using var message = CreateCreateOrUpdateSparkConfigurationRequest(sparkConfigurationName, sparkConfiguration, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSparkConfigurationRequest(string sparkConfigurationName, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkconfigurations/", false);
            uri.AppendPath(sparkConfigurationName, true);
            uri.AppendQuery("api-version", "2021-06-01-preview", true);
            request.Uri = uri;
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="ifNoneMatch"> ETag of the sparkConfiguration entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public async Task<Response<SparkConfigurationResource>> GetSparkConfigurationAsync(string sparkConfigurationName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var message = CreateGetSparkConfigurationRequest(sparkConfigurationName, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkConfigurationResource.DeserializeSparkConfigurationResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((SparkConfigurationResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="ifNoneMatch"> ETag of the sparkConfiguration entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public Response<SparkConfigurationResource> GetSparkConfiguration(string sparkConfigurationName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var message = CreateGetSparkConfigurationRequest(sparkConfigurationName, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkConfigurationResource.DeserializeSparkConfigurationResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 304:
                    return Response.FromValue((SparkConfigurationResource)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteSparkConfigurationRequest(string sparkConfigurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkconfigurations/", false);
            uri.AppendPath(sparkConfigurationName, true);
            uri.AppendQuery("api-version", "2021-06-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public async Task<Response> DeleteSparkConfigurationAsync(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var message = CreateDeleteSparkConfigurationRequest(sparkConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public Response DeleteSparkConfiguration(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }

            using var message = CreateDeleteSparkConfigurationRequest(sparkConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRenameSparkConfigurationRequest(string sparkConfigurationName, ArtifactRenameRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/sparkconfigurations/", false);
            uri.AppendPath(sparkConfigurationName, true);
            uri.AppendPath("/rename", false);
            uri.AppendQuery("api-version", "2021-06-01-preview", true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Renames a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response> RenameSparkConfigurationAsync(string sparkConfigurationName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSparkConfigurationRequest(sparkConfigurationName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Renames a sparkConfiguration. </summary>
        /// <param name="sparkConfigurationName"> The spark Configuration name. </param>
        /// <param name="request"> proposed new name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> or <paramref name="request"/> is null. </exception>
        public Response RenameSparkConfiguration(string sparkConfigurationName, ArtifactRenameRequest request, CancellationToken cancellationToken = default)
        {
            if (sparkConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(sparkConfigurationName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateRenameSparkConfigurationRequest(sparkConfigurationName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSparkConfigurationsByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SparkConfigurationListResponse>> GetSparkConfigurationsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSparkConfigurationsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkConfigurationListResponse.DeserializeSparkConfigurationListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists sparkconfigurations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SparkConfigurationListResponse> GetSparkConfigurationsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetSparkConfigurationsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkConfigurationListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkConfigurationListResponse.DeserializeSparkConfigurationListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
