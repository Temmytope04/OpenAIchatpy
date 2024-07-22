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
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota
{
    internal partial class GroupQuotaLimitsRequestRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GroupQuotaLimitsRequestRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GroupQuotaLimitsRequestRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (data != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Put the GroupQuota requests for a specific ResourceProvider/Location/Resource. the location and resourceName ("name": {"value" : "resourceName") properties are specified in the request body. Only 1 resource quota can be requested.
        /// Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="data"> The GroupQuotaRequest body details for specific resourceProvider/location/resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateCreateOrUpdateRequest(managementGroupId, groupQuotaName, resourceProviderName, resourceName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Put the GroupQuota requests for a specific ResourceProvider/Location/Resource. the location and resourceName ("name": {"value" : "resourceName") properties are specified in the request body. Only 1 resource quota can be requested.
        /// Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="data"> The GroupQuotaRequest body details for specific resourceProvider/location/resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateCreateOrUpdateRequest(managementGroupId, groupQuotaName, resourceProviderName, resourceName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (data != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Create the GroupQuota requests for a specific ResourceProvider/Location/Resource. the location and resourceName properties are specified in the request body. Only 1 resource quota can be requested. Please note that patch request creates a new groupQuota request.
        /// Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="data"> The GroupQuotaRequest body details for specific resourceProvider/location/resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateUpdateRequest(managementGroupId, groupQuotaName, resourceProviderName, resourceName, data);
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

        /// <summary>
        /// Create the GroupQuota requests for a specific ResourceProvider/Location/Resource. the location and resourceName properties are specified in the request body. Only 1 resource quota can be requested. Please note that patch request creates a new groupQuota request.
        /// Use the polling API - OperationsStatus URI specified in Azure-AsyncOperation header field, with retry-after duration in seconds to check the intermediate status. This API provides the finals status with the request details and status.
        /// </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="resourceName"> Resource name. </param>
        /// <param name="data"> The GroupQuotaRequest body details for specific resourceProvider/location/resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string managementGroupId, string groupQuotaName, string resourceProviderName, string resourceName, GroupQuotaRequestStatusData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateUpdateRequest(managementGroupId, groupQuotaName, resourceProviderName, resourceName, data);
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

        internal RequestUriBuilder CreateGetRequestUri(string managementGroupId, string groupQuotaName, string requestId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(requestId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string managementGroupId, string groupQuotaName, string requestId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/groupQuotaRequests/", false);
            uri.AppendPath(requestId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="requestId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="requestId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="requestId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GroupQuotaRequestStatusData>> GetAsync(string managementGroupId, string groupQuotaName, string requestId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(requestId, nameof(requestId));

            using var message = CreateGetRequest(managementGroupId, groupQuotaName, requestId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaRequestStatusData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GroupQuotaRequestStatusData.DeserializeGroupQuotaRequestStatusData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GroupQuotaRequestStatusData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="requestId"> Request Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="requestId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="requestId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GroupQuotaRequestStatusData> Get(string managementGroupId, string groupQuotaName, string requestId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(requestId, nameof(requestId));

            using var message = CreateGetRequest(managementGroupId, groupQuotaName, requestId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GroupQuotaRequestStatusData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GroupQuotaRequestStatusData.DeserializeGroupQuotaRequestStatusData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((GroupQuotaRequestStatusData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string managementGroupId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("$filter", filter, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string managementGroupId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/managementGroups/", false);
            uri.AppendPath(managementGroupId, true);
            uri.AppendPath("/providers/Microsoft.Quota/groupQuotas/", false);
            uri.AppendPath(groupQuotaName, true);
            uri.AppendPath("/resourceProviders/", false);
            uri.AppendPath(resourceProviderName, true);
            uri.AppendPath("/groupQuotaRequests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("$filter", filter, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location} and resource eq {resourceName}
        ///  Example: $filter=location eq eastus and resourceName eq cores
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SubmittedResourceRequestStatusList>> ListAsync(string managementGroupId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListRequest(managementGroupId, groupQuotaName, resourceProviderName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SubmittedResourceRequestStatusList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SubmittedResourceRequestStatusList.DeserializeSubmittedResourceRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location} and resource eq {resourceName}
        ///  Example: $filter=location eq eastus and resourceName eq cores
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SubmittedResourceRequestStatusList> List(string managementGroupId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListRequest(managementGroupId, groupQuotaName, resourceProviderName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SubmittedResourceRequestStatusList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SubmittedResourceRequestStatusList.DeserializeSubmittedResourceRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, string filter)
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

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location} and resource eq {resourceName}
        ///  Example: $filter=location eq eastus and resourceName eq cores
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SubmittedResourceRequestStatusList>> ListNextPageAsync(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, groupQuotaName, resourceProviderName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SubmittedResourceRequestStatusList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SubmittedResourceRequestStatusList.DeserializeSubmittedResourceRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get API to check the status of a GroupQuota request by requestId. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managementGroupId"> Management Group Id. </param>
        /// <param name="groupQuotaName"> The GroupQuota name. The name should be unique for the provided context tenantId/MgId. </param>
        /// <param name="resourceProviderName"> The resource provider name, such as - Microsoft.Compute. Currently only Microsoft.Compute resource provider supports this API. </param>
        /// <param name="filter">
        /// | Field | Supported operators
        /// |---------------------|------------------------
        ///
        ///  location eq {location} and resource eq {resourceName}
        ///  Example: $filter=location eq eastus and resourceName eq cores
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/>, <paramref name="resourceProviderName"/> or <paramref name="filter"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="managementGroupId"/>, <paramref name="groupQuotaName"/> or <paramref name="resourceProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SubmittedResourceRequestStatusList> ListNextPage(string nextLink, string managementGroupId, string groupQuotaName, string resourceProviderName, string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(managementGroupId, nameof(managementGroupId));
            Argument.AssertNotNullOrEmpty(groupQuotaName, nameof(groupQuotaName));
            Argument.AssertNotNullOrEmpty(resourceProviderName, nameof(resourceProviderName));
            Argument.AssertNotNull(filter, nameof(filter));

            using var message = CreateListNextPageRequest(nextLink, managementGroupId, groupQuotaName, resourceProviderName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SubmittedResourceRequestStatusList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SubmittedResourceRequestStatusList.DeserializeSubmittedResourceRequestStatusList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
