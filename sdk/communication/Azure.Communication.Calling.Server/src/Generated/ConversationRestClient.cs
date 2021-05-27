// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Calling.Server
{
    internal partial class ConversationRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ConversationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConversationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-04-15-preview1")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateJoinCallRequest(string conversationId, JoinCallRequestInternal callRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/Join", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(callRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Join a call. </summary>
        /// <param name="conversationId"> The conversation id which can be guid or encoded cs url. </param>
        /// <param name="callRequest"> The join call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="callRequest"/> is null. </exception>
        public async Task<Response<JoinCallResponse>> JoinCallAsync(string conversationId, JoinCallRequestInternal callRequest, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (callRequest == null)
            {
                throw new ArgumentNullException(nameof(callRequest));
            }

            using var message = CreateJoinCallRequest(conversationId, callRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        JoinCallResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JoinCallResponse.DeserializeJoinCallResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Join a call. </summary>
        /// <param name="conversationId"> The conversation id which can be guid or encoded cs url. </param>
        /// <param name="callRequest"> The join call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="callRequest"/> is null. </exception>
        public Response<JoinCallResponse> JoinCall(string conversationId, JoinCallRequestInternal callRequest, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (callRequest == null)
            {
                throw new ArgumentNullException(nameof(callRequest));
            }

            using var message = CreateJoinCallRequest(conversationId, callRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        JoinCallResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JoinCallResponse.DeserializeJoinCallResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePlayAudioRequest(string conversationId, PlayAudioRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/PlayAudio", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Play audio in a call. </summary>
        /// <param name="conversationId"> The conversation id which can be guid or encoded cs url. </param>
        /// <param name="request"> Play audio request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response<PlayAudioResponse>> PlayAudioAsync(string conversationId, PlayAudioRequest request, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreatePlayAudioRequest(conversationId, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        PlayAudioResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PlayAudioResponse.DeserializePlayAudioResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Play audio in a call. </summary>
        /// <param name="conversationId"> The conversation id which can be guid or encoded cs url. </param>
        /// <param name="request"> Play audio request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="request"/> is null. </exception>
        public Response<PlayAudioResponse> PlayAudio(string conversationId, PlayAudioRequest request, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreatePlayAudioRequest(conversationId, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        PlayAudioResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PlayAudioResponse.DeserializePlayAudioResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateInviteParticipantsRequest(string conversationId, InviteParticipantsRequestInternal inviteParticipantsRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(inviteParticipantsRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Invite participants to the call. </summary>
        /// <param name="conversationId"> Conversation id. </param>
        /// <param name="inviteParticipantsRequest"> Invite participant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="inviteParticipantsRequest"/> is null. </exception>
        public async Task<Response> InviteParticipantsAsync(string conversationId, InviteParticipantsRequestInternal inviteParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (inviteParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(inviteParticipantsRequest));
            }

            using var message = CreateInviteParticipantsRequest(conversationId, inviteParticipantsRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Invite participants to the call. </summary>
        /// <param name="conversationId"> Conversation id. </param>
        /// <param name="inviteParticipantsRequest"> Invite participant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="inviteParticipantsRequest"/> is null. </exception>
        public Response InviteParticipants(string conversationId, InviteParticipantsRequestInternal inviteParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (inviteParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(inviteParticipantsRequest));
            }

            using var message = CreateInviteParticipantsRequest(conversationId, inviteParticipantsRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveParticipantRequest(string conversationId, string participantId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/participants/", false);
            uri.AppendPath(participantId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Remove participant from the call. </summary>
        /// <param name="conversationId"> Conversation id. </param>
        /// <param name="participantId"> Participant id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="participantId"/> is null. </exception>
        public async Task<Response> RemoveParticipantAsync(string conversationId, string participantId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (participantId == null)
            {
                throw new ArgumentNullException(nameof(participantId));
            }

            using var message = CreateRemoveParticipantRequest(conversationId, participantId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Remove participant from the call. </summary>
        /// <param name="conversationId"> Conversation id. </param>
        /// <param name="participantId"> Participant id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="participantId"/> is null. </exception>
        public Response RemoveParticipant(string conversationId, string participantId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (participantId == null)
            {
                throw new ArgumentNullException(nameof(participantId));
            }

            using var message = CreateRemoveParticipantRequest(conversationId, participantId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStartRecordingRequest(string conversationId, StartCallRecordingRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/recordings", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Start call recording request. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="request"> Request body of start call recording request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response<StartCallRecordingResponse>> StartRecordingAsync(string conversationId, StartCallRecordingRequest request, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateStartRecordingRequest(conversationId, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StartCallRecordingResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = StartCallRecordingResponse.DeserializeStartCallRecordingResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Start call recording request. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="request"> Request body of start call recording request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="request"/> is null. </exception>
        public Response<StartCallRecordingResponse> StartRecording(string conversationId, StartCallRecordingRequest request, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateStartRecordingRequest(conversationId, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StartCallRecordingResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = StartCallRecordingResponse.DeserializeStartCallRecordingResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRecordingStateRequest(string conversationId, string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get call recording state. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public async Task<Response<GetCallRecordingStateResponse>> RecordingStateAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateRecordingStateRequest(conversationId, recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetCallRecordingStateResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GetCallRecordingStateResponse.DeserializeGetCallRecordingStateResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get call recording state. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public Response<GetCallRecordingStateResponse> RecordingState(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateRecordingStateRequest(conversationId, recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetCallRecordingStateResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GetCallRecordingStateResponse.DeserializeGetCallRecordingStateResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopRecordingRequest(string conversationId, string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Stop recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> StopRecordingAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateStopRecordingRequest(conversationId, recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stop recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public Response StopRecording(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateStopRecordingRequest(conversationId, recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePauseRecordingRequest(string conversationId, string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendPath("/Pause", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Pause recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> PauseRecordingAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreatePauseRecordingRequest(conversationId, recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Pause recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public Response PauseRecording(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreatePauseRecordingRequest(conversationId, recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResumeRecordingRequest(string conversationId, string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/calling/conversations/", false);
            uri.AppendPath(conversationId, true);
            uri.AppendPath("/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendPath("/Resume", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Resume recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> ResumeRecordingAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateResumeRecordingRequest(conversationId, recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Resume recording a call. </summary>
        /// <param name="conversationId"> Encoded conversation url. </param>
        /// <param name="recordingId"> Recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversationId"/> or <paramref name="recordingId"/> is null. </exception>
        public Response ResumeRecording(string conversationId, string recordingId, CancellationToken cancellationToken = default)
        {
            if (conversationId == null)
            {
                throw new ArgumentNullException(nameof(conversationId));
            }
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateResumeRecordingRequest(conversationId, recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
