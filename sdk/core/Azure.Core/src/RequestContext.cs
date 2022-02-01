﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure
{
    /// <summary>
    /// Options which can be used to control the behavior of a request sent by a client.
    /// </summary>
    public class RequestContext
    {
        internal List<(HttpPipelinePosition Position, HttpPipelinePolicy Policy)>? Policies { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class.
        /// </summary>
        public RequestContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContext"/> class using the given <see cref="ErrorOptions"/>.
        /// </summary>
        /// <param name="options"></param>
        public static implicit operator RequestContext(ErrorOptions options) => new RequestContext { ErrorOptions = options };

        /// <summary>
        /// The token to check for cancellation.
        /// </summary>
        public CancellationToken CancellationToken { get; set; } = CancellationToken.None;

        /// <summary>
        /// Controls under what conditions the operation raises an exception if the underlying response indicates a failure.
        /// </summary>
        public ErrorOptions ErrorOptions { get; set; } = ErrorOptions.Default;

        /// <summary>
        /// Adds an <see cref="HttpPipelinePolicy"/> into the pipeline for the duration of this request.
        /// The position of policy in the pipeline is controlled by <paramref name="position"/> parameter.
        /// If you want the policy to execute once per client request use <see cref="HttpPipelinePosition.PerCall"/>
        /// otherwise use <see cref="HttpPipelinePosition.PerRetry"/> to run the policy for every retry.
        /// </summary>
        /// <param name="policy">The <see cref="HttpPipelinePolicy"/> instance to be added to the pipeline.</param>
        /// <param name="position">The position of the policy in the pipeline.</param>
        public void AddPolicy(HttpPipelinePolicy policy, HttpPipelinePosition position)
        {
            Policies ??= new();
            Policies.Add((position, policy));
        }

        /// <summary>
        /// Adds a custom classifier to the <see cref="ResponseClassifier"/> used in this call to the service method.
        /// The custom classifier is applied before the default classifier.
        /// This is useful in cases where you'd like to prevent specific response status codes from appearing as errors in
        /// logging and distributed tracing.  It will also prevent the call from throwing an exception when a response with
        /// this status code is received.
        /// </summary>
        /// <param name="statusCodes">The status codes to classify differently in this call.</param>
        /// <param name="isError">Whether or not the passed-in status codes will be considered errors.</param>
        public void AddClassifier(int[] statusCodes, bool isError)
        {
            CopyOrMerge(statusCodes, ref isError ? ref ErrorCodes : ref NonErrorCodes);
        }

        internal int[]? ErrorCodes;
        internal int[]? NonErrorCodes;

        private static void CopyOrMerge(int[] source, ref int[]? target)
        {
            if (target == null)
            {
                target = new int[source.Length];
                Array.Copy(source, target, source.Length);
            }
            else // merge arrays
            {
                var origLength = target.Length;
                Array.Resize(ref target, source.Length + target.Length);
                Array.Copy(source, 0, target, origLength, source.Length);
            }
        }
    }
}
