// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.GuestConfiguration.Models;

namespace Azure.ResourceManager.GuestConfiguration
{
    internal partial class GuestConfigurationHcrpAssignmentReportsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GuestConfigurationHcrpAssignmentReportsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GuestConfigurationHcrpAssignmentReportsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-01-25";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName)
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
            uri.AppendPath("/providers/Microsoft.HybridCompute/machines/", false);
            uri.AppendPath(machineName, true);
            uri.AppendPath("/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/", false);
            uri.AppendPath(guestConfigurationAssignmentName, true);
            uri.AppendPath("/reports", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all reports for the guest configuration assignment, latest report first. </summary>
        /// <param name="subscriptionId"> Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="machineName"> The name of the ARC machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GuestConfigurationAssignmentReportList>> ListAsync(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, machineName, guestConfigurationAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestConfigurationAssignmentReportList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GuestConfigurationAssignmentReportList.DeserializeGuestConfigurationAssignmentReportList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all reports for the guest configuration assignment, latest report first. </summary>
        /// <param name="subscriptionId"> Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="machineName"> The name of the ARC machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GuestConfigurationAssignmentReportList> List(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, machineName, guestConfigurationAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestConfigurationAssignmentReportList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GuestConfigurationAssignmentReportList.DeserializeGuestConfigurationAssignmentReportList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName, string reportId)
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
            uri.AppendPath("/providers/Microsoft.HybridCompute/machines/", false);
            uri.AppendPath(machineName, true);
            uri.AppendPath("/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/", false);
            uri.AppendPath(guestConfigurationAssignmentName, true);
            uri.AppendPath("/reports/", false);
            uri.AppendPath(reportId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a report for the guest configuration assignment, by reportId. </summary>
        /// <param name="subscriptionId"> Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="machineName"> The name of the ARC machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GuestConfigurationAssignmentReport>> GetAsync(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName, string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, machineName, guestConfigurationAssignmentName, reportId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestConfigurationAssignmentReport value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a report for the guest configuration assignment, by reportId. </summary>
        /// <param name="subscriptionId"> Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="machineName"> The name of the ARC machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="machineName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GuestConfigurationAssignmentReport> Get(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName, string reportId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(machineName, nameof(machineName));
            Argument.AssertNotNullOrEmpty(guestConfigurationAssignmentName, nameof(guestConfigurationAssignmentName));
            Argument.AssertNotNullOrEmpty(reportId, nameof(reportId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, machineName, guestConfigurationAssignmentName, reportId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestConfigurationAssignmentReport value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
