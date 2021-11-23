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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    internal partial class AFDCustomDomainsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of AFDCustomDomainsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public AFDCustomDomainsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListByProfileRequest(string resourceGroupName, string profileName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        public async Task<Response<AFDDomainListResult>> ListByProfileAsync(string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }

            using var message = CreateListByProfileRequest(resourceGroupName, profileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AFDDomainListResult.DeserializeAFDDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="profileName"/> is null. </exception>
        public Response<AFDDomainListResult> ListByProfile(string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }

            using var message = CreateListByProfileRequest(resourceGroupName, profileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AFDDomainListResult.DeserializeAFDDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string profileName, string customDomainName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains/", false);
            uri.AppendPath(customDomainName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public async Task<Response<AFDCustomDomainData>> GetAsync(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, customDomainName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDCustomDomainData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AFDCustomDomainData.DeserializeAFDCustomDomainData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AFDCustomDomainData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public Response<AFDCustomDomainData> Get(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, customDomainName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDCustomDomainData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AFDCustomDomainData.DeserializeAFDCustomDomainData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AFDCustomDomainData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceGroupName, string profileName, string customDomainName, AFDCustomDomainData customDomain)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains/", false);
            uri.AppendPath(customDomainName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(customDomain);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a new domain within the specified profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="customDomainName"/>, or <paramref name="customDomain"/> is null. </exception>
        public async Task<Response> CreateAsync(string resourceGroupName, string profileName, string customDomainName, AFDCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomain == null)
            {
                throw new ArgumentNullException(nameof(customDomain));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, customDomainName, customDomain);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new domain within the specified profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomain"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="customDomainName"/>, or <paramref name="customDomain"/> is null. </exception>
        public Response Create(string resourceGroupName, string profileName, string customDomainName, AFDCustomDomainData customDomain, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomain == null)
            {
                throw new ArgumentNullException(nameof(customDomain));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, customDomainName, customDomain);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string profileName, string customDomainName, AFDDomainUpdateParameters customDomainUpdateProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains/", false);
            uri.AppendPath(customDomainName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(customDomainUpdateProperties);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates an existing domain within a profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomainUpdateProperties"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="customDomainName"/>, or <paramref name="customDomainUpdateProperties"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string profileName, string customDomainName, AFDDomainUpdateParameters customDomainUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomainUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(customDomainUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, customDomainName, customDomainUpdateProperties);
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

        /// <summary> Updates an existing domain within a profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="customDomainUpdateProperties"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="customDomainName"/>, or <paramref name="customDomainUpdateProperties"/> is null. </exception>
        public Response Update(string resourceGroupName, string profileName, string customDomainName, AFDDomainUpdateParameters customDomainUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }
            if (customDomainUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(customDomainUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, customDomainName, customDomainUpdateProperties);
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

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string profileName, string customDomainName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains/", false);
            uri.AppendPath(customDomainName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, customDomainName);
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

        /// <summary> Deletes an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, customDomainName);
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

        internal HttpMessage CreateRefreshValidationTokenRequest(string resourceGroupName, string profileName, string customDomainName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/customDomains/", false);
            uri.AppendPath(customDomainName, true);
            uri.AppendPath("/refreshValidationToken", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates the domain validation token. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public async Task<Response> RefreshValidationTokenAsync(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateRefreshValidationTokenRequest(resourceGroupName, profileName, customDomainName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the domain validation token. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="customDomainName"/> is null. </exception>
        public Response RefreshValidationToken(string resourceGroupName, string profileName, string customDomainName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (customDomainName == null)
            {
                throw new ArgumentNullException(nameof(customDomainName));
            }

            using var message = CreateRefreshValidationTokenRequest(resourceGroupName, profileName, customDomainName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByProfileNextPageRequest(string nextLink, string resourceGroupName, string profileName)
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

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="profileName"/> is null. </exception>
        public async Task<Response<AFDDomainListResult>> ListByProfileNextPageAsync(string nextLink, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }

            using var message = CreateListByProfileNextPageRequest(nextLink, resourceGroupName, profileName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDDomainListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AFDDomainListResult.DeserializeAFDDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists existing AzureFrontDoor domains. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="profileName"/> is null. </exception>
        public Response<AFDDomainListResult> ListByProfileNextPage(string nextLink, string resourceGroupName, string profileName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }

            using var message = CreateListByProfileNextPageRequest(nextLink, resourceGroupName, profileName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AFDDomainListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AFDDomainListResult.DeserializeAFDDomainListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
