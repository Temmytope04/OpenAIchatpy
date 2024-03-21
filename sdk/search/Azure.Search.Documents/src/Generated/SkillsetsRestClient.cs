// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Search.Documents.Indexes.Models;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    internal partial class SkillsetsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly Guid? _xMsClientRequestId;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SkillsetsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public SkillsetsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, Guid? xMsClientRequestId = null, string apiVersion = "2024-03-01-Preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _xMsClientRequestId = xMsClientRequestId;
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string skillsetName, SearchIndexerSkillset skillset, string ifMatch, string ifNoneMatch, bool? skipIndexerResetRequirementForCache, bool? disableCacheReprocessingChangeDetection)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipIndexerResetRequirementForCache != null)
            {
                uri.AppendQuery("ignoreResetRequirements", skipIndexerResetRequirementForCache.Value, true);
            }
            if (disableCacheReprocessingChangeDetection != null)
            {
                uri.AppendQuery("disableCacheReprocessingChangeDetection", disableCacheReprocessingChangeDetection.Value, true);
            }
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(skillset);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skipIndexerResetRequirementForCache"> Ignores cache reset requirements. </param>
        /// <param name="disableCacheReprocessingChangeDetection"> Disables cache reprocessing change detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> or <paramref name="skillset"/> is null. </exception>
        public async Task<Response<SearchIndexerSkillset>> CreateOrUpdateAsync(string skillsetName, SearchIndexerSkillset skillset, string ifMatch = null, string ifNoneMatch = null, bool? skipIndexerResetRequirementForCache = null, bool? disableCacheReprocessingChangeDetection = null, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var message = CreateCreateOrUpdateRequest(skillsetName, skillset, ifMatch, ifNoneMatch, skipIndexerResetRequirementForCache, disableCacheReprocessingChangeDetection);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new skillset in a search service or updates the skillset if it already exists. </summary>
        /// <param name="skillsetName"> The name of the skillset to create or update. </param>
        /// <param name="skillset"> The skillset containing one or more skills to create or update in a search service. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="skipIndexerResetRequirementForCache"> Ignores cache reset requirements. </param>
        /// <param name="disableCacheReprocessingChangeDetection"> Disables cache reprocessing change detection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> or <paramref name="skillset"/> is null. </exception>
        public Response<SearchIndexerSkillset> CreateOrUpdate(string skillsetName, SearchIndexerSkillset skillset, string ifMatch = null, string ifNoneMatch = null, bool? skipIndexerResetRequirementForCache = null, bool? disableCacheReprocessingChangeDetection = null, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var message = CreateCreateOrUpdateRequest(skillsetName, skillset, ifMatch, ifNoneMatch, skipIndexerResetRequirementForCache, disableCacheReprocessingChangeDetection);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string skillsetName, string ifMatch, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string skillsetName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var message = CreateDeleteRequest(skillsetName, ifMatch, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> is null. </exception>
        public Response Delete(string skillsetName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var message = CreateDeleteRequest(skillsetName, ifMatch, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string skillsetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> is null. </exception>
        public async Task<Response<SearchIndexerSkillset>> GetAsync(string skillsetName, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var message = CreateGetRequest(skillsetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves a skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> is null. </exception>
        public Response<SearchIndexerSkillset> Get(string skillsetName, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }

            using var message = CreateGetRequest(skillsetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string select)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListSkillsetsResult>> ListAsync(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSkillsetsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListSkillsetsResult.DeserializeListSkillsetsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all skillsets in a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the skillsets to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListSkillsetsResult> List(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListSkillsetsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListSkillsetsResult.DeserializeListSkillsetsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(SearchIndexerSkillset skillset)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(skillset);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillset"/> is null. </exception>
        public async Task<Response<SearchIndexerSkillset>> CreateAsync(SearchIndexerSkillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var message = CreateCreateRequest(skillset);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new skillset in a search service. </summary>
        /// <param name="skillset"> The skillset containing one or more skills to create in a search service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillset"/> is null. </exception>
        public Response<SearchIndexerSkillset> Create(SearchIndexerSkillset skillset, CancellationToken cancellationToken = default)
        {
            if (skillset == null)
            {
                throw new ArgumentNullException(nameof(skillset));
            }

            using var message = CreateCreateRequest(skillset);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndexerSkillset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexerSkillset.DeserializeSearchIndexerSkillset(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResetSkillsRequest(string skillsetName, ResetSkillsOptions skillNames)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/skillsets('", false);
            uri.AppendPath(skillsetName, true);
            uri.AppendPath("')/search.resetskills", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(skillNames);
            request.Content = content;
            return message;
        }

        /// <summary> Reset an existing skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to reset. </param>
        /// <param name="skillNames"> The names of skills to reset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> or <paramref name="skillNames"/> is null. </exception>
        public async Task<Response> ResetSkillsAsync(string skillsetName, ResetSkillsOptions skillNames, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillNames == null)
            {
                throw new ArgumentNullException(nameof(skillNames));
            }

            using var message = CreateResetSkillsRequest(skillsetName, skillNames);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reset an existing skillset in a search service. </summary>
        /// <param name="skillsetName"> The name of the skillset to reset. </param>
        /// <param name="skillNames"> The names of skills to reset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skillsetName"/> or <paramref name="skillNames"/> is null. </exception>
        public Response ResetSkills(string skillsetName, ResetSkillsOptions skillNames, CancellationToken cancellationToken = default)
        {
            if (skillsetName == null)
            {
                throw new ArgumentNullException(nameof(skillsetName));
            }
            if (skillNames == null)
            {
                throw new ArgumentNullException(nameof(skillNames));
            }

            using var message = CreateResetSkillsRequest(skillsetName, skillNames);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
