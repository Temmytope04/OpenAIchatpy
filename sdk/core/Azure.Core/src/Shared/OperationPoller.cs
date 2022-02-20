// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Core
{
    /// <summary>
    /// Implementation of LRO polling logic.
    /// </summary>
    internal class OperationPoller
    {
        public delegate Response UpdateStatus(CancellationToken cancellationToken = default);
        public delegate ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken);
        public delegate bool HasCompleted();
        public delegate Response GetRawResponse();
        public delegate T Value<T>();

        private OperationPollingStrategy _pollingStrategy;

        public OperationPoller(Response rawResponse, OperationPollingStrategy? defaultPollingStrategy = null)
        {
            _pollingStrategy = OperationPollingStrategy.ChoosePollingStrategy(rawResponse, defaultPollingStrategy);
        }

        public virtual ValueTask<Response> WaitForCompletionResponseAsync(Operation operation, TimeSpan? pollingInterval, CancellationToken cancellationToken)
            => WaitForCompletionResponseAsync(operation.UpdateStatusAsync, () => operation.HasCompleted, operation.GetRawResponse, pollingInterval, cancellationToken);

        public virtual async ValueTask<Response> WaitForCompletionResponseAsync(UpdateStatusAsync updateStatusAsync, HasCompleted hasCompleted, GetRawResponse getRawResponse, TimeSpan? pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                Response response = await updateStatusAsync(cancellationToken).ConfigureAwait(false);

                if (hasCompleted())
                {
                    return getRawResponse();
                }

                await Task.Delay(_pollingStrategy.GetNextWait(response, pollingInterval), cancellationToken).ConfigureAwait(false);
            }
        }

        public virtual Response WaitForCompletionResponse(Operation operation, TimeSpan? pollingInterval, CancellationToken cancellationToken)
            => WaitForCompletionResponse(operation.UpdateStatus, () => operation.HasCompleted, operation.GetRawResponse, pollingInterval, cancellationToken);

        public virtual Response WaitForCompletionResponse(UpdateStatus updateStatus, HasCompleted hasCompleted, GetRawResponse getRawResponse, TimeSpan? pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                Response response = updateStatus(cancellationToken);

                if (hasCompleted())
                {
                    return getRawResponse();
                }

                Thread.Sleep(_pollingStrategy.GetNextWait(response, pollingInterval));
            }
        }

        public virtual ValueTask<Response<T>> WaitForCompletionAsync<T>(Operation<T> operation, TimeSpan? pollingInterval, CancellationToken cancellationToken) where T : notnull
           => WaitForCompletionAsync(operation.UpdateStatusAsync, () => operation.HasCompleted, () => operation.Value, operation.GetRawResponse, pollingInterval, cancellationToken);

        public virtual async ValueTask<Response<T>> WaitForCompletionAsync<T>(UpdateStatusAsync updateStatusAsync, HasCompleted hasCompleted, Value<T> value, GetRawResponse getRawResponse, TimeSpan? pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                Response response = await updateStatusAsync(cancellationToken).ConfigureAwait(false);

                if (hasCompleted())
                {
                    return Response.FromValue(value(), getRawResponse());
                }

                await Task.Delay(_pollingStrategy.GetNextWait(response, pollingInterval), cancellationToken).ConfigureAwait(false);
            }
        }

        public virtual Response<T> WaitForCompletion<T>(Operation<T> operation, TimeSpan? pollingInterval, CancellationToken cancellationToken) where T : notnull
           => WaitForCompletion(operation.UpdateStatus, () => operation.HasCompleted, () => operation.Value, operation.GetRawResponse, pollingInterval, cancellationToken);

        public virtual Response<T> WaitForCompletion<T>(UpdateStatus updateStatus, HasCompleted hasCompleted, Value<T> value, GetRawResponse getRawResponse, TimeSpan? pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                Response response = updateStatus(cancellationToken);

                if (hasCompleted())
                {
                    return Response.FromValue(value(), getRawResponse());
                }

                Thread.Sleep(_pollingStrategy.GetNextWait(response, pollingInterval));
            }
        }
    }
}
