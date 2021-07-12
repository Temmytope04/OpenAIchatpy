﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.Translation.Document.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Translation.Document
{
    /// <summary>
    /// The client to use for interacting with the Azure Document Translation Service.
    /// </summary>
    public class DocumentTranslationClient
    {
        internal readonly DocumentTranslationRestClient _serviceRestClient;
        internal readonly ClientDiagnostics _clientDiagnostics;
        internal readonly DocumentTranslationClientOptions _options;

        /// <summary>
        /// Protected constructor to allow mocking.
        /// </summary>
        protected DocumentTranslationClient()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTranslationClient"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to
        /// authenticate requests to the service, such as DefaultAzureCredential.</param>
        public DocumentTranslationClient(Uri endpoint, TokenCredential credential)
            : this(endpoint, credential, new DocumentTranslationClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTranslationClient"/>
        /// class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.  Endpoint can be found in the Azure portal.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to
        /// authenticate requests to the service, such as DefaultAzureCredential.</param>
        /// <param name="options"><see cref="DocumentTranslationClientOptions"/> that allow
        /// callers to configure how requests are sent to the service.</param>
        public DocumentTranslationClient(Uri endpoint, TokenCredential credential, DocumentTranslationClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _options = options;
            _clientDiagnostics = new ClientDiagnostics(options);

            HttpPipeline pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, Constants.DefaultCognitiveScope));
            _serviceRestClient = new DocumentTranslationRestClient(_clientDiagnostics, pipeline, endpoint.AbsoluteUri);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DocumentTranslationClient"/> class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.</param>
        /// <param name="credential">The API key used to access
        /// the service. This will allow you to update the API key
        /// without creating a new client.</param>
        /// <param name="options"><see cref="DocumentTranslationClientOptions"/> that allow
        /// callers to configure how requests are sent to the service.</param>
        public DocumentTranslationClient(Uri endpoint, AzureKeyCredential credential, DocumentTranslationClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _options = options;
            _clientDiagnostics = new ClientDiagnostics(options);

            HttpPipeline pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, Constants.AuthorizationHeader));
            _serviceRestClient = new DocumentTranslationRestClient(_clientDiagnostics, pipeline, endpoint.AbsoluteUri);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DocumentTranslationClient"/> class for the specified service instance.
        /// </summary>
        /// <param name="endpoint">A <see cref="Uri"/> to the service the client
        /// sends requests to.</param>
        /// <param name="credential">The API key used to access
        /// the service. This will allow you to update the API key
        /// without creating a new client.</param>
        public DocumentTranslationClient(Uri endpoint, AzureKeyCredential credential)
            : this(endpoint, credential, new DocumentTranslationClientOptions())
        {
        }

        /// <summary>
        /// Starts a translation operation which translates the document(s) in your source container
        /// to your <see cref="TranslationTarget"/>(s) in the given language.
        /// <para>For document length limits, maximum batch size, and supported document formats, see
        /// <a href="https://docs.microsoft.com/azure/cognitive-services/translator/document-translation/overview"/>.</para>
        /// </summary>
        /// <param name="inputs">Sets the inputs for the translation operation
        /// including source and target containers for documents to be translated. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success status code. </exception>
        public virtual DocumentTranslationOperation StartTranslation(IEnumerable<DocumentTranslationInput> inputs, CancellationToken cancellationToken = default)
        {
            var request = new StartTranslationDetails(inputs);
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(StartTranslation)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<DocumentTranslationStartTranslationHeaders> job = _serviceRestClient.StartTranslation(request, cancellationToken);
                return new DocumentTranslationOperation(_serviceRestClient, _clientDiagnostics, job.Headers.OperationLocation);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts a translation operation which translates the document(s) in your source container
        /// to your <see cref="TranslationTarget"/>(s) in the given language.
        /// <para>For document length limits, maximum batch size, and supported document formats, see
        /// <a href="https://docs.microsoft.com/azure/cognitive-services/translator/document-translation/overview"/>.</para>
        /// </summary>
        /// <param name="inputs">Sets the inputs for the translation operation
        /// including source and target containers for documents to be translated. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success status code. </exception>
        public virtual async Task<DocumentTranslationOperation> StartTranslationAsync(IEnumerable<DocumentTranslationInput> inputs, CancellationToken cancellationToken = default)
        {
            var request = new StartTranslationDetails(inputs);
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(StartTranslation)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<DocumentTranslationStartTranslationHeaders> job = await _serviceRestClient.StartTranslationAsync(request, cancellationToken).ConfigureAwait(false);
                return new DocumentTranslationOperation(_serviceRestClient, _clientDiagnostics, job.Headers.OperationLocation);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts a translation operation which translates the document(s) in your source container
        /// to your <see cref="TranslationTarget"/>(s) in the given language.
        /// <para>For document length limits, maximum batch size, and supported document formats, see
        /// <a href="https://docs.microsoft.com/azure/cognitive-services/translator/document-translation/overview"/>.</para>
        /// </summary>
        /// <param name="input">Sets the input for the translation operation
        /// including source and target containers for documents to be translated. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success status code. </exception>
        public virtual DocumentTranslationOperation StartTranslation(DocumentTranslationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));
            var request = new StartTranslationDetails(new List<DocumentTranslationInput> { input });
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(StartTranslation)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<DocumentTranslationStartTranslationHeaders> job = _serviceRestClient.StartTranslation(request, cancellationToken);
                return new DocumentTranslationOperation(_serviceRestClient, _clientDiagnostics, job.Headers.OperationLocation);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Starts a translation operation which translates the document(s) in your source container
        /// to your <see cref="TranslationTarget"/>(s) in the given language.
        /// <para>For document length limits, maximum batch size, and supported document formats, see
        /// <a href="https://docs.microsoft.com/azure/cognitive-services/translator/document-translation/overview"/>.</para>
        /// </summary>
        /// <param name="input">Sets the input for the translation operation
        /// including source and target containers for documents to be translated. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">Service returned a non-success status code. </exception>
        public virtual async Task<DocumentTranslationOperation> StartTranslationAsync(DocumentTranslationInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));
            var request = new StartTranslationDetails(new List<DocumentTranslationInput> { input });
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(StartTranslation)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<DocumentTranslationStartTranslationHeaders> job = await _serviceRestClient.StartTranslationAsync(request, cancellationToken).ConfigureAwait(false);
                return new DocumentTranslationOperation(_serviceRestClient, _clientDiagnostics, job.Headers.OperationLocation);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status results for all submitted translation operations.
        /// </summary>
        /// <param name="top">Indicates the total number of records the user wants to be returned across all pages.</param>
        /// <param name="skip">Indicates the number of records to skip from the list of records held by the server based on the sorting method specified.  By default, we sort by descending start time.</param>
        /// <param name="itemsPerPage">Is the maximum items returned in a page.</param>
        /// <param name="ids">List of translation operation IDs to filter by.</param>
        /// <param name="statuses">List of translation statuses to filter by.</param>
        /// <param name="createdDateTimeUtcStart">Filter by operations created after a certain datetime.</param>
        /// <param name="createdDateTimeUtcEnd">Filter by operations created before a certain datetime.</param>
        /// <param name="orderBy">The sorting query for the operations returned. Format: ["parm1 asc/desc", "parm2 asc/desc", ...]. Ex: 'createdDateTimeUtc asc', 'createdDateTimeUtc desc').</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns></returns>
        public virtual Pageable<TranslationStatus> GetAllTranslationStatuses(
            int? top = null,
            int? skip = null,
            int? itemsPerPage = null,
            IEnumerable<Guid> ids = null,
            IEnumerable<string> statuses = null,
            DateTimeOffset? createdDateTimeUtcStart = null,
            DateTimeOffset? createdDateTimeUtcEnd = null,
            IEnumerable<string> orderBy = null,
            CancellationToken cancellationToken = default)
        {
            Page<TranslationStatus> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetAllTranslationStatuses)}");
                scope.Start();

                try
                {
                    ResponseWithHeaders<TranslationsStatus, DocumentTranslationGetTranslationsStatusHeaders> response = _serviceRestClient.GetTranslationsStatus(
                        top: top,
                        skip: skip,
                        maxpagesize: itemsPerPage,
                        ids: ids,
                        statuses: statuses,
                        createdDateTimeUtcStart: createdDateTimeUtcStart,
                        createdDateTimeUtcEnd: createdDateTimeUtcEnd,
                        orderBy: orderBy,
                        cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            Page<TranslationStatus> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetAllTranslationStatuses)}");
                scope.Start();

                try
                {
                    ResponseWithHeaders<TranslationsStatus, DocumentTranslationGetTranslationsStatusHeaders> response = _serviceRestClient.GetTranslationsStatusNextPage(
                        nextLink,
                        top: top,
                        skip: skip,
                        maxpagesize: itemsPerPage,
                        ids: ids,
                        statuses: statuses,
                        createdDateTimeUtcStart: createdDateTimeUtcStart,
                        createdDateTimeUtcEnd: createdDateTimeUtcEnd,
                        orderBy: orderBy,
                        cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get the status results for all submitted translation operations.
        /// </summary>
        /// <param name="top">Indicates the total number of records the user wants to be returned across all pages.</param>
        /// <param name="skip">Indicates the number of records to skip from the list of records held by the server based on the sorting method specified.  By default, we sort by descending start time.</param>
        /// <param name="itemsPerPage">Is the maximum items returned in a page.</param>
        /// <param name="ids">List of translation operation IDs to filter by.</param>
        /// <param name="statuses">List of translation statuses to filter by.</param>
        /// <param name="createdDateTimeUtcStart">Filter by operations created after a certain datetime.</param>
        /// <param name="createdDateTimeUtcEnd">Filter by operations created before a certain datetime.</param>
        /// <param name="orderBy">The sorting query for the operations returned. Format: ["parm1 asc/desc", "parm2 asc/desc", ...]. Ex: 'createdDateTimeUtc asc', 'createdDateTimeUtc desc').</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns></returns>
        public virtual AsyncPageable<TranslationStatus> GetAllTranslationStatusesAsync(
            int? top = null,
            int? skip = null,
            int? itemsPerPage = null,
            IEnumerable<Guid> ids = null,
            IEnumerable<string> statuses = null,
            DateTimeOffset? createdDateTimeUtcStart = null,
            DateTimeOffset? createdDateTimeUtcEnd = null,
            IEnumerable<string> orderBy = null,
            CancellationToken cancellationToken = default)
        {
            async Task<Page<TranslationStatus>> FirstPageFunc(int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetAllTranslationStatuses)}");
                scope.Start();

                try
                {
                    ResponseWithHeaders<TranslationsStatus, DocumentTranslationGetTranslationsStatusHeaders> response = await _serviceRestClient.GetTranslationsStatusAsync(
                        top: top,
                        skip: skip,
                        maxpagesize: itemsPerPage,
                        ids: ids,
                        statuses: statuses,
                        createdDateTimeUtcStart: createdDateTimeUtcStart,
                        createdDateTimeUtcEnd: createdDateTimeUtcEnd,
                        orderBy: orderBy,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            async Task<Page<TranslationStatus>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetAllTranslationStatuses)}");
                scope.Start();

                try
                {
                    ResponseWithHeaders<TranslationsStatus, DocumentTranslationGetTranslationsStatusHeaders> response = await _serviceRestClient.GetTranslationsStatusNextPageAsync(
                        nextLink,
                        top: top,
                        skip: skip,
                        maxpagesize: itemsPerPage,
                        ids: ids,
                        statuses: statuses,
                        createdDateTimeUtcStart: createdDateTimeUtcStart,
                        createdDateTimeUtcEnd: createdDateTimeUtcEnd,
                        orderBy: orderBy,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        #region supported formats functions

        /// <summary>
        /// Get the list of the glossary formats supported by the Document Translation service.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual Response<IReadOnlyList<FileFormat>> GetSupportedGlossaryFormats(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetSupportedGlossaryFormats)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<SupportedFileFormats, DocumentTranslationGetSupportedGlossaryFormatsHeaders> response = _serviceRestClient.GetSupportedGlossaryFormats(cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of the glossary formats supported by the Document Translation service.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual async Task<Response<IReadOnlyList<FileFormat>>> GetSupportedGlossaryFormatsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetSupportedGlossaryFormats)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<SupportedFileFormats, DocumentTranslationGetSupportedGlossaryFormatsHeaders> response = await _serviceRestClient.GetSupportedGlossaryFormatsAsync(cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of the document formats supported by the Document Translation service.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual Response<IReadOnlyList<FileFormat>> GetSupportedDocumentFormats(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetSupportedDocumentFormats)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<SupportedFileFormats, DocumentTranslationGetSupportedDocumentFormatsHeaders> response = _serviceRestClient.GetSupportedDocumentFormats(cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of the document formats supported by the Document Translation service.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        public virtual async Task<Response<IReadOnlyList<FileFormat>>> GetSupportedDocumentFormatsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(DocumentTranslationClient)}.{nameof(GetSupportedDocumentFormats)}");
            scope.Start();

            try
            {
                ResponseWithHeaders<SupportedFileFormats, DocumentTranslationGetSupportedDocumentFormatsHeaders> response = await _serviceRestClient.GetSupportedDocumentFormatsAsync(cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #endregion

        #region nobody wants to see these
        /// <summary>
        /// Check if two TextAnalyticsClient instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Get a hash code for the TextAnalyticsClient.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// TextAnalyticsClient ToString.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
        #endregion
    }
}
