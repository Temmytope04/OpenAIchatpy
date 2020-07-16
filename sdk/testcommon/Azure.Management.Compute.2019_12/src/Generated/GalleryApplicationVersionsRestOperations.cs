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
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    internal partial class GalleryApplicationVersionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of GalleryApplicationVersionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public GalleryApplicationVersionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion)
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
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(galleryApplicationName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryApplicationVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryApplicationVersion);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be created. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion);
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

        /// <summary> Create or update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be created. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the create or update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersion galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion);
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

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion)
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
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(galleryApplicationName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryApplicationVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryApplicationVersion);
            request.Content = content;
            return message;
        }

        /// <summary> Update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be updated. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> UpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version is to be updated. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryApplicationVersion"> Parameters supplied to the update gallery Application Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Update(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, GalleryApplicationVersionUpdate galleryApplicationVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }
            if (galleryApplicationVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, galleryApplicationVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, ReplicationStatusTypes? expand)
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
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(galleryApplicationName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryApplicationVersionName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Retrieves information about a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplicationVersion>> GetAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplicationVersion.DeserializeGalleryApplicationVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information about a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplicationVersion> Get(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplicationVersion.DeserializeGalleryApplicationVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName)
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
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(galleryApplicationName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryApplicationVersionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
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

        /// <summary> Delete a gallery Application Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition in which the Application Version resides. </param>
        /// <param name="galleryApplicationVersionName"> The name of the gallery Application Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string galleryName, string galleryApplicationName, string galleryApplicationVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }
            if (galleryApplicationVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationVersionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
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

        internal HttpMessage CreateListByGalleryApplicationRequest(string resourceGroupName, string galleryName, string galleryApplicationName)
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
            uri.AppendPath("/providers/Microsoft.Compute/galleries/", false);
            uri.AppendPath(galleryName, true);
            uri.AppendPath("/applications/", false);
            uri.AppendPath(galleryApplicationName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplicationVersionList>> ListByGalleryApplicationAsync(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var message = CreateListByGalleryApplicationRequest(resourceGroupName, galleryName, galleryApplicationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplicationVersionList.DeserializeGalleryApplicationVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplicationVersionList> ListByGalleryApplication(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var message = CreateListByGalleryApplicationRequest(resourceGroupName, galleryName, galleryApplicationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplicationVersionList.DeserializeGalleryApplicationVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGalleryApplicationNextPageRequest(string nextLink, string resourceGroupName, string galleryName, string galleryApplicationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplicationVersionList>> ListByGalleryApplicationNextPageAsync(string nextLink, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var message = CreateListByGalleryApplicationNextPageRequest(nextLink, resourceGroupName, galleryName, galleryApplicationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplicationVersionList.DeserializeGalleryApplicationVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Application Versions in a gallery Application Definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition resides. </param>
        /// <param name="galleryApplicationName"> The name of the Shared Application Gallery Application Definition from which the Application Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplicationVersionList> ListByGalleryApplicationNextPage(string nextLink, string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryApplicationName == null)
            {
                throw new ArgumentNullException(nameof(galleryApplicationName));
            }

            using var message = CreateListByGalleryApplicationNextPageRequest(nextLink, resourceGroupName, galleryName, galleryApplicationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationVersionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplicationVersionList.DeserializeGalleryApplicationVersionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
