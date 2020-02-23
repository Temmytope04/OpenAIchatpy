// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Search.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Search
{
    internal partial class DocumentsOperations
    {
        private string endpoint;
        private string indexName;
        private string ApiVersion;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of DocumentsOperations. </summary>
        public DocumentsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string indexName, string ApiVersion = "2019-05-06")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (ApiVersion == null)
            {
                throw new ArgumentNullException(nameof(ApiVersion));
            }

            this.endpoint = endpoint;
            this.indexName = indexName;
            this.ApiVersion = ApiVersion;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateCountRequest(Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/$count", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Queries the number of documents in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<long>> CountAsync(Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Count");
            scope.Start();
            try
            {
                using var message = CreateCountRequest(clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = document.RootElement.GetInt64();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Queries the number of documents in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<long> Count(Guid? clientRequestId, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Count");
            scope.Start();
            try
            {
                using var message = CreateCountRequest(clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = document.RootElement.GetInt64();
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateSearchPostRequest(Guid? clientRequestId, SearchRequest searchRequest)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(searchRequest);
            request.Content = content;
            return message;
        }
        /// <summary> Searches for documents in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="searchRequest"> The definition of the Search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SearchDocumentsResult>> SearchPostAsync(Guid? clientRequestId, SearchRequest searchRequest, CancellationToken cancellationToken = default)
        {
            if (searchRequest == null)
            {
                throw new ArgumentNullException(nameof(searchRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.SearchPost");
            scope.Start();
            try
            {
                using var message = CreateSearchPostRequest(clientRequestId, searchRequest);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SearchDocumentsResult.DeserializeSearchDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Searches for documents in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="searchRequest"> The definition of the Search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SearchDocumentsResult> SearchPost(Guid? clientRequestId, SearchRequest searchRequest, CancellationToken cancellationToken = default)
        {
            if (searchRequest == null)
            {
                throw new ArgumentNullException(nameof(searchRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.SearchPost");
            scope.Start();
            try
            {
                using var message = CreateSearchPostRequest(clientRequestId, searchRequest);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SearchDocumentsResult.DeserializeSearchDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGetRequest(string key, IEnumerable<string> selectedFields, Guid? clientRequestId)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs('", false);
            uri.AppendPath(key, true);
            uri.AppendPath("')", false);
            if (selectedFields != null)
            {
                uri.AppendQueryDelimited("$select", selectedFields, ",", true);
            }
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            return message;
        }
        /// <summary> Retrieves a document from the index. </summary>
        /// <param name="key"> The key of the document to retrieve. </param>
        /// <param name="selectedFields"> List of field names to retrieve for the document; Any field not retrieved will be missing from the returned document. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Components1fm1tvaSchemasFacetresultAdditionalproperties>> GetAsync(string key, IEnumerable<string> selectedFields, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(key, selectedFields, clientRequestId);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = Components1fm1tvaSchemasFacetresultAdditionalproperties.DeserializeComponents1fm1tvaSchemasFacetresultAdditionalproperties(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Retrieves a document from the index. </summary>
        /// <param name="key"> The key of the document to retrieve. </param>
        /// <param name="selectedFields"> List of field names to retrieve for the document; Any field not retrieved will be missing from the returned document. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Components1fm1tvaSchemasFacetresultAdditionalproperties> Get(string key, IEnumerable<string> selectedFields, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(key, selectedFields, clientRequestId);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = Components1fm1tvaSchemasFacetresultAdditionalproperties.DeserializeComponents1fm1tvaSchemasFacetresultAdditionalproperties(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateSuggestPostRequest(Guid? clientRequestId, SuggestRequest suggestRequest)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/suggest", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(suggestRequest);
            request.Content = content;
            return message;
        }
        /// <summary> Suggests documents in the index that match the given partial query text. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="suggestRequest"> The Suggest request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SuggestDocumentsResult>> SuggestPostAsync(Guid? clientRequestId, SuggestRequest suggestRequest, CancellationToken cancellationToken = default)
        {
            if (suggestRequest == null)
            {
                throw new ArgumentNullException(nameof(suggestRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.SuggestPost");
            scope.Start();
            try
            {
                using var message = CreateSuggestPostRequest(clientRequestId, suggestRequest);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SuggestDocumentsResult.DeserializeSuggestDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Suggests documents in the index that match the given partial query text. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="suggestRequest"> The Suggest request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SuggestDocumentsResult> SuggestPost(Guid? clientRequestId, SuggestRequest suggestRequest, CancellationToken cancellationToken = default)
        {
            if (suggestRequest == null)
            {
                throw new ArgumentNullException(nameof(suggestRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.SuggestPost");
            scope.Start();
            try
            {
                using var message = CreateSuggestPostRequest(clientRequestId, suggestRequest);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SuggestDocumentsResult.DeserializeSuggestDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateIndexRequest(Guid? clientRequestId, IndexBatch batch)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/search.index", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(batch);
            request.Content = content;
            return message;
        }
        /// <summary> Sends a batch of document write actions to the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="batch"> The batch of index actions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<IndexDocumentsResult>> IndexAsync(Guid? clientRequestId, IndexBatch batch, CancellationToken cancellationToken = default)
        {
            if (batch == null)
            {
                throw new ArgumentNullException(nameof(batch));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Index");
            scope.Start();
            try
            {
                using var message = CreateIndexRequest(clientRequestId, batch);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = IndexDocumentsResult.DeserializeIndexDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Sends a batch of document write actions to the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="batch"> The batch of index actions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IndexDocumentsResult> Index(Guid? clientRequestId, IndexBatch batch, CancellationToken cancellationToken = default)
        {
            if (batch == null)
            {
                throw new ArgumentNullException(nameof(batch));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.Index");
            scope.Start();
            try
            {
                using var message = CreateIndexRequest(clientRequestId, batch);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = IndexDocumentsResult.DeserializeIndexDocumentsResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateAutocompletePostRequest(Guid? clientRequestId, AutocompleteRequest autocompleteRequest)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRaw("/indexes('", false);
            uri.AppendRaw(indexName, true);
            uri.AppendRaw("')", false);
            uri.AppendPath("/docs/autocomplete", false);
            uri.AppendQuery("api-version", ApiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("client-request-id", clientRequestId.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(autocompleteRequest);
            request.Content = content;
            return message;
        }
        /// <summary> Autocompletes incomplete query terms based on input text and matching terms in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="autocompleteRequest"> The definition of the Autocomplete request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<AutocompleteResult>> AutocompletePostAsync(Guid? clientRequestId, AutocompleteRequest autocompleteRequest, CancellationToken cancellationToken = default)
        {
            if (autocompleteRequest == null)
            {
                throw new ArgumentNullException(nameof(autocompleteRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.AutocompletePost");
            scope.Start();
            try
            {
                using var message = CreateAutocompletePostRequest(clientRequestId, autocompleteRequest);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = AutocompleteResult.DeserializeAutocompleteResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Autocompletes incomplete query terms based on input text and matching terms in the index. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="autocompleteRequest"> The definition of the Autocomplete request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AutocompleteResult> AutocompletePost(Guid? clientRequestId, AutocompleteRequest autocompleteRequest, CancellationToken cancellationToken = default)
        {
            if (autocompleteRequest == null)
            {
                throw new ArgumentNullException(nameof(autocompleteRequest));
            }

            using var scope = clientDiagnostics.CreateScope("DocumentsOperations.AutocompletePost");
            scope.Start();
            try
            {
                using var message = CreateAutocompletePostRequest(clientRequestId, autocompleteRequest);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = AutocompleteResult.DeserializeAutocompleteResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
