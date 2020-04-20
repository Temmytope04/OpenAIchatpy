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
using Azure.Template.Models;

namespace Azure.Template
{
    internal partial class ServiceRestClient
    {
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateOperationRequest(ServiceModel body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/Operation/", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (body != null)
            {
                using var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The ServiceModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ServiceModel>> OperationAsync(ServiceModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation");
            scope.Start();
            try
            {
                using var message = CreateOperationRequest(body);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ServiceModel value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = ServiceModel.DeserializeServiceModel(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="body"> The ServiceModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ServiceModel> Operation(ServiceModel body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Operation");
            scope.Start();
            try
            {
                using var message = CreateOperationRequest(body);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ServiceModel value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = ServiceModel.DeserializeServiceModel(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
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
