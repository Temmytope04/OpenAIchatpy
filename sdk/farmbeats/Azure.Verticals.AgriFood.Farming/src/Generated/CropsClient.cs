// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Crops service client. </summary>
    public partial class CropsClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of CropsClient for mocking. </summary>
        protected CropsClient()
        {
        }

        /// <summary> Initializes a new instance of CropsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public CropsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListAsync(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.List");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response List(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateListRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.List");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="List"/> and <see cref="ListAsync"/> operations. </summary>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// 
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// 
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateListRequest(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops", false);
            if (phenotypes != null)
            {
                uri.AppendQueryDelimited("phenotypes", phenotypes, ",", true);
            }
            if (ids != null)
            {
                uri.AppendQueryDelimited("ids", ids, ",", true);
            }
            if (names != null)
            {
                uri.AppendQueryDelimited("names", names, ",", true);
            }
            if (propertyFilters != null)
            {
                uri.AppendQueryDelimited("propertyFilters", propertyFilters, ",", true);
            }
            if (statuses != null)
            {
                uri.AppendQueryDelimited("statuses", statuses, ",", true);
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAsync(string cropId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetRequest(cropId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Get");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Get(string cropId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetRequest(cropId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Get");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Get"/> and <see cref="GetAsync"/> operations. </summary>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetRequest(string cropId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>phenotype</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Crop phenotype. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique resource ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>eTag</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The ETag value to implement optimistic concurrency. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>modifiedDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(string cropId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateOrUpdateRequest(cropId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listeader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listeader>
        ///   <item>
        ///     <term>phenotype</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Crop phenotype. </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique resource ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>eTag</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> The ETag value to implement optimistic concurrency. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>modifiedDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Name to identify resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>description</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Textual description of the resource. </term>
        ///   </item>
        ///   <item>
        ///     <term>properties</term>
        ///     <term>Dictionary&lt;string, AnyObject&gt;</term>
        ///     <term></term>
        ///     <term>
        /// A collection of key value pairs that belongs to the resource.
        /// 
        /// Each pair must not have a key greater than 50 characters
        /// 
        /// and must not have a value greater than 150 characters.
        /// 
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(string cropId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateOrUpdateRequest(cropId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateOrUpdate"/> and <see cref="CreateOrUpdateAsync"/> operations. </summary>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateCreateOrUpdateRequest(string cropId, RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string cropId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDeleteRequest(cropId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Delete(string cropId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateDeleteRequest(cropId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 204:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Delete"/> and <see cref="DeleteAsync"/> operations. </summary>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateDeleteRequest(string cropId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
