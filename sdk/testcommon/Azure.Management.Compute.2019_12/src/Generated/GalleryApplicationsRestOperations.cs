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
    internal partial class GalleryApplicationsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of GalleryApplicationsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public GalleryApplicationsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
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

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication)
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
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryApplication);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be created. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication, CancellationToken cancellationToken = default)
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
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplication);
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

        /// <summary> Create or update a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be created. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the create or update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplication galleryApplication, CancellationToken cancellationToken = default)
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
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplication);
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

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication)
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
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(galleryApplication);
            request.Content = content;
            return message;
        }

        /// <summary> Update a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be updated. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> UpdateAsync(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication, CancellationToken cancellationToken = default)
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
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplication);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be updated. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryApplication"> Parameters supplied to the update gallery Application operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Update(string resourceGroupName, string galleryName, string galleryApplicationName, GalleryApplicationUpdate galleryApplication, CancellationToken cancellationToken = default)
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
            if (galleryApplication == null)
            {
                throw new ArgumentNullException(nameof(galleryApplication));
            }

            using var message = CreateUpdateRequest(resourceGroupName, galleryName, galleryApplicationName, galleryApplication);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string galleryName, string galleryApplicationName)
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
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which the Application Definitions are to be retrieved. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplication>> GetAsync(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
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

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryApplicationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplication value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplication.DeserializeGalleryApplication(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information about a gallery Application Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which the Application Definitions are to be retrieved. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplication> Get(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
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

            using var message = CreateGetRequest(resourceGroupName, galleryName, galleryApplicationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplication value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplication.DeserializeGalleryApplication(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string galleryName, string galleryApplicationName)
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
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete a gallery Application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be deleted. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
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

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName);
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

        /// <summary> Delete a gallery Application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery in which the Application Definition is to be deleted. </param>
        /// <param name="galleryApplicationName"> The name of the gallery Application Definition to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string galleryName, string galleryApplicationName, CancellationToken cancellationToken = default)
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

            using var message = CreateDeleteRequest(resourceGroupName, galleryName, galleryApplicationName);
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

        internal HttpMessage CreateListByGalleryRequest(string resourceGroupName, string galleryName)
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
            uri.AppendPath("/applications", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which Application Definitions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplicationList>> ListByGalleryAsync(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var message = CreateListByGalleryRequest(resourceGroupName, galleryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplicationList.DeserializeGalleryApplicationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which Application Definitions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplicationList> ListByGallery(string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }

            using var message = CreateListByGalleryRequest(resourceGroupName, galleryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplicationList.DeserializeGalleryApplicationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByGalleryNextPageRequest(string nextLink, string resourceGroupName, string galleryName)
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

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which Application Definitions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GalleryApplicationList>> ListByGalleryNextPageAsync(string nextLink, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
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

            using var message = CreateListByGalleryNextPageRequest(nextLink, resourceGroupName, galleryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GalleryApplicationList.DeserializeGalleryApplicationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List gallery Application Definitions in a gallery. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Application Gallery from which Application Definitions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GalleryApplicationList> ListByGalleryNextPage(string nextLink, string resourceGroupName, string galleryName, CancellationToken cancellationToken = default)
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

            using var message = CreateListByGalleryNextPageRequest(nextLink, resourceGroupName, galleryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GalleryApplicationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GalleryApplicationList.DeserializeGalleryApplicationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
