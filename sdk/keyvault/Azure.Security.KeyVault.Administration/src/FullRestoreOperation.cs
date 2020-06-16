﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Security.KeyVault.Administration;
using Azure.Security.KeyVault.Administration.Models;

/// <summary>
/// A long-running operation for <see cref="KeyVaultBackupClient.StartFullRestore(Uri, string, string, CancellationToken)"/> or <see cref="KeyVaultBackupClient.StartFullRestoreAsync(Uri, string, string, CancellationToken)"/>.
/// </summary>
public class FullRestoreOperation : Operation<FullRestoreDetails>
{
    /// <summary>
    /// The number of seconds recommended by the service to delay before checking on completion status.
    /// </summary>
    private readonly int? _retryAfterSeconds;
    private readonly KeyVaultBackupClient _client;
    private Response _response;
    private FullRestoreDetails _value;


    /// <summary>
    /// Creates an instance of a FullRestoreOperation from a previously started operation. <see cref="UpdateStatus(CancellationToken)"/>, <see cref="UpdateStatusAsync(CancellationToken)"/>,
    ///  <see cref="WaitForCompletionAsync(CancellationToken)"/>, or <see cref="WaitForCompletionAsync(TimeSpan, CancellationToken)"/> must be called
    /// to re-populate the details of this operation.
    /// </summary>
    /// <param name="jobId">The <see cref="Id" /> from a previous <see cref="FullBackupOperation" />.</param>
    /// <param name="client">An instance of <see cref="KeyVaultBackupClient" />.</param>
    public FullRestoreOperation(string jobId, KeyVaultBackupClient client)
    {
        Argument.AssertNotNull(jobId, nameof(jobId));
        Argument.AssertNotNull(client, nameof(client));

        _client = client;
        _value = new FullRestoreDetails(string.Empty, string.Empty, null, jobId, null, null);
    }

    /// <summary>
    /// Initializes a new instance of a FullRestoreOperation.
    /// </summary>
    /// <param name="client">An instance of <see cref="KeyVaultBackupClient" />.</param>
    /// <param name="response">The <see cref="ResponseWithHeaders{T, THeaders}" /> returned from <see cref="KeyVaultBackupClient.StartFullRestore(Uri, string, string, CancellationToken)"/> or <see cref="KeyVaultBackupClient.StartFullRestoreAsync(Uri, string, string, CancellationToken)"/>.</param>
    internal FullRestoreOperation(KeyVaultBackupClient client, ResponseWithHeaders<FullRestoreDetails, ServiceFullRestoreOperationHeaders> response)
    {
        Argument.AssertNotNull(client, nameof(client));
        Argument.AssertNotNull(response, nameof(response));

        _client = client;
        _response = response.GetRawResponse();
        _retryAfterSeconds = response.Headers.RetryAfter;
        _value = response.Value ?? throw new InvalidOperationException("The response does not contain a value.");
    }

    /// <summary>
    /// Initializes a new instance of a FullRestoreOperation for mocking purposes.
    /// </summary>
    /// <param name="value">The <see cref="FullRestoreDetails" /> that will be returned from <see cref="Value" />.</param>
    /// <param name="response">The <see cref="Response" /> that will be returned from <see cref="GetRawResponse" />.</param>
    /// <param name="client">An instance of <see cref="KeyVaultBackupClient" />.</param>
    internal FullRestoreOperation(FullRestoreDetails value, Response response, KeyVaultBackupClient client)
    {
        Argument.AssertNotNull(value, nameof(value));
        Argument.AssertNotNull(response, nameof(response));
        Argument.AssertNotNull(client, nameof(client));

        _client = client;
        _response = response;
        _value = value;
    }

    /// <inheritdoc/>
    public override string Id => _value.JobId;

    /// <summary>
    /// Gets the <see cref="FullRestoreDetails"/> of the backup operation.
    /// You should await <see cref="WaitForCompletionAsync(CancellationToken)"/> before attempting to use a key in this pending state.
    /// </summary>
    public override FullRestoreDetails Value => _value;

    /// <inheritdoc/>
    public override bool HasCompleted => _value.EndTime.HasValue;

    /// <inheritdoc/>
    public override bool HasValue => true;

    /// <inheritdoc/>
    public override Response GetRawResponse() => _response;

    /// <inheritdoc/>
    public override Response UpdateStatus(CancellationToken cancellationToken = default)
    {
        if (!HasCompleted)
        {
            Response<FullRestoreDetails> response = _client.GetFullRestoreDetails(Id, cancellationToken);
            _value = response.Value;
            _response = response.GetRawResponse();
        }

        return GetRawResponse();
    }

    /// <inheritdoc/>
    public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default)
    {
        if (!HasCompleted)
        {
            Response<FullRestoreDetails> response = await _client.GetFullRestoreDetailsAsync(Id, cancellationToken).ConfigureAwait(false);
            _value = response.Value;
            _response = response.GetRawResponse();
        }

        return GetRawResponse();
    }

    /// <inheritdoc/>
    public override ValueTask<Response<FullRestoreDetails>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
        _retryAfterSeconds.HasValue ? this.DefaultWaitForCompletionAsync(TimeSpan.FromSeconds(_retryAfterSeconds.Value), cancellationToken) :
            this.DefaultWaitForCompletionAsync(cancellationToken);

    /// <inheritdoc/>
    public override ValueTask<Response<FullRestoreDetails>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken) =>
        this.DefaultWaitForCompletionAsync(pollingInterval, cancellationToken);
}
