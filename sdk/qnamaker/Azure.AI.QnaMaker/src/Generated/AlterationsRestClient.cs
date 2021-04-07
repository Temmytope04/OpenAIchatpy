// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.QnaMaker.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.QnaMaker
{
    internal partial class AlterationsRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AlterationsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt; qnamaker-resource-name &gt;.api.cognitiveservices.azure.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AlterationsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/alterations", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Download alterations from runtime. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<WordAlterationsDTO>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WordAlterationsDTO value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WordAlterationsDTO.DeserializeWordAlterationsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Download alterations from runtime. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<WordAlterationsDTO> Get(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WordAlterationsDTO value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WordAlterationsDTO.DeserializeWordAlterationsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReplaceRequest(WordAlterationsDTO wordAlterations)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/alterations", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(wordAlterations);
            request.Content = content;
            return message;
        }

        /// <summary> Replace alterations data. </summary>
        /// <param name="wordAlterations"> New alterations data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="wordAlterations"/> is null. </exception>
        public async Task<Response> ReplaceAsync(WordAlterationsDTO wordAlterations, CancellationToken cancellationToken = default)
        {
            if (wordAlterations == null)
            {
                throw new ArgumentNullException(nameof(wordAlterations));
            }

            using var message = CreateReplaceRequest(wordAlterations);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Replace alterations data. </summary>
        /// <param name="wordAlterations"> New alterations data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="wordAlterations"/> is null. </exception>
        public Response Replace(WordAlterationsDTO wordAlterations, CancellationToken cancellationToken = default)
        {
            if (wordAlterations == null)
            {
                throw new ArgumentNullException(nameof(wordAlterations));
            }

            using var message = CreateReplaceRequest(wordAlterations);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAlterationsForKbRequest(string kbId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/alterations/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Download alterations per Knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public async Task<Response<WordAlterationsDTO>> GetAlterationsForKbAsync(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateGetAlterationsForKbRequest(kbId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WordAlterationsDTO value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WordAlterationsDTO.DeserializeWordAlterationsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Download alterations per Knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> is null. </exception>
        public Response<WordAlterationsDTO> GetAlterationsForKb(string kbId, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }

            using var message = CreateGetAlterationsForKbRequest(kbId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WordAlterationsDTO value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WordAlterationsDTO.DeserializeWordAlterationsDTO(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateReplaceAlterationsForKbRequest(string kbId, WordAlterationsDTO wordAlterations)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRaw("/qnamaker/v5.0-preview.2", false);
            uri.AppendPath("/alterations/", false);
            uri.AppendPath(kbId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(wordAlterations);
            request.Content = content;
            return message;
        }

        /// <summary> Replace alterations data per Knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="wordAlterations"> New alterations data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="wordAlterations"/> is null. </exception>
        public async Task<Response> ReplaceAlterationsForKbAsync(string kbId, WordAlterationsDTO wordAlterations, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (wordAlterations == null)
            {
                throw new ArgumentNullException(nameof(wordAlterations));
            }

            using var message = CreateReplaceAlterationsForKbRequest(kbId, wordAlterations);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Replace alterations data per Knowledgebase (QnAMaker Managed). </summary>
        /// <param name="kbId"> Knowledgebase id. </param>
        /// <param name="wordAlterations"> New alterations data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kbId"/> or <paramref name="wordAlterations"/> is null. </exception>
        public Response ReplaceAlterationsForKb(string kbId, WordAlterationsDTO wordAlterations, CancellationToken cancellationToken = default)
        {
            if (kbId == null)
            {
                throw new ArgumentNullException(nameof(kbId));
            }
            if (wordAlterations == null)
            {
                throw new ArgumentNullException(nameof(wordAlterations));
            }

            using var message = CreateReplaceAlterationsForKbRequest(kbId, wordAlterations);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
