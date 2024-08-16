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
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal partial class ProviderActionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProviderActionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProviderActionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-27";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCheckNameAvailabilityRequestUri(AppComplianceReportNameAvailabilityContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/checkNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCheckNameAvailabilityRequest(AppComplianceReportNameAvailabilityContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/checkNameAvailability", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Check if the given name is available for a report. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response<AppComplianceReportNameAvailabilityResult>> CheckNameAvailabilityAsync(AppComplianceReportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppComplianceReportNameAvailabilityResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppComplianceReportNameAvailabilityResult.DeserializeAppComplianceReportNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Check if the given name is available for a report. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response<AppComplianceReportNameAvailabilityResult> CheckNameAvailability(AppComplianceReportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCheckNameAvailabilityRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppComplianceReportNameAvailabilityResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppComplianceReportNameAvailabilityResult.DeserializeAppComplianceReportNameAvailabilityResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetCollectionCountRequestUri(ReportCollectionGetCountContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/getCollectionCount", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetCollectionCountRequest(ReportCollectionGetCountContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/getCollectionCount", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the count of reports. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response<ReportCollectionGetCountResult>> GetCollectionCountAsync(ReportCollectionGetCountContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetCollectionCountRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportCollectionGetCountResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReportCollectionGetCountResult.DeserializeReportCollectionGetCountResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the count of reports. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response<ReportCollectionGetCountResult> GetCollectionCount(ReportCollectionGetCountContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetCollectionCountRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportCollectionGetCountResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReportCollectionGetCountResult.DeserializeReportCollectionGetCountResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetOverviewStatusRequestUri(AppComplianceGetOverviewStatusContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/getOverviewStatus", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetOverviewStatusRequest(AppComplianceGetOverviewStatusContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/getOverviewStatus", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the resource overview status. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response<AppComplianceGetOverviewStatusResult>> GetOverviewStatusAsync(AppComplianceGetOverviewStatusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetOverviewStatusRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppComplianceGetOverviewStatusResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppComplianceGetOverviewStatusResult.DeserializeAppComplianceGetOverviewStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the resource overview status. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response<AppComplianceGetOverviewStatusResult> GetOverviewStatus(AppComplianceGetOverviewStatusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateGetOverviewStatusRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppComplianceGetOverviewStatusResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppComplianceGetOverviewStatusResult.DeserializeAppComplianceGetOverviewStatusResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListInUseStorageAccountsRequestUri(ReportListInUseStorageAccountsContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/listInUseStorageAccounts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListInUseStorageAccountsRequest(ReportListInUseStorageAccountsContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/listInUseStorageAccounts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List the storage accounts which are in use by related reports. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response<ReportListInUseStorageAccountsResult>> ListInUseStorageAccountsAsync(ReportListInUseStorageAccountsContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListInUseStorageAccountsRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportListInUseStorageAccountsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReportListInUseStorageAccountsResult.DeserializeReportListInUseStorageAccountsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List the storage accounts which are in use by related reports. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response<ReportListInUseStorageAccountsResult> ListInUseStorageAccounts(ReportListInUseStorageAccountsContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateListInUseStorageAccountsRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReportListInUseStorageAccountsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReportListInUseStorageAccountsResult.DeserializeReportListInUseStorageAccountsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateOnboardRequestUri(AppComplianceOnboardContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/onboard", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateOnboardRequest(AppComplianceOnboardContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/onboard", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Onboard given subscriptions to Microsoft.AppComplianceAutomation provider. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> OnboardAsync(AppComplianceOnboardContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateOnboardRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Onboard given subscriptions to Microsoft.AppComplianceAutomation provider. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response Onboard(AppComplianceOnboardContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateOnboardRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateTriggerEvaluationRequestUri(TriggerEvaluationContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/triggerEvaluation", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateTriggerEvaluationRequest(TriggerEvaluationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AppComplianceAutomation/triggerEvaluation", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Trigger quick evaluation for the given subscriptions. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> TriggerEvaluationAsync(TriggerEvaluationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateTriggerEvaluationRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Trigger quick evaluation for the given subscriptions. </summary>
        /// <param name="content"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response TriggerEvaluation(TriggerEvaluationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateTriggerEvaluationRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
