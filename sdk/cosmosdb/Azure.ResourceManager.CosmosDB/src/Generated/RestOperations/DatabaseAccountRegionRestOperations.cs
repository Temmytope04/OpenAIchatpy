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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class DatabaseAccountRegionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseAccountRegionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseAccountRegionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-15-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListMetricsRequest(string subscriptionId, string resourceGroupName, string accountName, string region, string filter)
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
            uri.AppendPath("/providers/Microsoft.DocumentDB/databaseAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/region/", false);
            uri.AppendPath(region, true);
            uri.AppendPath("/metrics", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("$filter", filter, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="region"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="region"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="region"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CosmosDBMetricListResult>> ListMetricsAsync(string subscriptionId, string resourceGroupName, string accountName, string region, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(region, nameof(region));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListMetricsRequest(subscriptionId, resourceGroupName, accountName, region, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CosmosDBMetricListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CosmosDBMetricListResult.DeserializeCosmosDBMetricListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and region. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="region"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="region"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="region"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CosmosDBMetricListResult> ListMetrics(string subscriptionId, string resourceGroupName, string accountName, string region, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(region, nameof(region));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListMetricsRequest(subscriptionId, resourceGroupName, accountName, region, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CosmosDBMetricListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CosmosDBMetricListResult.DeserializeCosmosDBMetricListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
