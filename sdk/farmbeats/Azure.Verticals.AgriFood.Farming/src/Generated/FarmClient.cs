// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Farm service client. </summary>
    public partial class FarmClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of FarmClient for mocking. </summary>
        protected FarmClient()
        {
        }

        /// <summary> Initializes a new instance of FarmClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public FarmClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
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

        /// <summary> Create a farm operation data ingestion job. </summary>
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
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>authProviderId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Authentication provider ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>operations</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage. </term>
        ///   </item>
        ///   <item>
        ///     <term>startYear</term>
        ///     <term>number</term>
        ///     <term>Yes</term>
        ///     <term> Start Year (Minimum = 2000, Maximum = CurrentYear). </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
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
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateDataIngestionJobAsync(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, requestOptions.CancellationToken).ConfigureAwait(false);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
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

        /// <summary> Create a farm operation data ingestion job. </summary>
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
        ///     <term>farmerId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Farmer ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>authProviderId</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Authentication provider ID. </term>
        ///   </item>
        ///   <item>
        ///     <term>operations</term>
        ///     <term>string[]</term>
        ///     <term></term>
        ///     <term> List of operation types for which data needs to be downloaded. Available values: AllOperations, Application, Planting, Harvest, Tillage. </term>
        ///   </item>
        ///   <item>
        ///     <term>startYear</term>
        ///     <term>number</term>
        ///     <term>Yes</term>
        ///     <term> Start Year (Minimum = 2000, Maximum = CurrentYear). </term>
        ///   </item>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Unique job id. </term>
        ///   </item>
        ///   <item>
        ///     <term>status</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term>
        /// Status of the job.
        /// 
        /// Possible values: &apos;Waiting&apos;, &apos;Running&apos;, &apos;Succeeded&apos;, &apos;Failed&apos;, &apos;Cancelled&apos;.
        /// </term>
        ///   </item>
        ///   <item>
        ///     <term>durationInSeconds</term>
        ///     <term>number</term>
        ///     <term></term>
        ///     <term> Duration of the job in seconds. </term>
        ///   </item>
        ///   <item>
        ///     <term>message</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Status message to capture more details of the job. </term>
        ///   </item>
        ///   <item>
        ///     <term>createdDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job created at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>lastActionDateTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job was last acted upon at dateTime. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>startTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job start time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
        ///   </item>
        ///   <item>
        ///     <term>endTime</term>
        ///     <term>string (ISO 8601 Format)</term>
        ///     <term></term>
        ///     <term> Job end time when available. Sample format: yyyy-MM-ddTHH:mm:ssZ. </term>
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
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateDataIngestionJob(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, requestBody, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                Pipeline.Send(message, requestOptions.CancellationToken);
                if (requestOptions.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
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

        /// <summary> Create Request for <see cref="CreateDataIngestionJob"/> and <see cref="CreateDataIngestionJobAsync"/> operations. </summary>
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="requestBody"> The request body. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateCreateDataIngestionJobRequest(string jobId, RequestContent requestBody, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = requestBody;
            return message;
        }

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetDataIngestionJobDetailsAsync(string jobId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
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

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetDataIngestionJobDetails(string jobId, RequestOptions requestOptions = null)
#pragma warning restore AZC0002
        {
            requestOptions ??= new RequestOptions();
            HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, requestOptions);
            if (requestOptions.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", requestOptions.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
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

        /// <summary> Create Request for <see cref="GetDataIngestionJobDetails"/> and <see cref="GetDataIngestionJobDetailsAsync"/> operations. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="requestOptions"> The request options. </param>
        private HttpMessage CreateGetDataIngestionJobDetailsRequest(string jobId, RequestOptions requestOptions = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
