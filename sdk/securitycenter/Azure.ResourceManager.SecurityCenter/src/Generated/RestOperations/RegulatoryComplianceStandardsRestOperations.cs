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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class RegulatoryComplianceStandardsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RegulatoryComplianceStandardsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RegulatoryComplianceStandardsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-01-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/regulatoryComplianceStandards", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Supported regulatory compliance standards details and state. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RegulatoryComplianceStandardList>> ListAsync(string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }

            using var message = CreateListRequest(subscriptionId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RegulatoryComplianceStandardList.DeserializeRegulatoryComplianceStandardList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Supported regulatory compliance standards details and state. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RegulatoryComplianceStandardList> List(string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }

            using var message = CreateListRequest(subscriptionId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RegulatoryComplianceStandardList.DeserializeRegulatoryComplianceStandardList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string regulatoryComplianceStandardName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/regulatoryComplianceStandards/", false);
            uri.AppendPath(regulatoryComplianceStandardName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Supported regulatory compliance details state for selected standard. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RegulatoryComplianceStandardData>> GetAsync(string subscriptionId, string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (regulatoryComplianceStandardName == null)
            {
                throw new ArgumentNullException(nameof(regulatoryComplianceStandardName));
            }
            if (regulatoryComplianceStandardName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(regulatoryComplianceStandardName));
            }

            using var message = CreateGetRequest(subscriptionId, regulatoryComplianceStandardName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RegulatoryComplianceStandardData.DeserializeRegulatoryComplianceStandardData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RegulatoryComplianceStandardData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Supported regulatory compliance details state for selected standard. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="regulatoryComplianceStandardName"> Name of the regulatory compliance standard object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="regulatoryComplianceStandardName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="regulatoryComplianceStandardName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RegulatoryComplianceStandardData> Get(string subscriptionId, string regulatoryComplianceStandardName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (regulatoryComplianceStandardName == null)
            {
                throw new ArgumentNullException(nameof(regulatoryComplianceStandardName));
            }
            if (regulatoryComplianceStandardName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(regulatoryComplianceStandardName));
            }

            using var message = CreateGetRequest(subscriptionId, regulatoryComplianceStandardName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RegulatoryComplianceStandardData.DeserializeRegulatoryComplianceStandardData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RegulatoryComplianceStandardData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Supported regulatory compliance standards details and state. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RegulatoryComplianceStandardList>> ListNextPageAsync(string nextLink, string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RegulatoryComplianceStandardList.DeserializeRegulatoryComplianceStandardList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Supported regulatory compliance standards details and state. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RegulatoryComplianceStandardList> ListNextPage(string nextLink, string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RegulatoryComplianceStandardList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RegulatoryComplianceStandardList.DeserializeRegulatoryComplianceStandardList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
