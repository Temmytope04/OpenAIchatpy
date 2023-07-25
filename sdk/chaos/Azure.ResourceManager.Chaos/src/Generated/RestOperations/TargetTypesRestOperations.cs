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
using Azure.ResourceManager.Chaos.Models;

namespace Azure.ResourceManager.Chaos
{
    internal partial class TargetTypesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TargetTypesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TargetTypesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string locationName, string continuationToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Chaos/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/targetTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a list of Target Type resources for given location. </summary>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TargetTypeListResult>> ListAsync(string subscriptionId, string locationName, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var message = CreateListRequest(subscriptionId, locationName, continuationToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TargetTypeListResult.DeserializeTargetTypeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of Target Type resources for given location. </summary>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TargetTypeListResult> List(string subscriptionId, string locationName, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var message = CreateListRequest(subscriptionId, locationName, continuationToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TargetTypeListResult.DeserializeTargetTypeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string locationName, string targetTypeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Chaos/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/targetTypes/", false);
            uri.AppendPath(targetTypeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Target Type resources for given location. </summary>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TargetTypeData>> GetAsync(string subscriptionId, string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var message = CreateGetRequest(subscriptionId, locationName, targetTypeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TargetTypeData.DeserializeTargetTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TargetTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Target Type resources for given location. </summary>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TargetTypeData> Get(string subscriptionId, string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var message = CreateGetRequest(subscriptionId, locationName, targetTypeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TargetTypeData.DeserializeTargetTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TargetTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string locationName, string continuationToken)
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

        /// <summary> Get a list of Target Type resources for given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TargetTypeListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string locationName, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, locationName, continuationToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TargetTypeListResult.DeserializeTargetTypeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of Target Type resources for given location. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> GUID that represents an Azure subscription ID. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TargetTypeListResult> ListNextPage(string nextLink, string subscriptionId, string locationName, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, locationName, continuationToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetTypeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TargetTypeListResult.DeserializeTargetTypeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
