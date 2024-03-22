// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class AdaptiveApplicationControlsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AdaptiveApplicationControlsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AdaptiveApplicationControlsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, bool? includePathRecommendations, bool? summary)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applicationWhitelistings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (includePathRecommendations != null)
            {
                uri.AppendQuery("includePathRecommendations", includePathRecommendations.Value, true);
            }
            if (summary != null)
            {
                uri.AppendQuery("summary", summary.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of application control machine groups for the subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="includePathRecommendations"> Include the policy rules. </param>
        /// <param name="summary"> Return output in a summarized form. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveApplicationControlGroups>> ListAsync(string subscriptionId, bool? includePathRecommendations = null, bool? summary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, includePathRecommendations, summary);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroups value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveApplicationControlGroups.DeserializeAdaptiveApplicationControlGroups(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of application control machine groups for the subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="includePathRecommendations"> Include the policy rules. </param>
        /// <param name="summary"> Return output in a summarized form. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveApplicationControlGroups> List(string subscriptionId, bool? includePathRecommendations = null, bool? summary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, includePathRecommendations, summary);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroups value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveApplicationControlGroups.DeserializeAdaptiveApplicationControlGroups(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation ascLocation, string groupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/locations/", false);
            uri.AppendPath(ascLocation, true);
            uri.AppendPath("/applicationWhitelistings/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an application control VM/server group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveApplicationControlGroupData>> GetAsync(string subscriptionId, AzureLocation ascLocation, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, ascLocation, groupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveApplicationControlGroupData.DeserializeAdaptiveApplicationControlGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AdaptiveApplicationControlGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an application control VM/server group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveApplicationControlGroupData> Get(string subscriptionId, AzureLocation ascLocation, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, ascLocation, groupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveApplicationControlGroupData.DeserializeAdaptiveApplicationControlGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AdaptiveApplicationControlGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutRequest(string subscriptionId, AzureLocation ascLocation, string groupName, AdaptiveApplicationControlGroupData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/locations/", false);
            uri.AppendPath(ascLocation, true);
            uri.AppendPath("/applicationWhitelistings/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<AdaptiveApplicationControlGroupData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update an application control machine group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="data"> The <see cref="AdaptiveApplicationControlGroupData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="groupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveApplicationControlGroupData>> PutAsync(string subscriptionId, AzureLocation ascLocation, string groupName, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, ascLocation, groupName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveApplicationControlGroupData.DeserializeAdaptiveApplicationControlGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update an application control machine group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="data"> The <see cref="AdaptiveApplicationControlGroupData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="groupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveApplicationControlGroupData> Put(string subscriptionId, AzureLocation ascLocation, string groupName, AdaptiveApplicationControlGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, ascLocation, groupName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveApplicationControlGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveApplicationControlGroupData.DeserializeAdaptiveApplicationControlGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, AzureLocation ascLocation, string groupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/locations/", false);
            uri.AppendPath(ascLocation, true);
            uri.AppendPath("/applicationWhitelistings/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an application control machine group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, AzureLocation ascLocation, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateDeleteRequest(subscriptionId, ascLocation, groupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete an application control machine group. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        /// <param name="groupName"> Name of an application control machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, AzureLocation ascLocation, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateDeleteRequest(subscriptionId, ascLocation, groupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
