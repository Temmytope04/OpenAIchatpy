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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VirtualHubIpConfigurationRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VirtualHubIpConfigurationRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public VirtualHubIpConfigurationRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-02-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendPath("/ipConfigurations/", false);
            uri.AppendPath(ipConfigName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the details of a Virtual Hub Ip configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, or <paramref name="ipConfigName"/> is null. </exception>
        public async Task<Response<HubIPConfigurationData>> GetAsync(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HubIPConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HubIPConfigurationData.DeserializeHubIPConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HubIPConfigurationData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a Virtual Hub Ip configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, or <paramref name="ipConfigName"/> is null. </exception>
        public Response<HubIPConfigurationData> Get(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HubIPConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HubIPConfigurationData.DeserializeHubIPConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((HubIPConfigurationData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, HubIPConfigurationData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendPath("/ipConfigurations/", false);
            uri.AppendPath(ipConfigName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, <paramref name="ipConfigName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, HubIPConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="parameters"> Hub Ip Configuration parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, <paramref name="ipConfigName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, HubIPConfigurationData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendPath("/ipConfigurations/", false);
            uri.AppendPath(ipConfigName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes a VirtualHubIpConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubBgpConnection. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, or <paramref name="ipConfigName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName);
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

        /// <summary> Deletes a VirtualHubIpConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubBgpConnection. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="ipConfigName"> The name of the ipconfig. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualHubName"/>, or <paramref name="ipConfigName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string virtualHubName, string ipConfigName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (ipConfigName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualHubName, ipConfigName);
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

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string virtualHubName)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualHubs/", false);
            uri.AppendPath(virtualHubName, true);
            uri.AppendPath("/ipConfigurations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualHubName"/> is null. </exception>
        public async Task<Response<ListVirtualHubIPConfigurationResults>> ListAsync(string subscriptionId, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualHubName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubIPConfigurationResults value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubIPConfigurationResults.DeserializeListVirtualHubIPConfigurationResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualHubName"/> is null. </exception>
        public Response<ListVirtualHubIPConfigurationResults> List(string subscriptionId, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualHubName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubIPConfigurationResults value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubIPConfigurationResults.DeserializeListVirtualHubIPConfigurationResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string virtualHubName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualHubName"/> is null. </exception>
        public async Task<Response<ListVirtualHubIPConfigurationResults>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualHubName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubIPConfigurationResults value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualHubIPConfigurationResults.DeserializeListVirtualHubIPConfigurationResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of all VirtualHubIpConfigurations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="virtualHubName"/> is null. </exception>
        public Response<ListVirtualHubIPConfigurationResults> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualHubName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualHubIPConfigurationResults value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualHubIPConfigurationResults.DeserializeListVirtualHubIPConfigurationResults(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
