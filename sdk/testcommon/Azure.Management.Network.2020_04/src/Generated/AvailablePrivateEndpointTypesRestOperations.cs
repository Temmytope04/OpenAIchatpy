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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    internal partial class AvailablePrivateEndpointTypesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AvailablePrivateEndpointTypesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public AvailablePrivateEndpointTypesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/availablePrivateEndpointTypes", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailablePrivateEndpointTypesResult>> ListAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateListRequest(location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailablePrivateEndpointTypesResult> List(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateListRequest(location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string location, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/availablePrivateEndpointTypes", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailablePrivateEndpointTypesResult>> ListByResourceGroupAsync(string location, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(location, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailablePrivateEndpointTypesResult> ListByResourceGroup(string location, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(location, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string location)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailablePrivateEndpointTypesResult>> ListNextPageAsync(string nextLink, string location, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateListNextPageRequest(nextLink, location);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailablePrivateEndpointTypesResult> ListNextPage(string nextLink, string location, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var message = CreateListNextPageRequest(nextLink, location);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string location, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailablePrivateEndpointTypesResult>> ListByResourceGroupNextPageAsync(string nextLink, string location, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, location, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns all of the resource types that can be linked to a Private Endpoint in this subscription in this region. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailablePrivateEndpointTypesResult> ListByResourceGroupNextPage(string nextLink, string location, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, location, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailablePrivateEndpointTypesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailablePrivateEndpointTypesResult.DeserializeAvailablePrivateEndpointTypesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
