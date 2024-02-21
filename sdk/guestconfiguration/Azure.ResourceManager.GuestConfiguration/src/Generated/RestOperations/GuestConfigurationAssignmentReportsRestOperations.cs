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
using Azure.ResourceManager.GuestConfiguration.Models;

namespace Azure.ResourceManager.GuestConfiguration
{
    internal partial class GuestConfigurationAssignmentReportsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GuestConfigurationAssignmentReportsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GuestConfigurationAssignmentReportsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-01-25";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName)
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
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachines/", false);
            uri.AppendPath(vmName, true);
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
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GuestConfigurationAssignmentReportList>> ListAsync(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vmName));
            }
            if (guestConfigurationAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(guestConfigurationAssignmentName));
            }
            if (guestConfigurationAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(guestConfigurationAssignmentName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
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
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/> or <paramref name="guestConfigurationAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GuestConfigurationAssignmentReportList> List(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vmName));
            }
            if (guestConfigurationAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(guestConfigurationAssignmentName));
            }
            if (guestConfigurationAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(guestConfigurationAssignmentName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName);
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

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName, string reportId)
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
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachines/", false);
            uri.AppendPath(vmName, true);
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
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GuestConfigurationAssignmentReport>> GetAsync(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName, string reportId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vmName));
            }
            if (guestConfigurationAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(guestConfigurationAssignmentName));
            }
            if (guestConfigurationAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(guestConfigurationAssignmentName));
            }
            if (reportId == null)
            {
                throw new ArgumentNullException(nameof(reportId));
            }
            if (reportId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(reportId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName, reportId);
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
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="guestConfigurationAssignmentName"> The guest configuration assignment name. </param>
        /// <param name="reportId"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, <paramref name="guestConfigurationAssignmentName"/> or <paramref name="reportId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GuestConfigurationAssignmentReport> Get(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName, string reportId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (vmName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vmName));
            }
            if (guestConfigurationAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(guestConfigurationAssignmentName));
            }
            if (guestConfigurationAssignmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(guestConfigurationAssignmentName));
            }
            if (reportId == null)
            {
                throw new ArgumentNullException(nameof(reportId));
            }
            if (reportId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(reportId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vmName, guestConfigurationAssignmentName, reportId);
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
