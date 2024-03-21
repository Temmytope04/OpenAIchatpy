// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HDInsight.Models;

namespace Azure.ResourceManager.HDInsight
{
    internal partial class ConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-04-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string clusterName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HDInsight/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/configurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all configuration information for an HDI cluster. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<HDInsightClusterConfigurations>> ListAsync(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HDInsightClusterConfigurations value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = HDInsightClusterConfigurations.DeserializeHDInsightClusterConfigurations(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all configuration information for an HDI cluster. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<HDInsightClusterConfigurations> List(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        HDInsightClusterConfigurations value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = HDInsightClusterConfigurations.DeserializeHDInsightClusterConfigurations(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> clusterConfiguration)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HDInsight/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(configurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            foreach (var item in clusterConfiguration)
            {
                content.JsonWriter.WritePropertyName(item.Key);
                content.JsonWriter.WriteStringValue(item.Value);
            }
            content.JsonWriter.WriteEndObject();
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Configures the HTTP settings on the specified cluster. This API is deprecated, please use UpdateGatewaySettings in cluster endpoint instead. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="clusterConfiguration"> The cluster configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="configurationName"/> or <paramref name="clusterConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> clusterConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(clusterConfiguration, nameof(clusterConfiguration));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, clusterName, configurationName, clusterConfiguration);
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

        /// <summary> Configures the HTTP settings on the specified cluster. This API is deprecated, please use UpdateGatewaySettings in cluster endpoint instead. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="clusterConfiguration"> The cluster configurations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="configurationName"/> or <paramref name="clusterConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> clusterConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(clusterConfiguration, nameof(clusterConfiguration));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, clusterName, configurationName, clusterConfiguration);
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

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string clusterName, string configurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HDInsight/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(configurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The configuration object for the specified cluster. This API is not recommended and might be removed in the future. Please consider using List configurations API instead. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyDictionary<string, string>>> GetAsync(string subscriptionId, string resourceGroupName, string clusterName, string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, configurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, string> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetString());
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The configuration object for the specified cluster. This API is not recommended and might be removed in the future. Please consider using List configurations API instead. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="configurationName"> The name of the cluster configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyDictionary<string, string>> Get(string subscriptionId, string resourceGroupName, string clusterName, string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, configurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, string> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, property.Value.GetString());
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
